namespace PizzaCommend
{
    partial class wnd_Login2
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
            this.cmd_login = new System.Windows.Forms.Button();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.cmd_register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmd_login
            // 
            this.cmd_login.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cmd_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_login.Location = new System.Drawing.Point(199, 304);
            this.cmd_login.Name = "cmd_login";
            this.cmd_login.Size = new System.Drawing.Size(75, 23);
            this.cmd_login.TabIndex = 0;
            this.cmd_login.Text = "Submit";
            this.cmd_login.UseVisualStyleBackColor = false;
            this.cmd_login.Click += new System.EventHandler(this.cmd_login_Click);
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(185, 231);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(100, 20);
            this.txt_password.TabIndex = 1;
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(185, 151);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 20);
            this.txt_name.TabIndex = 2;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(182, 125);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(53, 13);
            this.lbl_name.TabIndex = 3;
            this.lbl_name.Text = "Password";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(182, 195);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(53, 13);
            this.lbl_password.TabIndex = 4;
            this.lbl_password.Text = "Password";
            // 
            // cmd_register
            // 
            this.cmd_register.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cmd_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_register.Location = new System.Drawing.Point(301, 304);
            this.cmd_register.Name = "cmd_register";
            this.cmd_register.Size = new System.Drawing.Size(75, 23);
            this.cmd_register.TabIndex = 5;
            this.cmd_register.Text = "Register";
            this.cmd_register.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.cmd_register.UseVisualStyleBackColor = false;
            this.cmd_register.Click += new System.EventHandler(this.cmd_register_Click);
            // 
            // wnd_Login2
            // 
            this.AcceptButton = this.cmd_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(571, 450);
            this.Controls.Add(this.cmd_register);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.cmd_login);
            this.Name = "wnd_Login2";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_login;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Button cmd_register;
    }
}