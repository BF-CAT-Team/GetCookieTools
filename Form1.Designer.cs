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
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(509, 35);
            webView21.Name = "webView21";
            webView21.Size = new Size(510, 945);
            webView21.Source = new Uri("https://accounts.ea.com/connect/auth?client_id=sparta-backend-as-user-pc&response_type=code&release_type=none", UriKind.Absolute);
            webView21.TabIndex = 0;
            webView21.ZoomFactor = 1D;
            webView21.CoreWebView2InitializationCompleted += webView21_CoreWebView2InitializationCompleted;
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(74, 935);
            button1.Name = "button1";
            button1.Size = new Size(373, 82);
            button1.TabIndex = 1;
            button1.Text = "删除缓存重新登录 \r\nDelete the cache and log in again";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial Narrow", 8F);
            textBox1.Location = new Point(91, 35);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(400, 118);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 79);
            label1.Name = "label1";
            label1.Size = new Size(68, 21);
            label1.TabIndex = 3;
            label1.Text = "REMID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 225);
            label2.Name = "label2";
            label2.Size = new Size(44, 24);
            label2.TabIndex = 5;
            label2.Text = "SID";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Arial Narrow", 8F);
            textBox2.Location = new Point(91, 177);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(400, 119);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label3.Location = new Point(70, 312);
            label3.Name = "label3";
            label3.Size = new Size(369, 175);
            label3.TabIndex = 6;
            label3.Text = "如何使用?\r\n首先 打开本程序 等待右侧浏览器加载\r\n然后 在浏览器中执行登录EA账户操作 \r\n可勾选记住本设备 登录成功之后 \r\n本程序会弹出获取cookie成功的提示\r\n可在本程序上方文本框读取cookie\r\n或在根目录的config.json文件中查看cookie";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei UI", 7.5F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label4.Location = new Point(35, 502);
            label4.Name = "label4";
            label4.Size = new Size(448, 228);
            label4.TabIndex = 7;
            label4.Text = resources.GetString("label4.Text");
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label5.ForeColor = Color.Maroon;
            label5.Location = new Point(43, 732);
            label5.Name = "label5";
            label5.Size = new Size(420, 200);
            label5.TabIndex = 8;
            label5.Text = "重要!!!\r\n同一天内不要过多执行登录操作\r\nEA会对频繁获取Cookie的IP进行封禁并封号\r\n\r\nImportant!!!\r\nDo not log in too many times in the same day\r\nEA will block and suspend \r\nIP addresses that frequently obtain cookies";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.Hand;
            label6.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label6.ForeColor = SystemColors.Highlight;
            label6.Location = new Point(844, 995);
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
            label7.Location = new Point(935, 995);
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
            label8.Location = new Point(626, 995);
            label8.Name = "label8";
            label8.Size = new Size(203, 25);
            label8.TabIndex = 11;
            label8.Text = "Ver 0.0.1 By B1397KB";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 1029);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(webView21);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            Text = "获取EA账户Cookies  Get EA Account Cookies";
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
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
    }
}
