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
            this.txtNouvVhc = new System.Windows.Forms.TextBox();
            this.txtAncVhc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEnregistre = new System.Windows.Forms.Button();
            this.btnVoiture = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.lblVendeur = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnVoitureOccasion = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboCiv
            // 
            this.cboCiv.FormattingEnabled = true;
            this.cboCiv.Items.AddRange(new object[] {
            "M.",
            "Mme.",
            "Mlle."});
            this.cboCiv.Location = new System.Drawing.Point(108, 13);
            this.cboCiv.Margin = new System.Windows.Forms.Padding(4);
            this.cboCiv.Name = "cboCiv";
            this.cboCiv.Size = new System.Drawing.Size(160, 24);
            this.cboCiv.TabIndex = 0;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(108, 45);
            this.txtNom.Margin = new System.Windows.Forms.Padding(4);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(159, 22);
            this.txtNom.TabIndex = 1;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(108, 75);
            this.txtPrenom.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(159, 22);
            this.txtPrenom.TabIndex = 2;
            // 
            // cboVendeur
            // 
            this.cboVendeur.FormattingEnabled = true;
            this.cboVendeur.Location = new System.Drawing.Point(109, 105);
            this.cboVendeur.Margin = new System.Windows.Forms.Padding(4);
            this.cboVendeur.Name = "cboVendeur";
            this.cboVendeur.Size = new System.Drawing.Size(159, 24);
            this.cboVendeur.TabIndex = 3;
            this.cboVendeur.SelectedIndexChanged += new System.EventHandler(this.cboVendeur_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Civilité*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nom*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Prénom*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 108);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Vendeur*";
            // 
            // txtNouvVhc
            // 
            this.txtNouvVhc.Location = new System.Drawing.Point(471, 13);
            this.txtNouvVhc.Margin = new System.Windows.Forms.Padding(4);
            this.txtNouvVhc.Name = "txtNouvVhc";
            this.txtNouvVhc.Size = new System.Drawing.Size(164, 22);
            this.txtNouvVhc.TabIndex = 9;
            // 
            // txtAncVhc
            // 
            this.txtAncVhc.Location = new System.Drawing.Point(471, 43);
            this.txtAncVhc.Margin = new System.Windows.Forms.Padding(4);
            this.txtAncVhc.Name = "txtAncVhc";
            this.txtAncVhc.Size = new System.Drawing.Size(164, 22);
            this.txtAncVhc.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(309, 16);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Mon Nouveau Vehicule";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(309, 46);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Mon Ancien Vehicule";
            // 
            // btnEnregistre
            // 
            this.btnEnregistre.Location = new System.Drawing.Point(352, 285);
            this.btnEnregistre.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnregistre.Name = "btnEnregistre";
            this.btnEnregistre.Size = new System.Drawing.Size(100, 35);
            this.btnEnregistre.TabIndex = 13;
            this.btnEnregistre.Text = "Enregistrer";
            this.btnEnregistre.UseVisualStyleBackColor = true;
            this.btnEnregistre.Click += new System.EventHandler(this.btnEnregistre_Click);
            // 
            // btnVoiture
            // 
            this.btnVoiture.Location = new System.Drawing.Point(13, 285);
            this.btnVoiture.Margin = new System.Windows.Forms.Padding(4);
            this.btnVoiture.Name = "btnVoiture";
            this.btnVoiture.Size = new System.Drawing.Size(100, 35);
            this.btnVoiture.TabIndex = 14;
            this.btnVoiture.Text = "Voiture";
            this.btnVoiture.UseVisualStyleBackColor = true;
            this.btnVoiture.Click += new System.EventHandler(this.btnVoiture_Click);
            // 
            // btnValider
            // 
            this.btnValider.Enabled = false;
            this.btnValider.Location = new System.Drawing.Point(460, 285);
            this.btnValider.Margin = new System.Windows.Forms.Padding(4);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(175, 35);
            this.btnValider.TabIndex = 15;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // lblVendeur
            // 
            this.lblVendeur.AutoSize = true;
            this.lblVendeur.Location = new System.Drawing.Point(106, 183);
            this.lblVendeur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVendeur.Name = "lblVendeur";
            this.lblVendeur.Size = new System.Drawing.Size(12, 17);
            this.lblVendeur.TabIndex = 27;
            this.lblVendeur.Text = "/";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 183);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "Vendeur:";
            // 
            // btnVoitureOccasion
            // 
            this.btnVoitureOccasion.Location = new System.Drawing.Point(121, 285);
            this.btnVoitureOccasion.Margin = new System.Windows.Forms.Padding(4);
            this.btnVoitureOccasion.Name = "btnVoitureOccasion";
            this.btnVoitureOccasion.Size = new System.Drawing.Size(146, 35);
            this.btnVoitureOccasion.TabIndex = 28;
            this.btnVoitureOccasion.Text = "Voiture Occassion";
            this.btnVoitureOccasion.UseVisualStyleBackColor = true;
            this.btnVoitureOccasion.Click += new System.EventHandler(this.btnVoitureOccasion_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(13, 242);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(4);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(100, 35);
            this.btnInfo.TabIndex = 29;
            this.btnInfo.Text = "Retour";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // frmIntro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 333);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnVoitureOccasion);
            this.Controls.Add(this.lblVendeur);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnVoiture);
            this.Controls.Add(this.btnEnregistre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAncVhc);
            this.Controls.Add(this.txtNouvVhc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboVendeur);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.cboCiv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.TextBox txtNouvVhc;
        private System.Windows.Forms.TextBox txtAncVhc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEnregistre;
        private System.Windows.Forms.Button btnVoiture;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Label lblVendeur;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnVoitureOccasion;
        private System.Windows.Forms.Button btnInfo;
    }
}