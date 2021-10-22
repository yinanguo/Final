using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using SqliteOperateDemo.BLL;
using System.Runtime.InteropServices;

namespace 串口调试
{
    public partial class Form1 : Form
    {
        //[DllImport("user32")]        
         //private static extern bool AnimateWindow(IntPtr whnd, int dwtime, int dwflag);

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern int SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        public Form1()
        {
            InitializeComponent();
            
           // AnimateWindow(this.Handle, 200, 0x00020000 | 0x00080000);
            string[] PortNames = SerialPort.GetPortNames();  //获取所有可用串口
            //默认波特率为115200
            BaudratecomboBox.SelectedItem = Convert.ToString(BaudratecomboBox.Items[2]);
            if (PortNames.Length == 0)  //判断是否有可用端口
            {
                ShowSysMessage(Color.Red, "未找到可用端口！");
                return;
            }
            else
            {
                //向端口设置列表中添加可用端口号
                COMComboBox.Items.AddRange(PortNames);
                COMComboBox.SelectedItem = COMComboBox.Items[0];
                COMLabel.Text = COMComboBox.SelectedItem.ToString();
            }
        }

        private void Open_Click(object sender, EventArgs e)
        {
            if (COMComboBox.SelectedItem == null)
            {
                return;
            }
            else
            {
                if (COM.IsOpen)
                {
                    COM.Close();
                    Open.Text = "打开";
                    ShowSysMessage(Color.Red, "端口：" + COM.PortName + " 已关闭！");
                }
                else
                {
                    COM.PortName = Convert.ToString(COMComboBox.SelectedItem);
                    COM.BaudRate = Convert.ToInt32(BaudratecomboBox.SelectedItem);

                    try
                    {
                        COM.Open();
                        Open.Text = "关闭";
                        COM.DiscardInBuffer();  //丢弃缓冲中的数据
                        ShowSysMessage(Color.Blue, "成功打开：" + COM.PortName + " 端口!");
                    }
                    catch
                    {
                        ShowSysMessage(Color.Red, "打开失败，端口被占用！");
                    }
                }
            }
        }

        private void ShowSysMessage(Color MessageColor, string Message)
        {
            if ((MessageBox.Text.Length != 0)&&(MessageBox.Text[MessageBox.Text.Length - 1] != '\n'))
            {
                Message = '\n' + Message;
            }
            MessageBox.SelectionColor = MessageColor;
            MessageBox.AppendText(Message + '\n');
            MessageBox.ScrollToCaret();  //让滚动条滚到最下面
        }

     
        private void ShowComMessage(Color MessageColor, string Message)
        {
            MessageBox.SelectionColor = MessageColor;
            MessageBox.AppendText(Message);
            string[] recArra = Message.Split(';');
            if (recArra.Length >= 2)
            {
                txtwd.Text = recArra[0];
                txtsd.Text = recArra[1];
            }
            else
            {
                txtyw.Text = Message;
                txtgz.Text = Message;
            }
            if (!string.IsNullOrEmpty(MessageBox.Text))
            {
                SQLBll.InsertValue(DateTime.Now.ToString("yyyy年-MM月-dd日 HH:mm:ss"), txtwd.Text);

            }
            MessageBox.ScrollToCaret();  //让滚动条滚到最下面
           
        }
        //关闭按钮实现
        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.Image = 串口调试.Properties.Resources.Close_MouseEnter;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.Image = 串口调试.Properties.Resources.Close;
        }

        private void CloseButton_MouseClick(object sender, MouseEventArgs e)
        {
            this.Dispose();
        }

        private void CloseButton_MouseDown(object sender, MouseEventArgs e)
        {
            CloseButton.Image = 串口调试.Properties.Resources.Close_MouseClick;
        }

        //最小化按钮实现
        private void MinimizeButton_MouseEnter(object sender, EventArgs e)
        {
            MinimizeButton.Image = 串口调试.Properties.Resources.Minimize_MouseEnter;
        }

        private void MinimizeButton_MouseLeave(object sender, EventArgs e)
        {
            MinimizeButton.Image = 串口调试.Properties.Resources.Minimize;
        }

