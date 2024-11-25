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
            this.cmdTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIntro
            // 
            this.btnIntro.Location = new System.Drawing.Point(13, 39);
            this.btnIntro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIntro.Name = "btnIntro";
            this.btnIntro.Size = new System.Drawing.Size(100, 34);
            this.btnIntro.TabIndex = 0;
            this.btnIntro.Text = "&Introduction";
            this.btnIntro.UseVisualStyleBackColor = true;
            this.btnIntro.Click += new System.EventHandler(this.btnIntro_Click);
            // 
            // btnEtude
            // 
            this.btnEtude.Location = new System.Drawing.Point(229, 39);
            this.btnEtude.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEtude.Name = "btnEtude";
            this.btnEtude.Size = new System.Drawing.Size(100, 34);
            this.btnEtude.TabIndex = 1;
            this.btnEtude.Text = "&Etude";
            this.btnEtude.UseVisualStyleBackColor = true;
            this.btnEtude.Click += new System.EventHandler(this.btnEtude_Click);
            // 
            // btnRelance
            // 
            this.btnRelance.Location = new System.Drawing.Point(121, 39);
            this.btnRelance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRelance.Name = "btnRelance";
            this.btnRelance.Size = new System.Drawing.Size(100, 34);
            this.btnRelance.TabIndex = 2;
            this.btnRelance.Text = "&Relance";
            this.btnRelance.UseVisualStyleBackColor = true;
            // 
            // lblMonApplication
            // 
            this.lblMonApplication.AutoSize = true;
            this.lblMonApplication.Location = new System.Drawing.Point(13, 9);
            this.lblMonApplication.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMonApplication.Name = "lblMonApplication";
            this.lblMonApplication.Size = new System.Drawing.Size(37, 17);
            this.lblMonApplication.TabIndex = 3;
            this.lblMonApplication.Text = "Nom";
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Location = new System.Drawing.Point(168, 9);
            this.lblRegion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(53, 17);
            this.lblRegion.TabIndex = 4;
            this.lblRegion.Text = "Région";
            // 
            // cmdTest
            // 
            this.cmdTest.Location = new System.Drawing.Point(352, 39);
            this.cmdTest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdTest.Name = "cmdTest";
            this.cmdTest.Size = new System.Drawing.Size(100, 34);
            this.cmdTest.TabIndex = 5;
            this.cmdTest.Text = "&Test";
            this.cmdTest.UseVisualStyleBackColor = true;
            this.cmdTest.Click += new System.EventHandler(this.cmdTest_Click);
            // 
            // frmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 89);
            this.Controls.Add(this.cmdTest);
            this.Controls.Add(this.lblRegion);
            this.Controls.Add(this.lblMonApplication);
            this.Controls.Add(this.btnRelance);
            this.Controls.Add(this.btnEtude);
            this.Controls.Add(this.btnIntro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button cmdTest;
    }
}

