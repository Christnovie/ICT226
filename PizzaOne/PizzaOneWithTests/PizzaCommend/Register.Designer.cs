namespace PizzaCommend
{
    partial class Register
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
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_pwd = new System.Windows.Forms.TextBox();
            this.txt_confirmPwd = new System.Windows.Forms.TextBox();
            this.cmd_submit = new System.Windows.Forms.Button();
            this.cmd_cancel = new System.Windows.Forms.Button();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_pwd = new System.Windows.Forms.Label();
            this.lbl_confirmPwd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(387, 245);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(298, 26);
            this.txt_name.TabIndex = 0;
            // 
            // txt_pwd
            // 
            this.txt_pwd.Location = new System.Drawing.Point(387, 324);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.Size = new System.Drawing.Size(298, 26);
            this.txt_pwd.TabIndex = 1;
            // 
            // txt_confirmPwd
            // 
            this.txt_confirmPwd.Location = new System.Drawing.Point(387, 408);
            this.txt_confirmPwd.Name = "txt_confirmPwd";
            this.txt_confirmPwd.Size = new System.Drawing.Size(298, 26);
            this.txt_confirmPwd.TabIndex = 2;
            // 
            // cmd_submit
            // 
            this.cmd_submit.Location = new System.Drawing.Point(387, 492);
            this.cmd_submit.Name = "cmd_submit";
            this.cmd_submit.Size = new System.Drawing.Size(135, 45);
            this.cmd_submit.TabIndex = 3;
            this.cmd_submit.Text = "registry";
            this.cmd_submit.UseVisualStyleBackColor = true;
            this.cmd_submit.Click += new System.EventHandler(this.cmd_submit_Click);
            // 
            // cmd_cancel
            // 
            this.cmd_cancel.Location = new System.Drawing.Point(550, 492);
            this.cmd_cancel.Name = "cmd_cancel";
            this.cmd_cancel.Size = new System.Drawing.Size(135, 45);
            this.cmd_cancel.TabIndex = 4;
            this.cmd_cancel.Text = "Cancel";
            this.cmd_cancel.UseVisualStyleBackColor = true;
            this.cmd_cancel.Click += new System.EventHandler(this.cmd_cancel_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(387, 198);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(51, 20);
            this.lbl_name.TabIndex = 5;
            this.lbl_name.Text = "Name";
            // 
            // lbl_pwd
            // 
            this.lbl_pwd.AutoSize = true;
            this.lbl_pwd.Location = new System.Drawing.Point(383, 287);
            this.lbl_pwd.Name = "lbl_pwd";
            this.lbl_pwd.Size = new System.Drawing.Size(78, 20);
            this.lbl_pwd.TabIndex = 6;
            this.lbl_pwd.Text = "Password";
            // 
            // lbl_confirmPwd
            // 
            this.lbl_confirmPwd.AutoSize = true;
            this.lbl_confirmPwd.Location = new System.Drawing.Point(387, 376);
            this.lbl_confirmPwd.Name = "lbl_confirmPwd";
            this.lbl_confirmPwd.Size = new System.Drawing.Size(145, 20);
            this.lbl_confirmPwd.TabIndex = 7;
            this.lbl_confirmPwd.Text = "Confirme password";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 692);
            this.Controls.Add(this.lbl_confirmPwd);
            this.Controls.Add(this.lbl_pwd);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.cmd_cancel);
            this.Controls.Add(this.cmd_submit);
            this.Controls.Add(this.txt_confirmPwd);
            this.Controls.Add(this.txt_pwd);
            this.Controls.Add(this.txt_name);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_pwd;
        private System.Windows.Forms.TextBox txt_confirmPwd;
        private System.Windows.Forms.Button cmd_submit;
        private System.Windows.Forms.Button cmd_cancel;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_pwd;
        private System.Windows.Forms.Label lbl_confirmPwd;
    }
}