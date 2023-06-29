
namespace CSGO_cfg
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Acc_label = new System.Windows.Forms.Label();
            this.Pwd_label = new System.Windows.Forms.Label();
            this.Login_Btn = new System.Windows.Forms.Button();
            this.SignUp_Btn = new System.Windows.Forms.Button();
            this.Acc_textBox = new System.Windows.Forms.TextBox();
            this.Pwd_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Acc_label
            // 
            this.Acc_label.AutoSize = true;
            this.Acc_label.Location = new System.Drawing.Point(3, 15);
            this.Acc_label.Name = "Acc_label";
            this.Acc_label.Size = new System.Drawing.Size(45, 15);
            this.Acc_label.TabIndex = 0;
            this.Acc_label.Text = "账号:";
            // 
            // Pwd_label
            // 
            this.Pwd_label.AutoSize = true;
            this.Pwd_label.Location = new System.Drawing.Point(3, 49);
            this.Pwd_label.Name = "Pwd_label";
            this.Pwd_label.Size = new System.Drawing.Size(45, 15);
            this.Pwd_label.TabIndex = 1;
            this.Pwd_label.Text = "密码:";
            // 
            // Login_Btn
            // 
            this.Login_Btn.Location = new System.Drawing.Point(169, 10);
            this.Login_Btn.Name = "Login_Btn";
            this.Login_Btn.Size = new System.Drawing.Size(75, 25);
            this.Login_Btn.TabIndex = 2;
            this.Login_Btn.Text = "登录";
            this.Login_Btn.UseVisualStyleBackColor = true;
            this.Login_Btn.Click += new System.EventHandler(this.Login_Btn_Click);
            // 
            // SignUp_Btn
            // 
            this.SignUp_Btn.Location = new System.Drawing.Point(169, 41);
            this.SignUp_Btn.Name = "SignUp_Btn";
            this.SignUp_Btn.Size = new System.Drawing.Size(75, 27);
            this.SignUp_Btn.TabIndex = 3;
            this.SignUp_Btn.Text = "注册";
            this.SignUp_Btn.UseVisualStyleBackColor = true;
            this.SignUp_Btn.Click += new System.EventHandler(this.SignUp_Btn_Click);
            // 
            // Acc_textBox
            // 
            this.Acc_textBox.Location = new System.Drawing.Point(44, 10);
            this.Acc_textBox.Name = "Acc_textBox";
            this.Acc_textBox.Size = new System.Drawing.Size(119, 25);
            this.Acc_textBox.TabIndex = 4;
            // 
            // Pwd_textBox
            // 
            this.Pwd_textBox.Location = new System.Drawing.Point(44, 41);
            this.Pwd_textBox.Name = "Pwd_textBox";
            this.Pwd_textBox.Size = new System.Drawing.Size(119, 25);
            this.Pwd_textBox.TabIndex = 5;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 73);
            this.Controls.Add(this.Pwd_textBox);
            this.Controls.Add(this.Acc_textBox);
            this.Controls.Add(this.SignUp_Btn);
            this.Controls.Add(this.Login_Btn);
            this.Controls.Add(this.Pwd_label);
            this.Controls.Add(this.Acc_label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(265, 120);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(265, 120);
            this.Name = "Form2";
            this.Text = "远程下载";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Acc_label;
        private System.Windows.Forms.Label Pwd_label;
        private System.Windows.Forms.Button Login_Btn;
        private System.Windows.Forms.Button SignUp_Btn;
        private System.Windows.Forms.TextBox Acc_textBox;
        private System.Windows.Forms.TextBox Pwd_textBox;
    }
}