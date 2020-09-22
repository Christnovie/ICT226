namespace PizzaCommend
{
    partial class wndPizzaCommend
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.cmdAddPizza = new System.Windows.Forms.Button();
            this.cmdTerminer = new System.Windows.Forms.Button();
            this.cmdAdress = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(167, 130);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(305, 26);
            this.txtName.TabIndex = 0;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(260, 61);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(119, 22);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Nom du client";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // cmdAddPizza
            // 
            this.cmdAddPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAddPizza.Location = new System.Drawing.Point(167, 201);
            this.cmdAddPizza.Name = "cmdAddPizza";
            this.cmdAddPizza.Size = new System.Drawing.Size(304, 50);
            this.cmdAddPizza.TabIndex = 2;
            this.cmdAddPizza.Text = "Ajouter une pizza";
            this.cmdAddPizza.UseVisualStyleBackColor = true;
            this.cmdAddPizza.Click += new System.EventHandler(this.cmdAddPizza_Click);
            // 
            // cmdTerminer
            // 
            this.cmdTerminer.BackColor = System.Drawing.Color.DodgerBlue;
            this.cmdTerminer.FlatAppearance.BorderSize = 0;
            this.cmdTerminer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdTerminer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdTerminer.Location = new System.Drawing.Point(331, 391);
            this.cmdTerminer.Name = "cmdTerminer";
            this.cmdTerminer.Size = new System.Drawing.Size(159, 52);
            this.cmdTerminer.TabIndex = 3;
            this.cmdTerminer.Text = "Terminer";
            this.cmdTerminer.UseVisualStyleBackColor = false;
            this.cmdTerminer.Click += new System.EventHandler(this.cmdTerminer_Click);
            // 
            // cmdAdress
            // 
            this.cmdAdress.BackColor = System.Drawing.Color.ForestGreen;
            this.cmdAdress.FlatAppearance.BorderSize = 0;
            this.cmdAdress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAdress.Location = new System.Drawing.Point(87, 391);
            this.cmdAdress.Name = "cmdAdress";
            this.cmdAdress.Size = new System.Drawing.Size(149, 52);
            this.cmdAdress.TabIndex = 4;
            this.cmdAdress.Text = "Connection\r\n";
            this.cmdAdress.UseVisualStyleBackColor = false;
            this.cmdAdress.Click += new System.EventHandler(this.cmdAdress_Click);
            // 
            // wndPizzaCommend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(600, 503);
            this.Controls.Add(this.cmdAdress);
            this.Controls.Add(this.cmdTerminer);
            this.Controls.Add(this.cmdAddPizza);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Name = "wndPizzaCommend";
            this.Text = "Command";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.wndPizzaCommend_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button cmdAddPizza;
        private System.Windows.Forms.Button cmdTerminer;
        private System.Windows.Forms.Button cmdAdress;
    }
}

