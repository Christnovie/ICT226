namespace PizzaCommend
{
    partial class Acceuil
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
            this.cmdConnection = new System.Windows.Forms.Button();
            this.cmdInscription = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdConnection
            // 
            this.cmdConnection.BackColor = System.Drawing.Color.LimeGreen;
            this.cmdConnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdConnection.Location = new System.Drawing.Point(309, 253);
            this.cmdConnection.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdConnection.Name = "cmdConnection";
            this.cmdConnection.Size = new System.Drawing.Size(314, 75);
            this.cmdConnection.TabIndex = 0;
            this.cmdConnection.Text = "Connection";
            this.cmdConnection.UseVisualStyleBackColor = false;
            this.cmdConnection.Click += new System.EventHandler(this.cmdConnection_Click);
            // 
            // cmdInscription
            // 
            this.cmdInscription.BackColor = System.Drawing.Color.Red;
            this.cmdInscription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdInscription.Location = new System.Drawing.Point(309, 360);
            this.cmdInscription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdInscription.Name = "cmdInscription";
            this.cmdInscription.Size = new System.Drawing.Size(314, 74);
            this.cmdInscription.TabIndex = 1;
            this.cmdInscription.Text = "Inscription";
            this.cmdInscription.UseVisualStyleBackColor = false;
            // 
            // Acceuil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(894, 477);
            this.Controls.Add(this.cmdInscription);
            this.Controls.Add(this.cmdConnection);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Acceuil";
            this.Text = "Pizza Commander";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdConnection;
        private System.Windows.Forms.Button cmdInscription;
    }
}