        private void MinimizeButton_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MinimizeButton_MouseDown(object sender, MouseEventArgs e)
        {
            MinimizeButton.Image = 串口调试.Properties.Resources.Minimize_MouseClick;
        }
        //拖动窗体
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (FormCanMove)
            {
                //记下鼠标当前位置
                Point p = Control.MousePosition;
                //平移MouseDownPoint。  
                p.Offset(MouseDownPoint);  
                //控件的位置，为p位置
                this.Location = p;
            }
        }

        Point MouseDownPoint;
        bool FormCanMove = false;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            //记下鼠标在窗体中按下时的位置
            MouseDownPoint = new Point(-e.X, -e.Y);
            FormCanMove = true;
        }

        //发送按钮实现
       
        private void Open_MouseEnter(object sender, EventArgs e)
        {
            Open.BackColor = Color.FromArgb(255, 0, 0, 135);
        }

        private void Open_MouseLeave(object sender, EventArgs e)
        {
            Open.BackColor = Color.FromArgb(255, 38, 38, 38);
        }

        private void Open_MouseDown(object sender, MouseEventArgs e)
        {
            Open.BackColor = Color.FromArgb(255, 0, 0, 230);
        }

        private void Clear_MouseEnter(object sender, EventArgs e)
        {
            Clear.BackColor = Color.FromArgb(255, 0, 0, 135);
        }

        private void Clear_MouseLeave(object sender, EventArgs e)
        {
            Clear.BackColor = Color.FromArgb(255, 38, 38, 38);
        }

        private void Clear_MouseDown(object sender, MouseEventArgs e)
        {
            Clear.BackColor = Color.FromArgb(255, 0, 0, 230);
        }

        private void Open_MouseUp(object sender, MouseEventArgs e)
        {
            Open.BackColor = Color.FromArgb(255, 0, 0, 135);
        }

        private void Clear_MouseUp(object sender, MouseEventArgs e)
        {
            MessageBox.Clear();
            Clear.BackColor = Color.FromArgb(255, 0, 0, 135);
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            FormCanMove = false;
        }

        bool IsGBKsecondByte = false;
        byte[] GBK= new byte[2];
        private void COM_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int n = COM.BytesToRead;
            Byte[] data = new Byte[n];
            COM.Read(data, 0, n);
            string str = string.Empty;

            foreach (Byte b in data)
            {
                if (((b & 0x80) == 0x80) || IsGBKsecondByte)  //GBK码
                {
                    if (IsGBKsecondByte)  //GBK码第二个字节
                    {
                        GBK[1] = b;
                        IsGBKsecondByte = false;
                        str += Encoding.GetEncoding("GBK").GetString(GBK);
                    }
                    else  //GBK码第一个字节
                    {
                        GBK[0] = b;
                        IsGBKsecondByte = true;
                    }
                } 
                else  //ASCII码
                {
                    str += ((char)b).ToString();
                }
            }

            this.Invoke((EventHandler)delegate
            {
                ShowComMessage(Color.Black, str);
            });                       
        }
        //端口选择组合框下拉
        private void COMpictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            //模拟一次端口选择组合框下 单击操作
            SendMessage(this.COMComboBox.Handle, 0x0201, 0, 0);
            SendMessage(this.COMComboBox.Handle, 0x0202, 0, 0);
        }

        private void COMComboBox_DropDown(object sender, EventArgs e)
        {
            COMpictureBox.Image = 串口调试.Properties.Resources.ArrowHeadUp;
        }

        private void COMComboBox_DropDownClosed(object sender, EventArgs e)
        {
            COMpictureBox.Image = 串口调试.Properties.Resources.ArrowHeadDown;
        }

        private void BaudratecomboBox_DropDown(object sender, EventArgs e)
        {
            BaudratepictureBox.Image = 串口调试.Properties.Resources.ArrowHeadUp;
        }

        private void BaudratecomboBox_DropDownClosed(object sender, EventArgs e)
        {
            BaudratepictureBox.Image = 串口调试.Properties.Resources.ArrowHeadDown;
        }
        //波特率选择组合框下拉
        private void BaudratepictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            //模拟一次波特率选择组合框下 单击操作
            SendMessage(this.BaudratecomboBox.Handle, 0x0201, 0, 0);
            SendMessage(this.BaudratecomboBox.Handle, 0x0202, 0, 0);
        }

        private void COMComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            COMLabel.Text = COMComboBox.SelectedItem.ToString();
        }

        private void BaudratecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Baudratelabel.Text = BaudratecomboBox.SelectedItem.ToString();
        }

        //将0~9 A~F a~f 转为Hex
        private bool ascIItoHex(ref char c)
        {
            if ((c >= 48) && (c <= 57))         //输入字符为0~9
            {
                c -= (char)48;
                return true;
            }
            else if ((c >= 65) && (c <= 70))  //输入字符为A~F
            {
                c -= (char)55;
                return true;
            }
            else if ((c >= 97) && (c <= 102))  //输入字符为a~f
            {
                c -= (char)87;
                return true;
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvData.Rows.Count > 0)
            {
                dgvData.Rows.Clear();
                DataTable table = SQLBll.GetAllValues();
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    int index = dgvData.Rows.Add();
                    //dgvData.Rows[i].Cells[0].Value = index + 1;
                    dgvData.Rows[i].Cells[0].Value = table.Rows[i][0].ToString();//第1列赋值
                    dgvData.Rows[i].Cells[1].Value = table.Rows[i][1].ToString();//第2列赋值
                    dgvData.Rows[i].Cells[2].Value = table.Rows[i][2].ToString();//第3列赋值
                }
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            MessageBox.Clear();
        }

        

      
    }
}
