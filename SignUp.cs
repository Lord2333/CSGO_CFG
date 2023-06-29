using System;
using System.Windows.Forms;
using System.Net.Http;
using System.Threading;
using System.Text.RegularExpressions;
using Timer = System.Threading.Timer;
using CSGO_cfg;

namespace CSGO_cfg
{
    public partial class SignUp : Form
    {
        private const int COUNTDOWN_SECONDS = 30;
        private const string COUNTDOWN_BUTTON_TEXT = "{0}s";

        private int countdownSeconds;
        private Timer countdownTimer;
        private HttpClient client;

        public SignUp(HttpClient Client)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            countdownSeconds = COUNTDOWN_SECONDS;
            countdownTimer = new Timer(CountdownTimerCallback, null, Timeout.Infinite, Timeout.Infinite);
            client = Client;
        }

        private void CountdownTimerCallback(object state)  // 验证码冷却
        {
            countdownSeconds--;

            if (countdownSeconds == 0)
            {
                countdownTimer.Change(Timeout.Infinite, Timeout.Infinite); // 停止倒计时
                countdownSeconds = COUNTDOWN_SECONDS;

                // 在UI线程上更新按钮状态和文字
                Invoke((Action)(() =>
                {
                    this.Ver_Btn.Enabled = true;
                    this.Ver_Btn.Text = "验证";
                }));
            }
            else
            {
                // 在UI线程上更新按钮文字
                Invoke((Action)(() =>
                {
                    this.Ver_Btn.Text = string.Format(COUNTDOWN_BUTTON_TEXT, countdownSeconds);
                }));
            }
        }

        private bool IsValidEmail(string input)  // 邮箱判断
        {
            // 邮箱地址的正则表达式
            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";

            // 使用正则表达式进行匹配
            Match match = Regex.Match(input, pattern);

            // 判断匹配结果
            return match.Success;
        }

        async private void Ver_Btn_Click(object sender, EventArgs e)  // 获取验证码
        {
            this.Ver_Btn.Enabled = false;
            this.Email_textBox.Enabled = false;  // 防止傻逼收了验证码再换别的邮箱
            this.SignUp_Btn.Enabled = true;  // 使能注册按钮，免得傻逼乱按
            countdownTimer.Change(0, 1000); // 开始倒计时
            if(this.IsValidEmail(this.Email_textBox.Text))
            {
                var EmailData = new System.Collections.Generic.Dictionary<string, string>
                {
                    { "account", this.Email_textBox.Text },
                };
                var response = await client.PostAsync("http://127.0.0.1:5888/email", new FormUrlEncodedContent(EmailData));
                var responseString = await response.Content.ReadAsStringAsync();

                // 判断邮件是否发送成功
                if (responseString == "success")
                {
                    MessageBox.Show("邮件发送成功！", "成功", MessageBoxButtons.OK);
                }
                else if (responseString == "error")
                {
                    if (MessageBox.Show("该邮箱已注册！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning)== DialogResult.Yes)
                    {
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("收件邮箱有误或无法连接至注册服务器！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("您输入的邮箱格式似乎不正确哦~");
            }
        }

        async private void SignUp_Btn_Click(object sender, EventArgs e)
        {
            if(this.Pwd_textBox.TextLength < 6)
            {
                MessageBox.Show("密码需大于六位！");
            }
            else if (this.Ver_textBox.TextLength != 6)
            {
                MessageBox.Show("验证码是一个六位字符串！");
            }
            else
            {
                var SignUpData = new System.Collections.Generic.Dictionary<string, string>
                {
                    { "account", this.Email_textBox.Text },
                    { "code", this.Ver_textBox.Text },
                    { "pwd", this.Pwd_textBox.Text }
                };
                var response = await client.PostAsync("http://127.0.0.1:5888/register", new FormUrlEncodedContent(SignUpData));
                var responseString = await response.Content.ReadAsStringAsync();

                if (responseString == "success")
                {
                    MessageBox.Show("注册成功！\n点击前往配置界面~");
                    this.Close();
                    countdownSeconds = 1;
                    Form WebDav = new WebDav(client);
                    WebDav.Show(); // 显示配置界面
                }
                else
                {
                    MessageBox.Show("注册失败或注册服务器失联！");
                    this.Close();
                }
            }
        }
    }
}
