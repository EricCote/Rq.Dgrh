﻿namespace Rq.Dgrh
{
    partial class frmEmployes
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
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtEmbauche = new System.Windows.Forms.TextBox();
            this.txtSalaire = new System.Windows.Forms.TextBox();
            this.lstEmployes = new System.Windows.Forms.ListBox();
            this.btnAjoutEmploye = new System.Windows.Forms.Button();
            this.btnAjouterEmployes = new System.Windows.Forms.Button();
            this.btnMasseSalariale = new System.Windows.Forms.Button();
            this.btnBienPaye = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(52, 46);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 0;
            this.txtNom.Text = "Emp";
            // 
            // txtEmbauche
            // 
            this.txtEmbauche.Location = new System.Drawing.Point(52, 72);
            this.txtEmbauche.Name = "txtEmbauche";
            this.txtEmbauche.Size = new System.Drawing.Size(100, 20);
            this.txtEmbauche.TabIndex = 1;
            this.txtEmbauche.Text = "2012/01/01";
            // 
            // txtSalaire
            // 
            this.txtSalaire.Location = new System.Drawing.Point(52, 98);
            this.txtSalaire.Name = "txtSalaire";
            this.txtSalaire.Size = new System.Drawing.Size(100, 20);
            this.txtSalaire.TabIndex = 2;
            this.txtSalaire.Text = "25000";
            // 
            // lstEmployes
            // 
            this.lstEmployes.FormattingEnabled = true;
            this.lstEmployes.Location = new System.Drawing.Point(183, 46);
            this.lstEmployes.Name = "lstEmployes";
            this.lstEmployes.Size = new System.Drawing.Size(152, 173);
            this.lstEmployes.TabIndex = 3;
            this.lstEmployes.DoubleClick += new System.EventHandler(this.lstEmployes_DoubleClick);
            // 
            // btnAjoutEmploye
            // 
            this.btnAjoutEmploye.Location = new System.Drawing.Point(52, 147);
            this.btnAjoutEmploye.Name = "btnAjoutEmploye";
            this.btnAjoutEmploye.Size = new System.Drawing.Size(100, 23);
            this.btnAjoutEmploye.TabIndex = 4;
            this.btnAjoutEmploye.Text = "Ajouter Employe";
            this.btnAjoutEmploye.UseVisualStyleBackColor = true;
            this.btnAjoutEmploye.Click += new System.EventHandler(this.btnAjoutEmploye_Click);
            // 
            // btnAjouterEmployes
            // 
            this.btnAjouterEmployes.Location = new System.Drawing.Point(52, 177);
            this.btnAjouterEmployes.Name = "btnAjouterEmployes";
            this.btnAjouterEmployes.Size = new System.Drawing.Size(100, 25);
            this.btnAjouterEmployes.TabIndex = 5;
            this.btnAjouterEmployes.Text = "Ajouter Employes";
            this.btnAjouterEmployes.UseVisualStyleBackColor = true;
            this.btnAjouterEmployes.Click += new System.EventHandler(this.btnAjouterEmployes_Click);
            // 
            // btnMasseSalariale
            // 
            this.btnMasseSalariale.Location = new System.Drawing.Point(183, 226);
            this.btnMasseSalariale.Name = "btnMasseSalariale";
            this.btnMasseSalariale.Size = new System.Drawing.Size(75, 23);
            this.btnMasseSalariale.TabIndex = 6;
            this.btnMasseSalariale.Text = "Calculer Masse Salariale";
            this.btnMasseSalariale.UseVisualStyleBackColor = true;
            this.btnMasseSalariale.Click += new System.EventHandler(this.btnMasseSalariale_Click);
            // 
            // btnBienPaye
            // 
            this.btnBienPaye.Location = new System.Drawing.Point(264, 225);
            this.btnBienPaye.Name = "btnBienPaye";
            this.btnBienPaye.Size = new System.Drawing.Size(75, 23);
            this.btnBienPaye.TabIndex = 7;
            this.btnBienPaye.Text = "Bien payé";
            this.btnBienPaye.UseVisualStyleBackColor = true;
            this.btnBienPaye.Click += new System.EventHandler(this.btnBienPaye_Click);
            // 
            // frmEmployes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 261);
            this.Controls.Add(this.btnBienPaye);
            this.Controls.Add(this.btnMasseSalariale);
            this.Controls.Add(this.btnAjouterEmployes);
            this.Controls.Add(this.btnAjoutEmploye);
            this.Controls.Add(this.lstEmployes);
            this.Controls.Add(this.txtSalaire);
            this.Controls.Add(this.txtEmbauche);
            this.Controls.Add(this.txtNom);
            this.Name = "frmEmployes";
            this.Text = "Employes";
            this.Load += new System.EventHandler(this.frmEmployes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtEmbauche;
        private System.Windows.Forms.TextBox txtSalaire;
        private System.Windows.Forms.ListBox lstEmployes;
        private System.Windows.Forms.Button btnAjoutEmploye;
        private System.Windows.Forms.Button btnAjouterEmployes;
        private System.Windows.Forms.Button btnMasseSalariale;
        private System.Windows.Forms.Button btnBienPaye;
    }
}