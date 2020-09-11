namespace PizzaCommend
{
    partial class IngredientForm
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
            this.cmdValidate = new System.Windows.Forms.Button();
            this.grbTaille = new System.Windows.Forms.GroupBox();
            this.rdbFamiliale = new System.Windows.Forms.RadioButton();
            this.rdbGrande = new System.Windows.Forms.RadioButton();
            this.rdbNormal = new System.Windows.Forms.RadioButton();
            this.rdbPetite = new System.Windows.Forms.RadioButton();
            this.grbGarniture = new System.Windows.Forms.GroupBox();
            this.chkJambon = new System.Windows.Forms.CheckBox();
            this.chkChorizo = new System.Windows.Forms.CheckBox();
            this.chkPoivron = new System.Windows.Forms.CheckBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grbTaille.SuspendLayout();
            this.grbGarniture.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdValidate
            // 
            this.cmdValidate.Location = new System.Drawing.Point(136, 422);
            this.cmdValidate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdValidate.Name = "cmdValidate";
            this.cmdValidate.Size = new System.Drawing.Size(338, 72);
            this.cmdValidate.TabIndex = 0;
            this.cmdValidate.Text = "Valider";
            this.cmdValidate.UseVisualStyleBackColor = true;
            this.cmdValidate.Click += new System.EventHandler(this.cmdValidate_Click);
            // 
            // grbTaille
            // 
            this.grbTaille.Controls.Add(this.rdbFamiliale);
            this.grbTaille.Controls.Add(this.rdbGrande);
            this.grbTaille.Controls.Add(this.rdbNormal);
            this.grbTaille.Controls.Add(this.rdbPetite);
            this.grbTaille.Location = new System.Drawing.Point(102, 103);
            this.grbTaille.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbTaille.Name = "grbTaille";
            this.grbTaille.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbTaille.Size = new System.Drawing.Size(171, 263);
            this.grbTaille.TabIndex = 1;
            this.grbTaille.TabStop = false;
            this.grbTaille.Text = "Taille";
            // 
            // rdbFamiliale
            // 
            this.rdbFamiliale.AutoSize = true;
            this.rdbFamiliale.Location = new System.Drawing.Point(10, 200);
            this.rdbFamiliale.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbFamiliale.Name = "rdbFamiliale";
            this.rdbFamiliale.Size = new System.Drawing.Size(99, 24);
            this.rdbFamiliale.TabIndex = 3;
            this.rdbFamiliale.TabStop = true;
            this.rdbFamiliale.Text = "Familliale";
            this.rdbFamiliale.UseVisualStyleBackColor = true;
            this.rdbFamiliale.CheckedChanged += new System.EventHandler(this.rdbFamiliale_CheckedChanged);
            // 
            // rdbGrande
            // 
            this.rdbGrande.AutoSize = true;
            this.rdbGrande.Location = new System.Drawing.Point(10, 140);
            this.rdbGrande.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbGrande.Name = "rdbGrande";
            this.rdbGrande.Size = new System.Drawing.Size(88, 24);
            this.rdbGrande.TabIndex = 2;
            this.rdbGrande.TabStop = true;
            this.rdbGrande.Text = "Grande";
            this.rdbGrande.UseVisualStyleBackColor = true;
            this.rdbGrande.CheckedChanged += new System.EventHandler(this.rdbGrande_CheckedChanged);
            // 
            // rdbNormal
            // 
            this.rdbNormal.AutoSize = true;
            this.rdbNormal.Checked = true;
            this.rdbNormal.Location = new System.Drawing.Point(10, 105);
            this.rdbNormal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbNormal.Name = "rdbNormal";
            this.rdbNormal.Size = new System.Drawing.Size(84, 24);
            this.rdbNormal.TabIndex = 1;
            this.rdbNormal.TabStop = true;
            this.rdbNormal.Text = "Normal";
            this.rdbNormal.UseVisualStyleBackColor = true;
            this.rdbNormal.CheckedChanged += new System.EventHandler(this.rdbNormal_CheckedChanged);
            // 
            // rdbPetite
            // 
            this.rdbPetite.AutoSize = true;
            this.rdbPetite.Location = new System.Drawing.Point(10, 54);
            this.rdbPetite.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbPetite.Name = "rdbPetite";
            this.rdbPetite.Size = new System.Drawing.Size(75, 24);
            this.rdbPetite.TabIndex = 0;
            this.rdbPetite.TabStop = true;
            this.rdbPetite.Text = "Petite";
            this.rdbPetite.UseVisualStyleBackColor = true;
            this.rdbPetite.CheckedChanged += new System.EventHandler(this.rdbPetite_CheckedChanged);
            // 
            // grbGarniture
            // 
            this.grbGarniture.Controls.Add(this.chkJambon);
            this.grbGarniture.Controls.Add(this.chkChorizo);
            this.grbGarniture.Controls.Add(this.chkPoivron);
            this.grbGarniture.Location = new System.Drawing.Point(324, 103);
            this.grbGarniture.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbGarniture.Name = "grbGarniture";
            this.grbGarniture.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbGarniture.Size = new System.Drawing.Size(190, 263);
            this.grbGarniture.TabIndex = 2;
            this.grbGarniture.TabStop = false;
            this.grbGarniture.Text = "Garniture";
            // 
            // chkJambon
            // 
            this.chkJambon.AutoSize = true;
            this.chkJambon.Location = new System.Drawing.Point(9, 54);
            this.chkJambon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkJambon.Name = "chkJambon";
            this.chkJambon.Size = new System.Drawing.Size(92, 24);
            this.chkJambon.TabIndex = 0;
            this.chkJambon.Text = "Jambon";
            this.chkJambon.UseVisualStyleBackColor = true;
            // 
            // chkChorizo
            // 
            this.chkChorizo.AutoSize = true;
            this.chkChorizo.Location = new System.Drawing.Point(9, 126);
            this.chkChorizo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkChorizo.Name = "chkChorizo";
            this.chkChorizo.Size = new System.Drawing.Size(89, 24);
            this.chkChorizo.TabIndex = 1;
            this.chkChorizo.Text = "Chorizo";
            this.chkChorizo.UseVisualStyleBackColor = true;
            // 
            // chkPoivron
            // 
            this.chkPoivron.AutoSize = true;
            this.chkPoivron.Location = new System.Drawing.Point(10, 200);
            this.chkPoivron.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkPoivron.Name = "chkPoivron";
            this.chkPoivron.Size = new System.Drawing.Size(87, 24);
            this.chkPoivron.TabIndex = 2;
            this.chkPoivron.Text = "Poivron";
            this.chkPoivron.UseVisualStyleBackColor = true;
            // 
            // IngredientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 545);
            this.Controls.Add(this.grbGarniture);
            this.Controls.Add(this.grbTaille);
            this.Controls.Add(this.cmdValidate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "IngredientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Composition Pizza";
            this.grbTaille.ResumeLayout(false);
            this.grbTaille.PerformLayout();
            this.grbGarniture.ResumeLayout(false);
            this.grbGarniture.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdValidate;
        private System.Windows.Forms.GroupBox grbTaille;
        private System.Windows.Forms.RadioButton rdbFamiliale;
        private System.Windows.Forms.RadioButton rdbGrande;
        private System.Windows.Forms.RadioButton rdbNormal;
        private System.Windows.Forms.RadioButton rdbPetite;
        private System.Windows.Forms.GroupBox grbGarniture;
        private System.Windows.Forms.CheckBox chkJambon;
        private System.Windows.Forms.CheckBox chkChorizo;
        private System.Windows.Forms.CheckBox chkPoivron;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}