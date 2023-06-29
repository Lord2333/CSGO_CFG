using System;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net;
using System.IO;
using System.Collections.Generic;

namespace CSGO_cfg
{
    public partial class WebDav : Form
    {
        private HttpClient client;
        public WebDav(HttpClient Client)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;  // 在屏幕中央出现
            client = Client;
        }

        protected override async void OnLoad(EventArgs e)
        {
            var response = await client.GetAsync("http://127.0.0.1:5888/cfg");  // 启动时请求一次下载配置
            string json = await response.Content.ReadAsStringAsync();
            if(json != "")
            {
                // 解析JSON数据
                dynamic data = JsonConvert.DeserializeObject(json);

                // 获取email和pwd的值
                string WebDav = data.WebDav;
                string email = data.Email;
                string pwd = data.Password;
                this.WebDav_textBox.Text = WebDav;
                this.Account_textBox.Text = email;
                this.Pwd_textBox.Text = pwd;
            }
        }

        private void Test_Btn_Click(object sender, EventArgs e)
        {
            if(this.WebDav_textBox.Text != "" && this.Account_textBox.Text != "" && this.Pwd_textBox.Text != "")
            {
                string WebDav = this.WebDav_textBox.Text;
                string email = this.Account_textBox.Text;
                string pwd = this.Pwd_textBox.Text;

                if (File.Exists("cfg.zip"))
                {
                    File.Delete("cfg.zip");
                }

                WebClient client = new WebClient();
                client.Credentials = new NetworkCredential(email, pwd);
                try
                {
                    client.DownloadFile(WebDav, "cfg.zip");
                    this.WebDav_textBox.Enabled = false;
                    this.Account_textBox.Enabled = false;
                    this.Pwd_textBox.Enabled = false;
                }
                catch (WebException)
                {
                    MessageBox.Show("下载测试失败！\n请检测您的配置项！");
                }

                if (File.Exists("cfg.zip"))
                {
                    MessageBox.Show("下载测试成功！\n点击 保存配置 即可上传配置到服务器！");
                    this.Save_Btn.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("WebDav下载配置请勿留空！");
            }
        }

        async private void Save_Btn_Click(object sender, EventArgs e)
        {
            var CFGData = new Dictionary<string, string>
            {
                { "WebDav", this.WebDav_textBox.Text },
                { "Email", this.Account_textBox.Text },
                { "Password", this.Pwd_textBox.Text }
            };

            var response = await client.PostAsync("http://127.0.0.1:5888/login", new FormUrlEncodedContent(CFGData));
            var responseString = await response.Content.ReadAsStringAsync();

            if(responseString == "success")
            {
                MessageBox.Show("配置上传成功！");
                this.Close();
            }
            else
            {
                MessageBox.Show("配置上传失败！");
            }
        }
    }
}
