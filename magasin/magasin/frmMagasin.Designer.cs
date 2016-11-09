namespace magasin
{
    partial class frmMagasin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMagasin));
            this.btnFrmLogin = new System.Windows.Forms.Button();
            this.cbxCategories = new System.Windows.Forms.ComboBox();
            this.lsbProduits = new System.Windows.Forms.ListBox();
            this.btnPanier = new System.Windows.Forms.Button();
            this.nudQuantite = new System.Windows.Forms.NumericUpDown();
            this.lblPanier = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantite)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFrmLogin
            // 
            this.btnFrmLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFrmLogin.Location = new System.Drawing.Point(12, 12);
            this.btnFrmLogin.Name = "btnFrmLogin";
            this.btnFrmLogin.Size = new System.Drawing.Size(121, 23);
            this.btnFrmLogin.TabIndex = 1;
            this.btnFrmLogin.Text = "Login";
            this.btnFrmLogin.UseVisualStyleBackColor = true;
            this.btnFrmLogin.Click += new System.EventHandler(this.btnFrmLogin_Click);
            // 
            // cbxCategories
            // 
            this.cbxCategories.FormattingEnabled = true;
            this.cbxCategories.Location = new System.Drawing.Point(12, 41);
            this.cbxCategories.Name = "cbxCategories";
            this.cbxCategories.Size = new System.Drawing.Size(164, 21);
            this.cbxCategories.TabIndex = 2;
            // 
            // lsbProduits
            // 
            this.lsbProduits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbProduits.FormattingEnabled = true;
            this.lsbProduits.ItemHeight = 20;
            this.lsbProduits.Items.AddRange(new object[] {
            "test",
            "test2",
            "test3",
            "test4",
            "test5",
            "test6",
            "test7"});
            this.lsbProduits.Location = new System.Drawing.Point(12, 68);
            this.lsbProduits.Name = "lsbProduits";
            this.lsbProduits.Size = new System.Drawing.Size(398, 264);
            this.lsbProduits.TabIndex = 3;
            // 
            // btnPanier
            // 
            this.btnPanier.Location = new System.Drawing.Point(206, 351);
            this.btnPanier.Name = "btnPanier";
            this.btnPanier.Size = new System.Drawing.Size(160, 27);
            this.btnPanier.TabIndex = 5;
            this.btnPanier.Text = "Ajouter au panier";
            this.btnPanier.UseVisualStyleBackColor = true;
            this.btnPanier.Click += new System.EventHandler(this.btnPanier_Click);
            // 
            // nudQuantite
            // 
            this.nudQuantite.Location = new System.Drawing.Point(80, 356);
            this.nudQuantite.Name = "nudQuantite";
            this.nudQuantite.Size = new System.Drawing.Size(120, 20);
            this.nudQuantite.TabIndex = 4;
            // 
            // lblPanier
            // 
            this.lblPanier.AutoSize = true;
            this.lblPanier.Location = new System.Drawing.Point(139, 17);
            this.lblPanier.Name = "lblPanier";
            this.lblPanier.Size = new System.Drawing.Size(37, 13);
            this.lblPanier.TabIndex = 6;
            this.lblPanier.Text = "Panier";
            this.lblPanier.Click += new System.EventHandler(this.lblPanier_Click);
            // 
            // frmMagasin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 390);
            this.Controls.Add(this.lblPanier);
            this.Controls.Add(this.nudQuantite);
            this.Controls.Add(this.btnPanier);
            this.Controls.Add(this.lsbProduits);
            this.Controls.Add(this.cbxCategories);
            this.Controls.Add(this.btnFrmLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMagasin";
            this.Text = "Magasin";
            this.Load += new System.EventHandler(this.frmMagasin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFrmLogin;
        private System.Windows.Forms.ComboBox cbxCategories;
        private System.Windows.Forms.ListBox lsbProduits;
        private System.Windows.Forms.Button btnPanier;
        private System.Windows.Forms.NumericUpDown nudQuantite;
        private System.Windows.Forms.Label lblPanier;
    }
}

