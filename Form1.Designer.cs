namespace GetEACookie
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button2 = new Button();
            button3 = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox1 = new GroupBox();
            label10 = new Label();
            textBox3 = new TextBox();
            label9 = new Label();
            progressBar1 = new ProgressBar();
            tabPage2 = new TabPage();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(561, 6);
            webView21.Name = "webView21";
            webView21.Size = new Size(535, 931);
            webView21.Source = new Uri("https://accounts.ea.com/connect/auth?client_id=sparta-backend-as-user-pc&response_type=code&release_type=none", UriKind.Absolute);
            webView21.TabIndex = 0;
            webView21.ZoomFactor = 1D;
            webView21.CoreWebView2InitializationCompleted += webView21_CoreWebView2InitializationCompleted;
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(32, 810);
            button1.Name = "button1";
            button1.Size = new Size(476, 101);
            button1.TabIndex = 1;
            button1.Text = "删除缓存重新登录 \r\nDelete the cache and log in again";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(131, 29);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '*';
            textBox1.Size = new Size(366, 151);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 45);
            label1.Name = "label1";
            label1.Size = new Size(91, 29);
            label1.TabIndex = 3;
            label1.Text = "REMID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(41, 239);
            label2.Name = "label2";
            label2.Size = new Size(53, 29);
            label2.TabIndex = 5;
            label2.Text = "SID";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(131, 203);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(366, 145);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label3.Location = new Point(65, 94);
            label3.Name = "label3";
            label3.Size = new Size(1005, 148);
            label3.TabIndex = 6;
            label3.Text = "如何使用?\r\n首先 打开本程序 等待右侧浏览器加载  然后 在浏览器中执行登录EA账户操作 \r\n可勾选记住本设备 登录成功之后 本程序会弹出获取cookie成功的提示\r\n可在本程序上方文本框读取cookie 或在根目录的config.json文件中查看cookie";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label4.Location = new Point(65, 307);
            label4.Name = "label4";
            label4.Size = new Size(979, 196);
            label4.TabIndex = 7;
            label4.Text = resources.GetString("label4.Text");
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label5.ForeColor = Color.Maroon;
            label5.Location = new Point(230, 547);
            label5.Name = "label5";
            label5.Size = new Size(657, 259);
            label5.TabIndex = 8;
            label5.Text = "重要!!!\r\n同一天内不要过多执行登录操作\r\nEA会对频繁获取Cookie的IP进行封禁并封号\r\nImportant!!!\r\nDo not log in too many times in the same day\r\nEA will block and suspend \r\nIP addresses that frequently obtain cookies";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.Hand;
            label6.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label6.ForeColor = SystemColors.Highlight;
            label6.Location = new Point(944, 995);
            label6.Name = "label6";
            label6.Size = new Size(77, 25);
            label6.TabIndex = 9;
            label6.Text = "GitHub";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Cursor = Cursors.Hand;
            label7.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label7.ForeColor = SystemColors.Highlight;
            label7.Location = new Point(1035, 995);
            label7.Name = "label7";
            label7.Size = new Size(84, 25);
            label7.TabIndex = 10;
            label7.Text = "Website";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label8.Location = new Point(726, 995);
            label8.Name = "label8";
            label8.Size = new Size(203, 25);
            label8.TabIndex = 11;
            label8.Text = "Ver 0.0.3 By B1397KB";
            // 
            // button2
            // 
            button2.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(18, 89);
            button2.Name = "button2";
            button2.Size = new Size(98, 60);
            button2.TabIndex = 12;
            button2.Text = "复制\r\nCopy";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(18, 271);
            button3.Name = "button3";
            button3.Size = new Size(98, 60);
            button3.TabIndex = 13;
            button3.Text = "复制\r\nCopy";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1111, 980);
            tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(webView21);
            tabPage1.Location = new Point(4, 33);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1103, 943);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "主页 Main";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(progressBar1);
            groupBox1.Location = new Point(19, 375);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(498, 270);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "OTP生成器   OTP General";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label10.Location = new Point(13, 51);
            label10.Name = "label10";
            label10.Size = new Size(108, 25);
            label10.TabIndex = 17;
            label10.Text = "密钥 Secret";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 134);
            textBox3.Location = new Point(127, 42);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(351, 43);
            textBox3.TabIndex = 16;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft YaHei UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label9.Location = new Point(93, 120);
            label9.Name = "label9";
            label9.Size = new Size(304, 96);
            label9.TabIndex = 15;
            label9.Text = "000000";
            label9.Click += label9_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(13, 230);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(476, 34);
            progressBar1.TabIndex = 14;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label5);
            tabPage2.Location = new Point(4, 33);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1103, 943);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "使用说明 How to Use";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1131, 1029);
            Controls.Add(tabControl1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            Text = "获取EA账户Cookies  Get EA Account Cookies";
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button2;
        private Button button3;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label10;
        private TextBox textBox3;
        private Label label9;
        private ProgressBar progressBar1;
        private GroupBox groupBox1;
        private System.Windows.Forms.Timer timer1;
    }
}
