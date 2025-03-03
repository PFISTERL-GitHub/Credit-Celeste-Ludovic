namespace CreditCeleste
{
    partial class frmAccueil
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
            this.btnIntro = new System.Windows.Forms.Button();
            this.btnEtude = new System.Windows.Forms.Button();
            this.btnRelance = new System.Windows.Forms.Button();
            this.lblMonApplication = new System.Windows.Forms.Label();
            this.lblRegion = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.lblV = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIntro
            // 
            this.btnIntro.Location = new System.Drawing.Point(12, 74);
            this.btnIntro.Name = "btnIntro";
            this.btnIntro.Size = new System.Drawing.Size(75, 28);
            this.btnIntro.TabIndex = 0;
            this.btnIntro.Text = "&Introduction";
            this.btnIntro.UseVisualStyleBackColor = true;
            this.btnIntro.Click += new System.EventHandler(this.btnIntro_Click);
            // 
            // btnEtude
            // 
            this.btnEtude.Enabled = false;
            this.btnEtude.Location = new System.Drawing.Point(197, 74);
            this.btnEtude.Name = "btnEtude";
            this.btnEtude.Size = new System.Drawing.Size(75, 28);
            this.btnEtude.TabIndex = 1;
            this.btnEtude.Text = "&Etude";
            this.btnEtude.UseVisualStyleBackColor = true;
            this.btnEtude.Click += new System.EventHandler(this.btnEtude_Click);
            // 
            // btnRelance
            // 
            this.btnRelance.Enabled = false;
            this.btnRelance.Location = new System.Drawing.Point(278, 74);
            this.btnRelance.Name = "btnRelance";
            this.btnRelance.Size = new System.Drawing.Size(75, 28);
            this.btnRelance.TabIndex = 2;
            this.btnRelance.Text = "&Relance";
            this.btnRelance.UseVisualStyleBackColor = true;
            // 
            // lblMonApplication
            // 
            this.lblMonApplication.AutoSize = true;
            this.lblMonApplication.Location = new System.Drawing.Point(12, 29);
            this.lblMonApplication.Name = "lblMonApplication";
            this.lblMonApplication.Size = new System.Drawing.Size(29, 13);
            this.lblMonApplication.TabIndex = 3;
            this.lblMonApplication.Text = "Nom";
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Location = new System.Drawing.Point(127, 29);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(41, 13);
            this.lblRegion.TabIndex = 4;
            this.lblRegion.Text = "Région";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(93, 74);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 28);
            this.btnTest.TabIndex = 5;
            this.btnTest.Text = "&BDD TEST";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // lblV
            // 
            this.lblV.AutoSize = true;
            this.lblV.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblV.Location = new System.Drawing.Point(292, 9);
            this.lblV.Name = "lblV";
            this.lblV.Size = new System.Drawing.Size(44, 12);
            this.lblV.TabIndex = 6;
            this.lblV.Text = "Version";
            // 
            // frmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 110);
            this.Controls.Add(this.lblV);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.lblRegion);
            this.Controls.Add(this.lblMonApplication);
            this.Controls.Add(this.btnRelance);
            this.Controls.Add(this.btnEtude);
            this.Controls.Add(this.btnIntro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAccueil";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Credit Celeste - Accueil";
            this.Load += new System.EventHandler(this.frmAccueil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIntro;
        private System.Windows.Forms.Button btnEtude;
        private System.Windows.Forms.Button btnRelance;
        private System.Windows.Forms.Label lblMonApplication;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label lblV;
    }
}