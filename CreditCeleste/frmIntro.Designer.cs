namespace CreditCeleste
{
    partial class frmIntro
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
            this.cboCiv = new System.Windows.Forms.ComboBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.cboVendeur = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEnregistre = new System.Windows.Forms.Button();
            this.btnVoiture = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.lblVendeur = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnVoitureOccasion = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cboChoixC = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cboCiv
            // 
            this.cboCiv.FormattingEnabled = true;
            this.cboCiv.Items.AddRange(new object[] {
            "M.",
            "Mme.",
            "Mlle."});
            this.cboCiv.Location = new System.Drawing.Point(85, 51);
            this.cboCiv.Name = "cboCiv";
            this.cboCiv.Size = new System.Drawing.Size(239, 21);
            this.cboCiv.TabIndex = 0;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(85, 77);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(239, 20);
            this.txtNom.TabIndex = 1;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(85, 101);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(239, 20);
            this.txtPrenom.TabIndex = 2;
            // 
            // cboVendeur
            // 
            this.cboVendeur.FormattingEnabled = true;
            this.cboVendeur.Location = new System.Drawing.Point(86, 125);
            this.cboVendeur.Name = "cboVendeur";
            this.cboVendeur.Size = new System.Drawing.Size(238, 21);
            this.cboVendeur.TabIndex = 3;
            this.cboVendeur.SelectedIndexChanged += new System.EventHandler(this.cboVendeur_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Civilité*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nom*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Prénom*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Vendeur*";
            // 
            // btnEnregistre
            // 
            this.btnEnregistre.Location = new System.Drawing.Point(304, 195);
            this.btnEnregistre.Name = "btnEnregistre";
            this.btnEnregistre.Size = new System.Drawing.Size(156, 28);
            this.btnEnregistre.TabIndex = 13;
            this.btnEnregistre.Text = "Enregistrer";
            this.btnEnregistre.UseVisualStyleBackColor = true;
            this.btnEnregistre.Click += new System.EventHandler(this.btnEnregistre_Click);
            // 
            // btnVoiture
            // 
            this.btnVoiture.Location = new System.Drawing.Point(350, 11);
            this.btnVoiture.Name = "btnVoiture";
            this.btnVoiture.Size = new System.Drawing.Size(110, 28);
            this.btnVoiture.TabIndex = 14;
            this.btnVoiture.Text = "Voiture Neuve";
            this.btnVoiture.UseVisualStyleBackColor = true;
            this.btnVoiture.Click += new System.EventHandler(this.btnVoiture_Click);
            // 
            // btnValider
            // 
            this.btnValider.Enabled = false;
            this.btnValider.Location = new System.Drawing.Point(304, 229);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(156, 28);
            this.btnValider.TabIndex = 15;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // lblVendeur
            // 
            this.lblVendeur.AutoSize = true;
            this.lblVendeur.Location = new System.Drawing.Point(84, 176);
            this.lblVendeur.Name = "lblVendeur";
            this.lblVendeur.Size = new System.Drawing.Size(12, 13);
            this.lblVendeur.TabIndex = 27;
            this.lblVendeur.Text = "/";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Vendeur:";
            // 
            // btnVoitureOccasion
            // 
            this.btnVoitureOccasion.Location = new System.Drawing.Point(350, 42);
            this.btnVoitureOccasion.Name = "btnVoitureOccasion";
            this.btnVoitureOccasion.Size = new System.Drawing.Size(110, 28);
            this.btnVoitureOccasion.TabIndex = 28;
            this.btnVoitureOccasion.Text = "Voiture Occassion";
            this.btnVoitureOccasion.UseVisualStyleBackColor = true;
            this.btnVoitureOccasion.Click += new System.EventHandler(this.btnVoitureOccasion_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(12, 229);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(63, 28);
            this.btnInfo.TabIndex = 29;
            this.btnInfo.Text = "Retour";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Choix client";
            // 
            // cboChoixC
            // 
            this.cboChoixC.FormattingEnabled = true;
            this.cboChoixC.Location = new System.Drawing.Point(87, 14);
            this.cboChoixC.Name = "cboChoixC";
            this.cboChoixC.Size = new System.Drawing.Size(237, 21);
            this.cboChoixC.TabIndex = 32;
            this.cboChoixC.SelectedIndexChanged += new System.EventHandler(this.cboChoixC_SelectedIndexChanged);
            // 
            // frmIntro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 271);
            this.Controls.Add(this.cboChoixC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnVoitureOccasion);
            this.Controls.Add(this.lblVendeur);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnVoiture);
            this.Controls.Add(this.btnEnregistre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboVendeur);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.cboCiv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmIntro";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Credit Celeste - Introduction";
            this.Load += new System.EventHandler(this.frmIntro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCiv;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.ComboBox cboVendeur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEnregistre;
        private System.Windows.Forms.Button btnVoiture;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Label lblVendeur;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnVoitureOccasion;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboChoixC;
    }
}