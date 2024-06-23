using Microsoft.Web.WebView2.Core;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;

namespace GetEACookie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
                MessageBox.Show("��ĵ���ȱ��WebView2�����������ذ�װ�����\nYour computer lacks the WebView2 environment, please download and install it to continue", "��ʾ Info");
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
                string jsonString = System.Text.Json.JsonSerializer.Serialize(config); // �޸Ĵ˴��������ռ�
                File.WriteAllText(configPath, jsonString);
                textBox1.Text = remid;
                textBox2.Text = sid;
                MessageBox.Show("��ȡCookie�ɹ�! ��ǰ�������ı�����������Ŀ¼cookie.json�ļ��в鿴cookie\nSuccessfully obtained cookies! Please go to the program text bar or the program root directory cookie.txt folder to view the cookies", "��ȡ�ɹ� Get Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            MessageBox.Show("�����Ѿ�ɾ���ɹ��������µ�¼\nThe cache has been deleted successfully, please log in again", "��ʾ Info");
        }

        private void label6_Click(object sender, EventArgs e)
        {
            try
            {
                // ����һ���µ�ProcessStartInfoʵ��
                var psi = new ProcessStartInfo
                {
                    FileName = "https://github.com/BF-CAT-Team/GetCookieTools", // ����URLΪҪ�򿪵�����
                    UseShellExecute = true // ��������Ϊtrue���ܴ�Ĭ�������
                };

                // ����������������Ϣ��صĽ���
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"�޷�������: {ex.Message}", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            try
            {
                // ����һ���µ�ProcessStartInfoʵ��
                var psi = new ProcessStartInfo
                {
                    FileName = "https://bfvrobot.net", // ����URLΪҪ�򿪵�����
                    UseShellExecute = true // ��������Ϊtrue���ܴ�Ĭ�������
                };

                // ����������������Ϣ��صĽ���
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"�޷�������: {ex.Message}", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
