
namespace CSGO_cfg
{
    partial class WebDav
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WebDav));
            this.WebDav_label = new System.Windows.Forms.Label();
            this.Account_label = new System.Windows.Forms.Label();
            this.Pwd_label = new System.Windows.Forms.Label();
            this.WebDav_textBox = new System.Windows.Forms.TextBox();
            this.Account_textBox = new System.Windows.Forms.TextBox();
            this.Pwd_textBox = new System.Windows.Forms.TextBox();
            this.Test_Btn = new System.Windows.Forms.Button();
            this.Save_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WebDav_label
            // 
            this.WebDav_label.AutoSize = true;
            this.WebDav_label.Location = new System.Drawing.Point(3, 4);
            this.WebDav_label.Name = "WebDav_label";
            this.WebDav_label.Size = new System.Drawing.Size(63, 15);
            this.WebDav_label.TabIndex = 0;
            this.WebDav_label.Text = "WebDav:";
            // 
            // Account_label
            // 
            this.Account_label.AutoSize = true;
            this.Account_label.Location = new System.Drawing.Point(3, 35);
            this.Account_label.Name = "Account_label";
            this.Account_label.Size = new System.Drawing.Size(45, 15);
            this.Account_label.TabIndex = 1;
            this.Account_label.Text = "账号:";
            // 
            // Pwd_label
            // 
            this.Pwd_label.AutoSize = true;
            this.Pwd_label.Location = new System.Drawing.Point(3, 66);
            this.Pwd_label.Name = "Pwd_label";
            this.Pwd_label.Size = new System.Drawing.Size(45, 15);
            this.Pwd_label.TabIndex = 2;
            this.Pwd_label.Text = "秘钥:";
            // 
            // WebDav_textBox
            // 
            this.WebDav_textBox.Location = new System.Drawing.Point(60, 1);
            this.WebDav_textBox.Name = "WebDav_textBox";
            this.WebDav_textBox.Size = new System.Drawing.Size(189, 25);
            this.WebDav_textBox.TabIndex = 3;
            // 
            // Account_textBox
            // 
            this.Account_textBox.Location = new System.Drawing.Point(45, 32);
            this.Account_textBox.Name = "Account_textBox";
            this.Account_textBox.Size = new System.Drawing.Size(204, 25);
            this.Account_textBox.TabIndex = 4;
            // 
            // Pwd_textBox
            // 
            this.Pwd_textBox.Location = new System.Drawing.Point(45, 63);
            this.Pwd_textBox.Name = "Pwd_textBox";
            this.Pwd_textBox.Size = new System.Drawing.Size(204, 25);
            this.Pwd_textBox.TabIndex = 5;
            // 
            // Test_Btn
            // 
            this.Test_Btn.Location = new System.Drawing.Point(6, 91);
            this.Test_Btn.Name = "Test_Btn";
            this.Test_Btn.Size = new System.Drawing.Size(117, 26);
            this.Test_Btn.TabIndex = 6;
            this.Test_Btn.Text = "下载测试";
            this.Test_Btn.UseVisualStyleBackColor = true;
            this.Test_Btn.Click += new System.EventHandler(this.Test_Btn_Click);
            // 
            // Save_Btn
            // 
            this.Save_Btn.Enabled = false;
            this.Save_Btn.Location = new System.Drawing.Point(132, 91);
            this.Save_Btn.Name = "Save_Btn";
            this.Save_Btn.Size = new System.Drawing.Size(117, 26);
            this.Save_Btn.TabIndex = 7;
            this.Save_Btn.Text = "保存配置";
            this.Save_Btn.UseVisualStyleBackColor = true;
            this.Save_Btn.Click += new System.EventHandler(this.Save_Btn_Click);
            // 
            // WebDav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 118);
            this.Controls.Add(this.Save_Btn);
            this.Controls.Add(this.Test_Btn);
            this.Controls.Add(this.Pwd_textBox);
            this.Controls.Add(this.Account_textBox);
            this.Controls.Add(this.WebDav_textBox);
            this.Controls.Add(this.Pwd_label);
            this.Controls.Add(this.Account_label);
            this.Controls.Add(this.WebDav_label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(270, 165);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(270, 165);
            this.Name = "WebDav";
            this.Text = "WebDav";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WebDav_label;
        private System.Windows.Forms.Label Account_label;
        private System.Windows.Forms.Label Pwd_label;
        private System.Windows.Forms.TextBox WebDav_textBox;
        private System.Windows.Forms.TextBox Account_textBox;
        private System.Windows.Forms.TextBox Pwd_textBox;
        private System.Windows.Forms.Button Test_Btn;
        private System.Windows.Forms.Button Save_Btn;
    }
}