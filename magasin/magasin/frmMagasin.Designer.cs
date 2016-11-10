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
            this.btnPanier = new System.Windows.Forms.Button();
            this.nudQuantite = new System.Windows.Forms.NumericUpDown();
            this.panelProduit = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pbxImage = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblPrix = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panelPanier = new System.Windows.Forms.Panel();
            this.gbxProduit = new System.Windows.Forms.GroupBox();
            this.lblProduitPanier = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblSoulignementPanier = new System.Windows.Forms.Label();
            this.lblPanier = new System.Windows.Forms.Label();
            this.btnAcheter = new System.Windows.Forms.Button();
            this.lblCategorie = new System.Windows.Forms.Label();
            this.lblSoulignementCategorie = new System.Windows.Forms.Label();
            this.tbxRecherche = new System.Windows.Forms.TextBox();
            this.lblRecherche = new System.Windows.Forms.Label();
            this.pbxRecherche = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantite)).BeginInit();
            this.panelProduit.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panelPanier.SuspendLayout();
            this.gbxProduit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRecherche)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFrmLogin
            // 
            this.btnFrmLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(86)))));
            this.btnFrmLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFrmLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFrmLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFrmLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(208)))), ((int)(((byte)(192)))));
            this.btnFrmLogin.Location = new System.Drawing.Point(885, 497);
            this.btnFrmLogin.Name = "btnFrmLogin";
            this.btnFrmLogin.Size = new System.Drawing.Size(275, 80);
            this.btnFrmLogin.TabIndex = 7;
            this.btnFrmLogin.Text = "Login";
            this.btnFrmLogin.UseVisualStyleBackColor = false;
            this.btnFrmLogin.Click += new System.EventHandler(this.btnFrmLogin_Click);
            // 
            // cbxCategories
            // 
            this.cbxCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(86)))));
            this.cbxCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxCategories.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(208)))), ((int)(((byte)(192)))));
            this.cbxCategories.FormattingEnabled = true;
            this.cbxCategories.Location = new System.Drawing.Point(188, 35);
            this.cbxCategories.Name = "cbxCategories";
            this.cbxCategories.Size = new System.Drawing.Size(164, 21);
            this.cbxCategories.TabIndex = 1;
            // 
            // btnPanier
            // 
            this.btnPanier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(86)))));
            this.btnPanier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPanier.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPanier.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPanier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(208)))), ((int)(((byte)(192)))));
            this.btnPanier.Location = new System.Drawing.Point(3, 29);
            this.btnPanier.Name = "btnPanier";
            this.btnPanier.Size = new System.Drawing.Size(180, 81);
            this.btnPanier.TabIndex = 5;
            this.btnPanier.Text = "Ajouter au panier";
            this.btnPanier.UseVisualStyleBackColor = false;
            this.btnPanier.Click += new System.EventHandler(this.btnPanier_Click);
            // 
            // nudQuantite
            // 
            this.nudQuantite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(86)))));
            this.nudQuantite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQuantite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(208)))), ((int)(((byte)(192)))));
            this.nudQuantite.Location = new System.Drawing.Point(3, 3);
            this.nudQuantite.Name = "nudQuantite";
            this.nudQuantite.Size = new System.Drawing.Size(180, 22);
            this.nudQuantite.TabIndex = 4;
            this.nudQuantite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelProduit
            // 
            this.panelProduit.AutoScroll = true;
            this.panelProduit.Controls.Add(this.tableLayoutPanel1);
            this.panelProduit.Location = new System.Drawing.Point(12, 68);
            this.panelProduit.Name = "panelProduit";
            this.panelProduit.Size = new System.Drawing.Size(867, 700);
            this.panelProduit.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.92537F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.07462F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 194F));
            this.tableLayoutPanel1.Controls.Add(this.pbxImage, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 14);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(846, 123);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // pbxImage
            // 
            this.pbxImage.Image = ((System.Drawing.Image)(resources.GetObject("pbxImage.Image")));
            this.pbxImage.Location = new System.Drawing.Point(5, 5);
            this.pbxImage.Name = "pbxImage";
            this.pbxImage.Size = new System.Drawing.Size(218, 113);
            this.pbxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImage.TabIndex = 0;
            this.pbxImage.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.92537F));
            this.tableLayoutPanel2.Controls.Add(this.lblTitre, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblPrix, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblDescription, 0, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(231, 5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(413, 113);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Location = new System.Drawing.Point(3, 0);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(102, 13);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "La tomate de fanfan";
            // 
            // lblPrix
            // 
            this.lblPrix.AutoSize = true;
            this.lblPrix.Location = new System.Drawing.Point(3, 23);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(49, 13);
            this.lblPrix.TabIndex = 1;
            this.lblPrix.Text = "1.56CHF";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(3, 49);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(401, 39);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "La tomate est une espèce de plantes herbacées de la famille des Solanacées, origi" +
    "naire du Nord-Ouest de l\'Amérique du Sud, largement cultivée pour son fruit. Le " +
    "terme désigne aussi ce fruit charnu.";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.nudQuantite, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnPanier, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(652, 5);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.8938F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.10619F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(186, 113);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // panelPanier
            // 
            this.panelPanier.AutoScroll = true;
            this.panelPanier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPanier.Controls.Add(this.gbxProduit);
            this.panelPanier.Location = new System.Drawing.Point(885, 68);
            this.panelPanier.Name = "panelPanier";
            this.panelPanier.Size = new System.Drawing.Size(282, 337);
            this.panelPanier.TabIndex = 9;
            // 
            // gbxProduit
            // 
            this.gbxProduit.Controls.Add(this.lblProduitPanier);
            this.gbxProduit.Controls.Add(this.button1);
            this.gbxProduit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxProduit.Location = new System.Drawing.Point(7, 3);
            this.gbxProduit.Name = "gbxProduit";
            this.gbxProduit.Size = new System.Drawing.Size(267, 38);
            this.gbxProduit.TabIndex = 2;
            this.gbxProduit.TabStop = false;
            // 
            // lblProduitPanier
            // 
            this.lblProduitPanier.Location = new System.Drawing.Point(6, 10);
            this.lblProduitPanier.Name = "lblProduitPanier";
            this.lblProduitPanier.Size = new System.Drawing.Size(185, 25);
            this.lblProduitPanier.TabIndex = 0;
            this.lblProduitPanier.Text = "La tomate de fanfan x15";
            this.lblProduitPanier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(86)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(197, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 22);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lblSoulignementPanier
            // 
            this.lblSoulignementPanier.AutoSize = true;
            this.lblSoulignementPanier.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoulignementPanier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(208)))), ((int)(((byte)(192)))));
            this.lblSoulignementPanier.Location = new System.Drawing.Point(879, 28);
            this.lblSoulignementPanier.Name = "lblSoulignementPanier";
            this.lblSoulignementPanier.Size = new System.Drawing.Size(127, 33);
            this.lblSoulignementPanier.TabIndex = 5;
            this.lblSoulignementPanier.Text = "_______";
            // 
            // lblPanier
            // 
            this.lblPanier.AutoSize = true;
            this.lblPanier.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPanier.Location = new System.Drawing.Point(879, 24);
            this.lblPanier.Name = "lblPanier";
            this.lblPanier.Size = new System.Drawing.Size(99, 33);
            this.lblPanier.TabIndex = 4;
            this.lblPanier.Text = "Panier";
            // 
            // btnAcheter
            // 
            this.btnAcheter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(86)))));
            this.btnAcheter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAcheter.Enabled = false;
            this.btnAcheter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAcheter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcheter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(208)))), ((int)(((byte)(192)))));
            this.btnAcheter.Location = new System.Drawing.Point(885, 411);
            this.btnAcheter.Name = "btnAcheter";
            this.btnAcheter.Size = new System.Drawing.Size(275, 80);
            this.btnAcheter.TabIndex = 6;
            this.btnAcheter.Text = "Acheter";
            this.btnAcheter.UseVisualStyleBackColor = false;
            // 
            // lblCategorie
            // 
            this.lblCategorie.AutoSize = true;
            this.lblCategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategorie.Location = new System.Drawing.Point(23, 23);
            this.lblCategorie.Name = "lblCategorie";
            this.lblCategorie.Size = new System.Drawing.Size(141, 33);
            this.lblCategorie.TabIndex = 0;
            this.lblCategorie.Text = "Categorie";
            // 
            // lblSoulignementCategorie
            // 
            this.lblSoulignementCategorie.AutoSize = true;
            this.lblSoulignementCategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoulignementCategorie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(208)))), ((int)(((byte)(192)))));
            this.lblSoulignementCategorie.Location = new System.Drawing.Point(23, 27);
            this.lblSoulignementCategorie.Name = "lblSoulignementCategorie";
            this.lblSoulignementCategorie.Size = new System.Drawing.Size(159, 33);
            this.lblSoulignementCategorie.TabIndex = 12;
            this.lblSoulignementCategorie.Text = "_________";
            // 
            // tbxRecherche
            // 
            this.tbxRecherche.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(86)))));
            this.tbxRecherche.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxRecherche.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(208)))), ((int)(((byte)(192)))));
            this.tbxRecherche.Location = new System.Drawing.Point(575, 32);
            this.tbxRecherche.MaxLength = 40;
            this.tbxRecherche.Multiline = true;
            this.tbxRecherche.Name = "tbxRecherche";
            this.tbxRecherche.Size = new System.Drawing.Size(213, 25);
            this.tbxRecherche.TabIndex = 3;
            this.tbxRecherche.Text = "C\'est du test tout ces lettres";
            // 
            // lblRecherche
            // 
            this.lblRecherche.AutoSize = true;
            this.lblRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecherche.Location = new System.Drawing.Point(446, 32);
            this.lblRecherche.Name = "lblRecherche";
            this.lblRecherche.Size = new System.Drawing.Size(123, 25);
            this.lblRecherche.TabIndex = 2;
            this.lblRecherche.Text = "Rechercher";
            // 
            // pbxRecherche
            // 
            this.pbxRecherche.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxRecherche.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxRecherche.Image = global::magasin.Properties.Resources.Search;
            this.pbxRecherche.Location = new System.Drawing.Point(785, 32);
            this.pbxRecherche.Name = "pbxRecherche";
            this.pbxRecherche.Size = new System.Drawing.Size(47, 25);
            this.pbxRecherche.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxRecherche.TabIndex = 16;
            this.pbxRecherche.TabStop = false;
            // 
            // frmMagasin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(1172, 774);
            this.Controls.Add(this.pbxRecherche);
            this.Controls.Add(this.lblRecherche);
            this.Controls.Add(this.tbxRecherche);
            this.Controls.Add(this.lblCategorie);
            this.Controls.Add(this.lblSoulignementCategorie);
            this.Controls.Add(this.btnAcheter);
            this.Controls.Add(this.lblPanier);
            this.Controls.Add(this.lblSoulignementPanier);
            this.Controls.Add(this.panelPanier);
            this.Controls.Add(this.panelProduit);
            this.Controls.Add(this.cbxCategories);
            this.Controls.Add(this.btnFrmLogin);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(208)))), ((int)(((byte)(192)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMagasin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Magasin";
            this.Load += new System.EventHandler(this.frmMagasin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantite)).EndInit();
            this.panelProduit.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panelPanier.ResumeLayout(false);
            this.gbxProduit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxRecherche)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFrmLogin;
        private System.Windows.Forms.ComboBox cbxCategories;
        private System.Windows.Forms.Button btnPanier;
        private System.Windows.Forms.NumericUpDown nudQuantite;
        private System.Windows.Forms.Panel panelProduit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pbxImage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblPrix;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panelPanier;
        private System.Windows.Forms.GroupBox gbxProduit;
        private System.Windows.Forms.Label lblProduitPanier;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblSoulignementPanier;
        private System.Windows.Forms.Label lblPanier;
        private System.Windows.Forms.Button btnAcheter;
        private System.Windows.Forms.Label lblCategorie;
        private System.Windows.Forms.Label lblSoulignementCategorie;
        private System.Windows.Forms.TextBox tbxRecherche;
        private System.Windows.Forms.Label lblRecherche;
        private System.Windows.Forms.PictureBox pbxRecherche;
    }
}

