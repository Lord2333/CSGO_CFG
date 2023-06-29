
namespace CSGO_cfg
{
    partial class Main
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Usage_label = new System.Windows.Forms.Label();
            this.help_linkLabel = new System.Windows.Forms.LinkLabel();
            this.ConfigDir_label = new System.Windows.Forms.Label();
            this.CFGDir_Linetext = new System.Windows.Forms.TextBox();
            this.Init_Btn = new System.Windows.Forms.Button();
            this.CFG_Btn = new System.Windows.Forms.Button();
            this.Vid_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Usage_label
            // 
            this.Usage_label.AutoSize = true;
            this.Usage_label.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Usage_label.Location = new System.Drawing.Point(-1, 9);
            this.Usage_label.Name = "Usage_label";
            this.Usage_label.Size = new System.Drawing.Size(267, 100);
            this.Usage_label.TabIndex = 0;
            this.Usage_label.Text = "使用方法：在常用电脑找到Steam安装\r\n文件夹，找到userdata\\自己的id\\730\\\r\nlocal\\cfg文件夹，把里面的全部文件复\r\n制压缩到软件根目录" +
    "一并放置即可。\r\n\r\n";
            // 
            // help_linkLabel
            // 
            this.help_linkLabel.AutoSize = true;
            this.help_linkLabel.Location = new System.Drawing.Point(0, 94);
            this.help_linkLabel.Name = "help_linkLabel";
            this.help_linkLabel.Size = new System.Drawing.Size(242, 15);
            this.help_linkLabel.TabIndex = 1;
            this.help_linkLabel.TabStop = true;
            this.help_linkLabel.Text = "项目官网：https://csgo.o1o.zip";
            this.help_linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.help_linkLabel_LinkClicked);
            // 
            // ConfigDir_label
            // 
            this.ConfigDir_label.AutoSize = true;
            this.ConfigDir_label.Location = new System.Drawing.Point(0, 118);
            this.ConfigDir_label.Name = "ConfigDir_label";
            this.ConfigDir_label.Size = new System.Drawing.Size(100, 15);
            this.ConfigDir_label.TabIndex = 2;
            this.ConfigDir_label.Text = "Steam文件夹:";
            // 
            // CFGDir_Linetext
            // 
            this.CFGDir_Linetext.BackColor = System.Drawing.SystemColors.Control;
            this.CFGDir_Linetext.ForeColor = System.Drawing.SystemColors.InfoText;
            this.CFGDir_Linetext.Location = new System.Drawing.Point(96, 115);
            this.CFGDir_Linetext.Name = "CFGDir_Linetext";
            this.CFGDir_Linetext.ReadOnly = true;
            this.CFGDir_Linetext.Size = new System.Drawing.Size(286, 25);
            this.CFGDir_Linetext.TabIndex = 3;
            this.CFGDir_Linetext.Text = " ";
            // 
            // Init_Btn
            // 
            this.Init_Btn.Location = new System.Drawing.Point(286, 9);
            this.Init_Btn.Name = "Init_Btn";
            this.Init_Btn.Size = new System.Drawing.Size(96, 30);
            this.Init_Btn.TabIndex = 4;
            this.Init_Btn.Text = "初始化";
            this.Init_Btn.UseVisualStyleBackColor = true;
            this.Init_Btn.Click += new System.EventHandler(this.Init_Btn_Click);
            // 
            // CFG_Btn
            // 
            this.CFG_Btn.Enabled = false;
            this.CFG_Btn.Location = new System.Drawing.Point(286, 45);
            this.CFG_Btn.Name = "CFG_Btn";
            this.CFG_Btn.Size = new System.Drawing.Size(96, 30);
            this.CFG_Btn.TabIndex = 5;
            this.CFG_Btn.Text = "替换CFG";
            this.CFG_Btn.UseVisualStyleBackColor = true;
            this.CFG_Btn.Click += new System.EventHandler(this.CFG_Btn_Click);
            // 
            // Vid_Btn
            // 
            this.Vid_Btn.Enabled = false;
            this.Vid_Btn.Font = new System.Drawing.Font("宋体", 6.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Vid_Btn.Location = new System.Drawing.Point(286, 81);
            this.Vid_Btn.Name = "Vid_Btn";
            this.Vid_Btn.Size = new System.Drawing.Size(96, 30);
            this.Vid_Btn.TabIndex = 6;
            this.Vid_Btn.Text = "替换视频设置";
            this.Vid_Btn.UseVisualStyleBackColor = true;
            this.Vid_Btn.Click += new System.EventHandler(this.Vid_Btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 142);
            this.Controls.Add(this.Vid_Btn);
            this.Controls.Add(this.CFG_Btn);
            this.Controls.Add(this.Init_Btn);
            this.Controls.Add(this.CFGDir_Linetext);
            this.Controls.Add(this.ConfigDir_label);
            this.Controls.Add(this.help_linkLabel);
            this.Controls.Add(this.Usage_label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(404, 189);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(404, 189);
            this.Name = "Form1";
            this.Text = "CSGO配置替换工具";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Usage_label;
        private System.Windows.Forms.LinkLabel help_linkLabel;
        private System.Windows.Forms.Label ConfigDir_label;
        private System.Windows.Forms.TextBox CFGDir_Linetext;
        private System.Windows.Forms.Button Init_Btn;
        private System.Windows.Forms.Button CFG_Btn;
        private System.Windows.Forms.Button Vid_Btn;
    }
}

