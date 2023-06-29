
namespace CSGO_cfg
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.account_label = new System.Windows.Forms.Label();
            this.Email_textBox = new System.Windows.Forms.TextBox();
            this.Ver_label = new System.Windows.Forms.Label();
            this.Ver_textBox = new System.Windows.Forms.TextBox();
            this.Ver_Btn = new System.Windows.Forms.Button();
            this.Pwd_label = new System.Windows.Forms.Label();
            this.Pwd_textBox = new System.Windows.Forms.TextBox();
            this.SignUp_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // account_label
            // 
            this.account_label.AutoSize = true;
            this.account_label.Location = new System.Drawing.Point(2, 9);
            this.account_label.Name = "account_label";
            this.account_label.Size = new System.Drawing.Size(45, 15);
            this.account_label.TabIndex = 0;
            this.account_label.Text = "邮箱:";
            // 
            // Email_textBox
            // 
            this.Email_textBox.Location = new System.Drawing.Point(45, 6);
            this.Email_textBox.Name = "Email_textBox";
            this.Email_textBox.Size = new System.Drawing.Size(158, 25);
            this.Email_textBox.TabIndex = 1;
            // 
            // Ver_label
            // 
            this.Ver_label.AutoSize = true;
            this.Ver_label.Location = new System.Drawing.Point(2, 40);
            this.Ver_label.Name = "Ver_label";
            this.Ver_label.Size = new System.Drawing.Size(60, 15);
            this.Ver_label.TabIndex = 2;
            this.Ver_label.Text = "验证码:";
            // 
            // Ver_textBox
            // 
            this.Ver_textBox.Location = new System.Drawing.Point(58, 37);
            this.Ver_textBox.Name = "Ver_textBox";
            this.Ver_textBox.Size = new System.Drawing.Size(87, 25);
            this.Ver_textBox.TabIndex = 3;
            // 
            // Ver_Btn
            // 
            this.Ver_Btn.Location = new System.Drawing.Point(151, 37);
            this.Ver_Btn.Name = "Ver_Btn";
            this.Ver_Btn.Size = new System.Drawing.Size(52, 25);
            this.Ver_Btn.TabIndex = 4;
            this.Ver_Btn.Text = "验证";
            this.Ver_Btn.UseVisualStyleBackColor = true;
            this.Ver_Btn.Click += new System.EventHandler(this.Ver_Btn_Click);
            // 
            // Pwd_label
            // 
            this.Pwd_label.AutoSize = true;
            this.Pwd_label.Location = new System.Drawing.Point(2, 71);
            this.Pwd_label.Name = "Pwd_label";
            this.Pwd_label.Size = new System.Drawing.Size(45, 15);
            this.Pwd_label.TabIndex = 5;
            this.Pwd_label.Text = "密码:";
            // 
            // Pwd_textBox
            // 
            this.Pwd_textBox.Location = new System.Drawing.Point(45, 68);
            this.Pwd_textBox.Name = "Pwd_textBox";
            this.Pwd_textBox.Size = new System.Drawing.Size(158, 25);
            this.Pwd_textBox.TabIndex = 6;
            // 
            // SignUp_Btn
            // 
            this.SignUp_Btn.Enabled = false;
            this.SignUp_Btn.Location = new System.Drawing.Point(209, 6);
            this.SignUp_Btn.Name = "SignUp_Btn";
            this.SignUp_Btn.Size = new System.Drawing.Size(41, 87);
            this.SignUp_Btn.TabIndex = 7;
            this.SignUp_Btn.Text = "注册";
            this.SignUp_Btn.UseVisualStyleBackColor = true;
            this.SignUp_Btn.Click += new System.EventHandler(this.SignUp_Btn_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 98);
            this.Controls.Add(this.SignUp_Btn);
            this.Controls.Add(this.Pwd_textBox);
            this.Controls.Add(this.Pwd_label);
            this.Controls.Add(this.Ver_Btn);
            this.Controls.Add(this.Ver_textBox);
            this.Controls.Add(this.Ver_label);
            this.Controls.Add(this.Email_textBox);
            this.Controls.Add(this.account_label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(270, 145);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(270, 145);
            this.Name = "SignUp";
            this.Text = "注册";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label account_label;
        private System.Windows.Forms.TextBox Email_textBox;
        private System.Windows.Forms.Label Ver_label;
        private System.Windows.Forms.TextBox Ver_textBox;
        private System.Windows.Forms.Button Ver_Btn;
        private System.Windows.Forms.Label Pwd_label;
        private System.Windows.Forms.TextBox Pwd_textBox;
        private System.Windows.Forms.Button SignUp_Btn;
    }
}