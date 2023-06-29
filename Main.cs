using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO.Compression;
using System.Drawing;
using System.IO;

namespace CSGO_cfg
{
    public partial class Main : Form
    {
        string steamDirectory;
        string[] CFGDir = {""};

        public Main()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public string[] UnzipFile()
        {
            string zipPath = @"cfg.zip";
            string extractPath = @".\";
            string[] subDirs = { "" };
            if (!File.Exists(zipPath))
            {
                if (MessageBox.Show("当前目录下找不到cfg.zip，点击 是 尝试在线下载，点击 否 打开程序所在目录。", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Login form2 = new Login();
                    form2.Show();
                }
                else
                {
                    Process.Start("explorer.exe", extractPath);
                }
            }
            else  // 检测到有压缩包才执行解压操作
            {
                string CFG = Path.Combine(Directory.GetCurrentDirectory(), "cfg");
                if (Directory.Exists(CFG)) {Directory.Delete(CFG, true); }
                try
                {
                    ZipFile.ExtractToDirectory(zipPath, extractPath);
                }
                catch (InvalidDataException)
                {
                    if (MessageBox.Show("检测到损坏的cfg.zip，点击 是 尝试在线下载，点击 否 打开程序所在目录。", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        Login form2 = new Login();
                        form2.Show();
                    }
                    else
                    {
                        Process.Start("explorer.exe", extractPath);
                    }
                    return subDirs;
                }
                subDirs = Directory.GetDirectories("cfg");
                MessageBox.Show("已解压配置文件！");
                subDirs = subDirs[0].Split(new[] { "\\" }, StringSplitOptions.None);
            }
            return subDirs;
        }

        public void CopyFile(string CFG_Path, string Local_Path, string Target)
        {
            string sourceFilePath = Path.Combine(CFG_Path, Target);
            string destinationFilePath = Path.Combine(Local_Path, Target);

            // 检测目标文件夹中是否存在同名文件，若存在则删除
            if (File.Exists(destinationFilePath))
            {
                File.Delete(destinationFilePath);
            }

            // 将源文件复制到目标文件夹
            File.Copy(sourceFilePath, destinationFilePath);
            string M = string.Format("已替换{0}！", Target);
            MessageBox.Show(M);
        }

        private void Init_Btn_Click(object sender, EventArgs e)
        {
            Process[] processes = Process.GetProcessesByName("Steam");
            
            if (processes.Length > 0)  // 检测到Steam进程后才检测是否有配置文件夹并进行下载解压
            {
                string steamPath = processes[0].MainModule.FileName;
                steamDirectory = Path.GetDirectoryName(steamPath);

                this.CFGDir_Linetext.ForeColor = Color.Blue;
                CFGDir = this.UnzipFile();  // 配置文件夹，返回数据形如 {"cfg", "123456"}
                if (CFGDir[0] != "")
                    steamDirectory = steamDirectory + "\\userdata\\" + CFGDir[1] + "\\730\\local\\cfg";  // 拼接配置文件地址
                else
                {
                    steamDirectory = "配置文件夹不存在！";
                    this.CFGDir_Linetext.ForeColor = Color.Red;
                }
            }
            else
            {
                steamDirectory = "Staem未启动！";
                this.CFGDir_Linetext.ForeColor = Color.Red;
                MessageBox.Show("请启动Steam并登录后，重新点击 初始化 按钮！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
            // CFGDir = this.UnzipFile(); // 配置文件夹
            this.CFGDir_Linetext.Text = steamDirectory;  // 讲道理只能同时运行一个Steam客户端
            this.CFGDir_Linetext.Refresh();
            if(this.CFGDir_Linetext.Text != "Staem未启动！" && this.CFGDir_Linetext.Text != "配置文件夹不存在！")  // 检测到Steam，且已解压配置文件夹后使能替换按钮。
            {
                this.CFG_Btn.Enabled = true;
                this.Vid_Btn.Enabled = true;
            }
        }

        private void help_linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://csgo.o1o.zip");  // 跳转到官网
        }

        private void CFG_Btn_Click(object sender, EventArgs e)
        {
            string type = "config.cfg";
            this.CopyFile(".\\cfg\\"+ CFGDir[1] + "\\730\\local\\cfg", steamDirectory, type);
        }

        private void Vid_Btn_Click(object sender, EventArgs e)
        {
            string type = "video.txt";
            this.CopyFile(".\\cfg\\" + CFGDir[1] + "\\730\\local\\cfg", steamDirectory, type);
        }
    }
}
