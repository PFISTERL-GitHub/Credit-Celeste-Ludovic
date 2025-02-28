namespace CreditCeleste
{
    partial class frmVoiture
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
            this.txtNumImmat = new System.Windows.Forms.TextBox();
            this.txtDate1ereImmat = new System.Windows.Forms.TextBox();
            this.txtPuissance = new System.Windows.Forms.TextBox();
            this.txtNumSerie = new System.Windows.Forms.TextBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblVendeur = new System.Windows.Forms.Label();
            this.btnAssurance = new System.Windows.Forms.Button();
            this.gpbAgeVehicule = new System.Windows.Forms.GroupBox();
            this.rdbOccas5OuPlus = new System.Windows.Forms.RadioButton();
            this.rdbOccas3a5 = new System.Windows.Forms.RadioButton();
            this.rdbOccasMoins3 = new System.Windows.Forms.RadioButton();
            this.cbxNouvVhc = new System.Windows.Forms.ComboBox();
            this.lblClient = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrixV = new System.Windows.Forms.TextBox();
            this.gpbAgeVehicule.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNumImmat
            // 
            this.txtNumImmat.Location = new System.Drawing.Point(142, 69);
            this.txtNumImmat.Name = "txtNumImmat";
            this.txtNumImmat.Size = new System.Drawing.Size(220, 20);
            this.txtNumImmat.TabIndex = 14;
            // 
            // txtDate1ereImmat
            // 
            this.txtDate1ereImmat.Location = new System.Drawing.Point(142, 45);
            this.txtDate1ereImmat.Name = "txtDate1ereImmat";
            this.txtDate1ereImmat.Size = new System.Drawing.Size(220, 20);
            this.txtDate1ereImmat.TabIndex = 12;
            // 
            // txtPuissance
            // 
            this.txtPuissance.Location = new System.Drawing.Point(142, 118);
            this.txtPuissance.Name = "txtPuissance";
            this.txtPuissance.Size = new System.Drawing.Size(220, 20);
            this.txtPuissance.TabIndex = 11;
            // 
            // txtNumSerie
            // 
            this.txtNumSerie.Location = new System.Drawing.Point(142, 93);
            this.txtNumSerie.Name = "txtNumSerie";
            this.txtNumSerie.Size = new System.Drawing.Size(220, 20);
            this.txtNumSerie.TabIndex = 15;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(476, 276);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(131, 28);
            this.btnValider.TabIndex = 18;
            this.btnValider.Text = "Acheter";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(12, 276);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(75, 28);
            this.btnInfo.TabIndex = 17;
            this.btnInfo.Text = "Retour";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnIntro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Mon Nouveau Véhicule*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Date 1ère Immatriculation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Numéro Immatriculation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Numéro de série";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Puissance";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Vendeur:";
            // 
            // lblVendeur
            // 
            this.lblVendeur.AutoSize = true;
            this.lblVendeur.Location = new System.Drawing.Point(88, 192);
            this.lblVendeur.Name = "lblVendeur";
            this.lblVendeur.Size = new System.Drawing.Size(12, 13);
            this.lblVendeur.TabIndex = 25;
            this.lblVendeur.Text = "/";
            // 
            // btnAssurance
            // 
            this.btnAssurance.Location = new System.Drawing.Point(93, 276);
            this.btnAssurance.Name = "btnAssurance";
            this.btnAssurance.Size = new System.Drawing.Size(75, 28);
            this.btnAssurance.TabIndex = 26;
            this.btnAssurance.Text = "Assurance";
            this.btnAssurance.UseVisualStyleBackColor = true;
            this.btnAssurance.Click += new System.EventHandler(this.btnAssurance_Click);
            // 
            // gpbAgeVehicule
            // 
            this.gpbAgeVehicule.Controls.Add(this.rdbOccas5OuPlus);
            this.gpbAgeVehicule.Controls.Add(this.rdbOccas3a5);
            this.gpbAgeVehicule.Controls.Add(this.rdbOccasMoins3);
            this.gpbAgeVehicule.Location = new System.Drawing.Point(382, 30);
            this.gpbAgeVehicule.Name = "gpbAgeVehicule";
            this.gpbAgeVehicule.Size = new System.Drawing.Size(218, 93);
            this.gpbAgeVehicule.TabIndex = 27;
            this.gpbAgeVehicule.TabStop = false;
            this.gpbAgeVehicule.Text = "Age du véhicule*";
            // 
            // rdbOccas5OuPlus
            // 
            this.rdbOccas5OuPlus.AutoSize = true;
            this.rdbOccas5OuPlus.Location = new System.Drawing.Point(6, 66);
            this.rdbOccas5OuPlus.Name = "rdbOccas5OuPlus";
            this.rdbOccas5OuPlus.Size = new System.Drawing.Size(75, 17);
            this.rdbOccas5OuPlus.TabIndex = 3;
            this.rdbOccas5OuPlus.Text = "5 ans ou +";
            this.rdbOccas5OuPlus.UseVisualStyleBackColor = true;
            // 
            // rdbOccas3a5
            // 
            this.rdbOccas3a5.AutoSize = true;
            this.rdbOccas3a5.Location = new System.Drawing.Point(6, 42);
            this.rdbOccas3a5.Name = "rdbOccas3a5";
            this.rdbOccas3a5.Size = new System.Drawing.Size(69, 17);
            this.rdbOccas3a5.TabIndex = 2;
            this.rdbOccas3a5.Text = "3 à 5 ans";
            this.rdbOccas3a5.UseVisualStyleBackColor = true;
            // 
            // rdbOccasMoins3
            // 
            this.rdbOccasMoins3.AutoSize = true;
            this.rdbOccasMoins3.Location = new System.Drawing.Point(6, 19);
            this.rdbOccasMoins3.Name = "rdbOccasMoins3";
            this.rdbOccasMoins3.Size = new System.Drawing.Size(97, 17);
            this.rdbOccasMoins3.TabIndex = 1;
            this.rdbOccasMoins3.Text = "Moins de 3 ans";
            this.rdbOccasMoins3.UseVisualStyleBackColor = true;
            // 
            // cbxNouvVhc
            // 
            this.cbxNouvVhc.FormattingEnabled = true;
            this.cbxNouvVhc.Location = new System.Drawing.Point(142, 6);
            this.cbxNouvVhc.Name = "cbxNouvVhc";
            this.cbxNouvVhc.Size = new System.Drawing.Size(220, 21);
            this.cbxNouvVhc.Sorted = true;
            this.cbxNouvVhc.TabIndex = 28;
            this.cbxNouvVhc.SelectedIndexChanged += new System.EventHandler(this.cbxNouvVhc_SelectedIndexChanged_1);
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(88, 216);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(12, 13);
            this.lblClient.TabIndex = 30;
            this.lblClient.Text = "/";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Client:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Prix de Vente";
            // 
            // txtPrixV
            // 
            this.txtPrixV.Location = new System.Drawing.Point(142, 144);
            this.txtPrixV.Name = "txtPrixV";
            this.txtPrixV.Size = new System.Drawing.Size(220, 20);
            this.txtPrixV.TabIndex = 31;
            // 
            // frmVoiture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 316);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPrixV);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbxNouvVhc);
            this.Controls.Add(this.gpbAgeVehicule);
            this.Controls.Add(this.btnAssurance);
            this.Controls.Add(this.lblVendeur);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.txtNumSerie);
            this.Controls.Add(this.txtNumImmat);
            this.Controls.Add(this.txtDate1ereImmat);
            this.Controls.Add(this.txtPuissance);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmVoiture";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Credit Celeste - VoitureNeuve";
            this.Load += new System.EventHandler(this.frmVoiture_Load);
            this.gpbAgeVehicule.ResumeLayout(false);
            this.gpbAgeVehicule.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNumImmat;
        private System.Windows.Forms.TextBox txtDate1ereImmat;
        private System.Windows.Forms.TextBox txtPuissance;
        private System.Windows.Forms.TextBox txtNumSerie;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblVendeur;
        private System.Windows.Forms.Button btnAssurance;
        private System.Windows.Forms.GroupBox gpbAgeVehicule;
        private System.Windows.Forms.RadioButton rdbOccas5OuPlus;
        private System.Windows.Forms.RadioButton rdbOccas3a5;
        private System.Windows.Forms.RadioButton rdbOccasMoins3;
        private System.Windows.Forms.ComboBox cbxNouvVhc;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPrixV;
    }
}