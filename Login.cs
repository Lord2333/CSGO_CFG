using System;
using System.Windows.Forms;
using System.Net.Http;
using System.Collections.Generic;
using System.Net;

namespace CSGO_cfg
{

    public partial class Login : Form
    {
        public HttpClient client;

        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;  // 在屏幕中央出现
            client = new HttpClient();
        }

        private void SignUp_Btn_Click(object sender, EventArgs e)
        {
            Form SignUp = new SignUp(client);
            SignUp.Show();
        }

        public void DownLoad(string url, string username, string password)  // 下载文件
        {
            string localPath = "cfg.zip"; //默认下载到根目录

            WebClient client = new WebClient();
            client.Credentials = new NetworkCredential(username, password);
            client.DownloadFile(url, localPath);
        }

        private async void Login_Btn_Click(object sender, EventArgs e)
        {
            // 验证账号和密码输入框不为空
            if (string.IsNullOrEmpty(this.Acc_textBox.Text) || string.IsNullOrEmpty(this.Pwd_textBox.Text))
            {
                MessageBox.Show("账号或密码不能为空！");
                return;
            }

            // 构造登录信息
            var loginData = new Dictionary<string, string>
            {
                { "account", this.Acc_textBox.Text },
                { "password", this.Pwd_textBox.Text }
            };

            // 发送POST请求
            // using (var client = new HttpClient())
            {
                var response = await client.PostAsync("http://127.0.0.1:5888/login", new FormUrlEncodedContent(loginData));
                string responseString = await response.Content.ReadAsStringAsync();

                // 判断登录是否成功
                if (responseString == "None")
                {
                    MessageBox.Show("未注册或密码错误！");
                }
                else if (responseString == "No CFG")
                { 
                    if(MessageBox.Show("当前账号无配置文件下载设置！\n点击 是 进行设置！","提示",  MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        Form WebDav = new WebDav(client);
                        WebDav.Show();  // 显示配置界面
                    }
                }
                else
                {
                    // 解析JSON数据
                    dynamic data = Newtonsoft.Json.JsonConvert.DeserializeObject(responseString);

                    // 获取email和pwd的值
                    string webDav = data.WebDav;
                    string email = data.Email;
                    string pwd = data.Password;
                    // 切片并分别输出
                    if (MessageBox.Show($"您在系统中预存的信息为：\nWebdav地址：{webDav}\n账号：{email}\n秘钥：{pwd}\n点击 是 继续下载，点击 否 进行修改。", "请确认！", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        this.DownLoad(webDav, email, pwd);
                        MessageBox.Show("不出意外的话配置文件已经下载完成了，重新点击 初始化 按钮读取配置文件夹即可。");
                        this.Close();
                    }
                    else
                    {
                        Form WebDav = new WebDav(client);
                        WebDav.Show();  // 显示配置界面
                    }
                }
            }
        }
    }
}
