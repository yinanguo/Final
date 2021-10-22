namespace 串口调试
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.端口 = new System.Windows.Forms.Label();
            this.COMComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BaudratecomboBox = new System.Windows.Forms.ComboBox();
            this.Open = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Label();
            this.Titlelabel = new System.Windows.Forms.Label();
            this.COM = new System.IO.Ports.SerialPort(this.components);
            this.COMLabel = new System.Windows.Forms.Label();
            this.Baudratelabel = new System.Windows.Forms.Label();
            this.BaudratepictureBox = new System.Windows.Forms.PictureBox();
            this.COMpictureBox = new System.Windows.Forms.PictureBox();
            this.MinimizeButton = new System.Windows.Forms.PictureBox();
            this.CloseButton = new System.Windows.Forms.PictureBox();
            this.MessageBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.txtwd = new System.Windows.Forms.TextBox();
            this.txtsd = new System.Windows.Forms.TextBox();
            this.txtyw = new System.Windows.Forms.TextBox();
            this.txtgz = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.BaudratepictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.COMpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // 端口
            // 
            this.端口.AutoSize = true;
            this.端口.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.端口.Location = new System.Drawing.Point(41, 74);
            this.端口.Name = "端口";
            this.端口.Size = new System.Drawing.Size(56, 17);
            this.端口.TabIndex = 7;
            this.端口.Text = "端   口：";
            // 
            // COMComboBox
            // 
            this.COMComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.COMComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMComboBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.COMComboBox.ForeColor = System.Drawing.SystemColors.Window;
            this.COMComboBox.FormattingEnabled = true;
            this.COMComboBox.Location = new System.Drawing.Point(92, 72);
            this.COMComboBox.Name = "COMComboBox";
            this.COMComboBox.Size = new System.Drawing.Size(70, 25);
            this.COMComboBox.TabIndex = 8;
            this.COMComboBox.Visible = false;
            this.COMComboBox.DropDown += new System.EventHandler(this.COMComboBox_DropDown);
            this.COMComboBox.SelectedIndexChanged += new System.EventHandler(this.COMComboBox_SelectedIndexChanged);
            this.COMComboBox.DropDownClosed += new System.EventHandler(this.COMComboBox_DropDownClosed);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(41, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "波特率：";
            // 
            // BaudratecomboBox
            // 
            this.BaudratecomboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.BaudratecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BaudratecomboBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BaudratecomboBox.ForeColor = System.Drawing.Color.White;
            this.BaudratecomboBox.FormattingEnabled = true;
            this.BaudratecomboBox.Items.AddRange(new object[] {
            "9600",
            "38400",
            "115200",
            "256000",
            "460800"});
            this.BaudratecomboBox.Location = new System.Drawing.Point(91, 114);
            this.BaudratecomboBox.Name = "BaudratecomboBox";
            this.BaudratecomboBox.Size = new System.Drawing.Size(70, 25);
            this.BaudratecomboBox.TabIndex = 10;
            this.BaudratecomboBox.Visible = false;
            this.BaudratecomboBox.DropDown += new System.EventHandler(this.BaudratecomboBox_DropDown);
            this.BaudratecomboBox.SelectedIndexChanged += new System.EventHandler(this.BaudratecomboBox_SelectedIndexChanged);
            this.BaudratecomboBox.DropDownClosed += new System.EventHandler(this.BaudratecomboBox_DropDownClosed);
            // 
            // Open
            // 
            this.Open.BackColor = System.Drawing.Color.MediumPurple;
            this.Open.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Open.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Open.Location = new System.Drawing.Point(90, 165);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(70, 20);
            this.Open.TabIndex = 11;
            this.Open.Text = "打开";
            this.Open.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.MediumPurple;
            this.Clear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Clear.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Clear.Location = new System.Drawing.Point(41, 165);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(44, 20);
            this.Clear.TabIndex = 12;
            this.Clear.Text = "清除";
            this.Clear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Titlelabel
            // 
            this.Titlelabel.AutoSize = true;
            this.Titlelabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Titlelabel.Location = new System.Drawing.Point(12, 7);
            this.Titlelabel.Name = "Titlelabel";
            this.Titlelabel.Size = new System.Drawing.Size(56, 17);
            this.Titlelabel.TabIndex = 13;
            this.Titlelabel.Text = "环境监测";
            // 
            // COM
            // 
            this.COM.BaudRate = 115200;
            this.COM.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.COM_DataReceived);
            // 
            // COMLabel
            // 
            this.COMLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.COMLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.COMLabel.Location = new System.Drawing.Point(92, 75);
            this.COMLabel.Name = "COMLabel";
            this.COMLabel.Size = new System.Drawing.Size(70, 20);
            this.COMLabel.TabIndex = 14;
            this.COMLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Baudratelabel
            // 
            this.Baudratelabel.BackColor = System.Drawing.Color.MediumPurple;
            this.Baudratelabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Baudratelabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Baudratelabel.ForeColor = System.Drawing.Color.White;
            this.Baudratelabel.Location = new System.Drawing.Point(91, 118);
            this.Baudratelabel.Name = "Baudratelabel";
            this.Baudratelabel.Size = new System.Drawing.Size(70, 20);
            this.Baudratelabel.TabIndex = 16;
            this.Baudratelabel.Text = "115200";
            this.Baudratelabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BaudratepictureBox
            // 
            this.BaudratepictureBox.Image = global::串口调试.Properties.Resources.ArrowHeadDown;
            this.BaudratepictureBox.Location = new System.Drawing.Point(143, 118);
            this.BaudratepictureBox.Name = "BaudratepictureBox";
            this.BaudratepictureBox.Size = new System.Drawing.Size(18, 18);
            this.BaudratepictureBox.TabIndex = 17;
            this.BaudratepictureBox.TabStop = false;
            this.BaudratepictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BaudratepictureBox_MouseDown);
            // 
            // COMpictureBox
            // 
            this.COMpictureBox.Image = global::串口调试.Properties.Resources.ArrowHeadDown;
            this.COMpictureBox.Location = new System.Drawing.Point(144, 74);
            this.COMpictureBox.Name = "COMpictureBox";
            this.COMpictureBox.Size = new System.Drawing.Size(18, 18);
            this.COMpictureBox.TabIndex = 15;
            this.COMpictureBox.TabStop = false;
            this.COMpictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.COMpictureBox_MouseDown);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.ErrorImage = null;
            this.MinimizeButton.Image = global::串口调试.Properties.Resources.Minimize;
            this.MinimizeButton.InitialImage = global::串口调试.Properties.Resources.Close;
            this.MinimizeButton.Location = new System.Drawing.Point(378, -2);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(24, 24);
            this.MinimizeButton.TabIndex = 1;
            this.MinimizeButton.TabStop = false;
            this.MinimizeButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MinimizeButton_MouseClick);
            this.MinimizeButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MinimizeButton_MouseDown);
            this.MinimizeButton.MouseEnter += new System.EventHandler(this.MinimizeButton_MouseEnter);
            this.MinimizeButton.MouseLeave += new System.EventHandler(this.MinimizeButton_MouseLeave);
            // 
            // CloseButton
            // 
            this.CloseButton.ErrorImage = null;
            this.CloseButton.Image = global::串口调试.Properties.Resources.Close;
            this.CloseButton.InitialImage = global::串口调试.Properties.Resources.Close;
            this.CloseButton.Location = new System.Drawing.Point(402, -2);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(24, 24);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.TabStop = false;
            this.CloseButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CloseButton_MouseClick);
            this.CloseButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CloseButton_MouseDown);
            this.CloseButton.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            // 
            // MessageBox
            // 
            this.MessageBox.BackColor = System.Drawing.Color.White;
            this.MessageBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MessageBox.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MessageBox.ForeColor = System.Drawing.Color.White;
            this.MessageBox.Location = new System.Drawing.Point(198, 62);
            this.MessageBox.Name = "MessageBox";
            this.MessageBox.ReadOnly = true;
            this.MessageBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.MessageBox.Size = new System.Drawing.Size(282, 111);
            this.MessageBox.TabIndex = 2;
            this.MessageBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(242, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 24);
            this.label2.TabIndex = 24;
            this.label2.Text = "数据显示区";
            // 
            // dgvData
            // 
            this.dgvData.BackgroundColor = System.Drawing.Color.Gray;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvData.Location = new System.Drawing.Point(42, 231);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowTemplate.Height = 23;
            this.dgvData.Size = new System.Drawing.Size(438, 107);
            this.dgvData.TabIndex = 25;
            // 
            // Column1
            // 
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "id";
            this.Column1.Name = "Column1";
            this.Column1.Width = 60;
            // 
            // Column2
            // 
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column2.HeaderText = "时间";
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column3.HeaderText = "数据";
            this.Column3.Name = "Column3";
            this.Column3.Width = 60;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(44, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 22);
            this.button1.TabIndex = 26;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtwd
            // 
            this.txtwd.Location = new System.Drawing.Point(198, 190);
            this.txtwd.Name = "txtwd";
            this.txtwd.Size = new System.Drawing.Size(48, 21);
            this.txtwd.TabIndex = 27;
            // 
            // txtsd
            // 
            this.txtsd.Location = new System.Drawing.Point(276, 190);
            this.txtsd.Name = "txtsd";
            this.txtsd.Size = new System.Drawing.Size(48, 21);
            this.txtsd.TabIndex = 28;
            // 
            // txtyw
            // 
            this.txtyw.Location = new System.Drawing.Point(354, 190);
            this.txtyw.Name = "txtyw";
            this.txtyw.Size = new System.Drawing.Size(48, 21);
            this.txtyw.TabIndex = 29;
            // 
            // txtgz
            // 
            this.txtgz.Location = new System.Drawing.Point(432, 190);
            this.txtgz.Name = "txtgz";
            this.txtgz.Size = new System.Drawing.Size(48, 21);
            this.txtgz.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(502, 359);
            this.Controls.Add(this.txtgz);
            this.Controls.Add(this.txtyw);
            this.Controls.Add(this.txtsd);
            this.Controls.Add(this.txtwd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MessageBox);
            this.Controls.Add(this.BaudratepictureBox);
            this.Controls.Add(this.Baudratelabel);
            this.Controls.Add(this.COMpictureBox);
            this.Controls.Add(this.COMLabel);
            this.Controls.Add(this.Titlelabel);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.BaudratecomboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.COMComboBox);
            this.Controls.Add(this.端口);
            this.Controls.Add(this.MinimizeButton);
            this.Controls.Add(this.CloseButton);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "串口调试";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.BaudratepictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.COMpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox CloseButton;
        private System.Windows.Forms.PictureBox MinimizeButton;
        private System.Windows.Forms.Label 端口;
        private System.Windows.Forms.ComboBox COMComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox BaudratecomboBox;
        private System.Windows.Forms.Label Open;
        private System.Windows.Forms.Label Clear;
        private System.Windows.Forms.Label Titlelabel;
        private System.IO.Ports.SerialPort COM;
        private System.Windows.Forms.Label COMLabel;
        private System.Windows.Forms.PictureBox COMpictureBox;
        private System.Windows.Forms.Label Baudratelabel;
        private System.Windows.Forms.PictureBox BaudratepictureBox;
        private System.Windows.Forms.RichTextBox MessageBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.TextBox txtwd;
        private System.Windows.Forms.TextBox txtsd;
        private System.Windows.Forms.TextBox txtyw;
        private System.Windows.Forms.TextBox txtgz;
    }
}

