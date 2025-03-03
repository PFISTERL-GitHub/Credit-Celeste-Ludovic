
namespace CreditCeleste
{
    partial class frmAssurance
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
            this.lblVendeur = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.btnEnregistre = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMarque = new System.Windows.Forms.TextBox();
            this.txtNumImmat = new System.Windows.Forms.TextBox();
            this.gpbDureeAssurance = new System.Windows.Forms.GroupBox();
            this.rdbQuatreAns = new System.Windows.Forms.RadioButton();
            this.rdbTroisAns = new System.Windows.Forms.RadioButton();
            this.rdbDeuxAns = new System.Windows.Forms.RadioButton();
            this.rdbUnAn = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.cboCiv = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDtn = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDtp = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTelGarage = new System.Windows.Forms.TextBox();
            this.txtAdrGarage = new System.Windows.Forms.TextBox();
            this.gpbDureeAssurance.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVendeur
            // 
            this.lblVendeur.AutoSize = true;
            this.lblVendeur.Location = new System.Drawing.Point(80, 155);
            this.lblVendeur.Name = "lblVendeur";
            this.lblVendeur.Size = new System.Drawing.Size(12, 13);
            this.lblVendeur.TabIndex = 45;
            this.lblVendeur.Text = "/";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Vendeur:";
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(345, 232);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(131, 28);
            this.btnValider.TabIndex = 43;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(10, 232);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(75, 28);
            this.btnRetour.TabIndex = 42;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // btnEnregistre
            // 
            this.btnEnregistre.Location = new System.Drawing.Point(264, 232);
            this.btnEnregistre.Name = "btnEnregistre";
            this.btnEnregistre.Size = new System.Drawing.Size(75, 28);
            this.btnEnregistre.TabIndex = 41;
            this.btnEnregistre.Text = "Enregistrer";
            this.btnEnregistre.UseVisualStyleBackColor = true;
            this.btnEnregistre.Click += new System.EventHandler(this.btnEnregistre_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(238, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Marque Voiture";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(238, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Numero Immatriculation";
            // 
            // txtMarque
            // 
            this.txtMarque.Location = new System.Drawing.Point(353, 37);
            this.txtMarque.Name = "txtMarque";
            this.txtMarque.Size = new System.Drawing.Size(124, 20);
            this.txtMarque.TabIndex = 38;
            // 
            // txtNumImmat
            // 
            this.txtNumImmat.Location = new System.Drawing.Point(353, 11);
            this.txtNumImmat.Name = "txtNumImmat";
            this.txtNumImmat.Size = new System.Drawing.Size(124, 20);
            this.txtNumImmat.TabIndex = 37;
            // 
            // gpbDureeAssurance
            // 
            this.gpbDureeAssurance.Controls.Add(this.rdbQuatreAns);
            this.gpbDureeAssurance.Controls.Add(this.rdbTroisAns);
            this.gpbDureeAssurance.Controls.Add(this.rdbDeuxAns);
            this.gpbDureeAssurance.Controls.Add(this.rdbUnAn);
            this.gpbDureeAssurance.Location = new System.Drawing.Point(241, 110);
            this.gpbDureeAssurance.Name = "gpbDureeAssurance";
            this.gpbDureeAssurance.Size = new System.Drawing.Size(235, 115);
            this.gpbDureeAssurance.TabIndex = 36;
            this.gpbDureeAssurance.TabStop = false;
            this.gpbDureeAssurance.Text = "Duree Assurance*";
            this.gpbDureeAssurance.Enter += new System.EventHandler(this.gpbDureeAssurance_Enter);
            // 
            // rdbQuatreAns
            // 
            this.rdbQuatreAns.AutoSize = true;
            this.rdbQuatreAns.Location = new System.Drawing.Point(6, 89);
            this.rdbQuatreAns.Name = "rdbQuatreAns";
            this.rdbQuatreAns.Size = new System.Drawing.Size(88, 17);
            this.rdbQuatreAns.TabIndex = 3;
            this.rdbQuatreAns.Text = "4 ans / Prix ?";
            this.rdbQuatreAns.UseVisualStyleBackColor = true;
            // 
            // rdbTroisAns
            // 
            this.rdbTroisAns.AutoSize = true;
            this.rdbTroisAns.Location = new System.Drawing.Point(6, 66);
            this.rdbTroisAns.Name = "rdbTroisAns";
            this.rdbTroisAns.Size = new System.Drawing.Size(88, 17);
            this.rdbTroisAns.TabIndex = 2;
            this.rdbTroisAns.Text = "3 ans / Prix ?";
            this.rdbTroisAns.UseVisualStyleBackColor = true;
            // 
            // rdbDeuxAns
            // 
            this.rdbDeuxAns.AutoSize = true;
            this.rdbDeuxAns.Location = new System.Drawing.Point(6, 42);
            this.rdbDeuxAns.Name = "rdbDeuxAns";
            this.rdbDeuxAns.Size = new System.Drawing.Size(88, 17);
            this.rdbDeuxAns.TabIndex = 1;
            this.rdbDeuxAns.Text = "2 ans / Prix ?";
            this.rdbDeuxAns.UseVisualStyleBackColor = true;
            // 
            // rdbUnAn
            // 
            this.rdbUnAn.AutoSize = true;
            this.rdbUnAn.Location = new System.Drawing.Point(6, 19);
            this.rdbUnAn.Name = "rdbUnAn";
            this.rdbUnAn.Size = new System.Drawing.Size(83, 17);
            this.rdbUnAn.TabIndex = 0;
            this.rdbUnAn.Text = "1 an / Prix ?";
            this.rdbUnAn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Prénom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Nom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Civilité";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(97, 61);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(120, 20);
            this.txtPrenom.TabIndex = 30;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(97, 37);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(120, 20);
            this.txtNom.TabIndex = 29;
            // 
            // cboCiv
            // 
            this.cboCiv.FormattingEnabled = true;
            this.cboCiv.Items.AddRange(new object[] {
            "M.",
            "Mme.",
            "Mlle."});
            this.cboCiv.Location = new System.Drawing.Point(97, 11);
            this.cboCiv.Name = "cboCiv";
            this.cboCiv.Size = new System.Drawing.Size(121, 21);
            this.cboCiv.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Date Naissance";
            // 
            // txtDtn
            // 
            this.txtDtn.Location = new System.Drawing.Point(97, 85);
            this.txtDtn.Name = "txtDtn";
            this.txtDtn.Size = new System.Drawing.Size(120, 20);
            this.txtDtn.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 49;
            this.label8.Text = "Date Permis";
            // 
            // txtDtp
            // 
            this.txtDtp.Location = new System.Drawing.Point(98, 110);
            this.txtDtp.Name = "txtDtp";
            this.txtDtp.Size = new System.Drawing.Size(120, 20);
            this.txtDtp.TabIndex = 48;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(238, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 53;
            this.label9.Text = "Telephone Garage";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(238, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 52;
            this.label10.Text = "Adresse Garage";
            // 
            // txtTelGarage
            // 
            this.txtTelGarage.Location = new System.Drawing.Point(353, 85);
            this.txtTelGarage.Name = "txtTelGarage";
            this.txtTelGarage.Size = new System.Drawing.Size(124, 20);
            this.txtTelGarage.TabIndex = 51;
            // 
            // txtAdrGarage
            // 
            this.txtAdrGarage.Location = new System.Drawing.Point(353, 61);
            this.txtAdrGarage.Name = "txtAdrGarage";
            this.txtAdrGarage.Size = new System.Drawing.Size(124, 20);
            this.txtAdrGarage.TabIndex = 50;
            // 
            // frmAssurance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 271);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTelGarage);
            this.Controls.Add(this.txtAdrGarage);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDtp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDtn);
            this.Controls.Add(this.lblVendeur);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnEnregistre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMarque);
            this.Controls.Add(this.txtNumImmat);
            this.Controls.Add(this.gpbDureeAssurance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.cboCiv);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmAssurance";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Credit Celeste - Assurance";
            this.Load += new System.EventHandler(this.frmAssurance_Load);
            this.gpbDureeAssurance.ResumeLayout(false);
            this.gpbDureeAssurance.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVendeur;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Button btnEnregistre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMarque;
        private System.Windows.Forms.TextBox txtNumImmat;
        private System.Windows.Forms.GroupBox gpbDureeAssurance;
        private System.Windows.Forms.RadioButton rdbQuatreAns;
        private System.Windows.Forms.RadioButton rdbTroisAns;
        private System.Windows.Forms.RadioButton rdbDeuxAns;
        private System.Windows.Forms.RadioButton rdbUnAn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.ComboBox cboCiv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDtp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTelGarage;
        private System.Windows.Forms.TextBox txtAdrGarage;
    }
}