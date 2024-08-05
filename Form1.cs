using Microsoft.Web.WebView2.Core;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Text.Json;
using OtpNet;

namespace GetEACookie
{
    public partial class Form1 : Form
    {

        private string _secret;
        private const int OtpValidityPeriod = 30; // OTP 有效期（秒）

        public Form1()
        {
            InitializeComponent();
            SetupOtpGenerator();
        }

        private void webView21_CoreWebView2InitializationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs e)
        {
            try
            {
                string Version = webView21.CoreWebView2.Environment.BrowserVersionString;
                webView21.CoreWebView2.Settings.AreDevToolsEnabled = false;
                webView21.CoreWebView2.Settings.AreDefaultContextMenusEnabled = false;
                webView21.CoreWebView2.Settings.IsZoomControlEnabled = false;
                webView21.CoreWebView2.Settings.IsStatusBarEnabled = false;
                webView21.CoreWebView2.NewWindowRequested += CoreWebView2_NewWindowRequested;
                webView21.CoreWebView2.SourceChanged += CoreWebView2_SourceChanged;
                webView21.CoreWebView2.Navigate("https://accounts.ea.com/connect/auth?client_id=sparta-backend-as-user-pc&response_type=code&release_type=none");
            }
            catch (Exception)
            {
                MessageBox.Show("你的电脑缺少WebView2环境，请下载安装后继续\nYour computer lacks the WebView2 environment, please download and install it to continue", "提示 Info");
                System.Environment.Exit(0);
            }


        }
        private void CoreWebView2_NewWindowRequested(object sender, CoreWebView2NewWindowRequestedEventArgs e)
        {
            var deferral = e.GetDeferral();
            e.NewWindow = webView21.CoreWebView2;
            deferral.Complete();
        }
        private async void CoreWebView2_SourceChanged(object sender, CoreWebView2SourceChangedEventArgs e)
        {
            var cookies = await webView21.CoreWebView2.CookieManager.GetCookiesAsync(null);
            string sid = null;
            string remid = null;
            foreach (var item in cookies)
            {
                if (item.Name == "remid")
                {
                    if (!string.IsNullOrEmpty(item.Value))
                    {
                        remid = item.Value;
                    }
                    continue;
                }

                if (item.Name == "sid")
                {
                    if (!string.IsNullOrEmpty(item.Value))
                    {
                        sid = item.Value;
                    }
                    continue;
                }
            }
            if (sid != null && remid != null)
            {
                string configPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.json");
                var config = new Dictionary<string, string>
                    {
                        { "sid", sid },
                        { "remid", remid }
                    };
                try
                {
                    // 检查文件是否存在
                    if (File.Exists(configPath))
                    {
                        // 文件存在，读取现有内容
                        var existingContent = File.ReadAllText(configPath);
                        var existingConfig = JsonSerializer.Deserialize<Dictionary<string, object>>(existingContent);

                        if (existingConfig == null)
                        {
                            existingConfig = new Dictionary<string, object>();
                        }

                        // 合并新字段到现有内容中
                        foreach (var field in config)
                        {
                            existingConfig[field.Key] = field.Value;
                        }

                        // 将更新后的内容写回文件
                        string updatedJsonString = JsonSerializer.Serialize(existingConfig, new JsonSerializerOptions { WriteIndented = true });
                        File.WriteAllText(configPath, updatedJsonString);
                    }
                    else
                    {
                        // 文件不存在，直接写入新内容
                        string newJsonString = JsonSerializer.Serialize(config, new JsonSerializerOptions { WriteIndented = true });
                        File.WriteAllText(configPath, newJsonString);
                    }

                    textBox1.Text = remid;
                    textBox2.Text = sid;
                    MessageBox.Show("获取Cookie成功! 请前往程序文本栏处复制或程序根目录cookie.json文件夹查看cookie\nGet Cookie successfully! Please go to the program text bar to copy or the program root directory cookie.json folder to view the cookie", "获取成功 Get Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"发生错误: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "config.json"))
            {
                File.Delete(AppDomain.CurrentDomain.BaseDirectory + "config.json");
            }
            textBox1.Text = "";
            textBox2.Text = "";
            webView21.CoreWebView2.ExecuteScriptAsync("localStorage.clear()");
            webView21.CoreWebView2.CookieManager.DeleteAllCookies();
            webView21.Reload();
            webView21.Source = new Uri("https://accounts.ea.com/connect/auth?client_id=sparta-backend-as-user-pc&response_type=code&release_type=none");

            MessageBox.Show("缓存已经删除成功，请重新登录\nThe cache has been deleted successfully, please log in again", "提示 Info");
        }

        private void label6_Click(object sender, EventArgs e)
        {
            try
            {
                // 创建一个新的ProcessStartInfo实例
                var psi = new ProcessStartInfo
                {
                    FileName = "https://github.com/BF-CAT-Team/GetCookieTools", // 设置URL为要打开的链接
                    UseShellExecute = true // 必须设置为true才能打开默认浏览器
                };

                // 启动与上述启动信息相关的进程
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"无法打开链接: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            try
            {
                // 创建一个新的ProcessStartInfo实例
                var psi = new ProcessStartInfo
                {
                    FileName = "https://bfvrobot.net", // 设置URL为要打开的链接
                    UseShellExecute = true // 必须设置为true才能打开默认浏览器
                };

                // 启动与上述启动信息相关的进程
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"无法打开链接: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (textBox2 != null && !string.IsNullOrEmpty(textBox2.Text))
            {
                Clipboard.SetText(textBox2.Text);
                MessageBox.Show("Sid已复制到剪贴板！\nSid copied to clipboard!", "成功 SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Sid文本框为空或不存在。\nThe text box is empty or does not exist.", "错误 ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1 != null && !string.IsNullOrEmpty(textBox1.Text))
            {
                Clipboard.SetText(textBox1.Text);
                MessageBox.Show("Remid已复制到剪贴板！\nRemid copied to clipboard!", "成功 SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Remid文本框为空或不存在。\nThe text box is empty or does not exist.", "错误 ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }




        private void OnOtpTimerTick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_secret))
                return;

            var otp = GenerateOtp(_secret);
            label9.Text = otp;

            int elapsed = (int)DateTime.Now.Subtract(DateTime.Now.Date).TotalSeconds;
            int remaining = OtpValidityPeriod - (elapsed % OtpValidityPeriod);
            progressBar1.Value = (int)(100 - (double)remaining / OtpValidityPeriod * 100);
        }

        private void SetupOtpGenerator()
        {
            timer1.Interval = 1000; // 每秒钟触发一次
            timer1.Tick += OnOtpTimerTick;
            timer1.Start();
        }

        private static string GenerateOtp(string secret)
        {
            try
            {
                var otpKey = Base32Encoding.ToBytes(secret);
                var otp = new Totp(otpKey);
                return otp.ComputeTotp();
            }
            catch (Exception)
            {
                return "-1";
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            _secret = textBox3.Text;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(label9.Text))
            {
                Clipboard.SetText(label9.Text);
                MessageBox.Show("OTP copied to clipboard!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
