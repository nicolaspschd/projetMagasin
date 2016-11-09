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
            this.lblPanier = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantite)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFrmLogin
            // 
            this.btnFrmLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(86)))));
            this.btnFrmLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFrmLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFrmLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(208)))), ((int)(((byte)(192)))));
            this.btnFrmLogin.Location = new System.Drawing.Point(12, 12);
            this.btnFrmLogin.Name = "btnFrmLogin";
            this.btnFrmLogin.Size = new System.Drawing.Size(121, 23);
            this.btnFrmLogin.TabIndex = 1;
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
            this.cbxCategories.Location = new System.Drawing.Point(12, 41);
            this.cbxCategories.Name = "cbxCategories";
            this.cbxCategories.Size = new System.Drawing.Size(164, 21);
            this.cbxCategories.TabIndex = 2;
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
            this.nudQuantite.Location = new System.Drawing.Point(3, 3);
            this.nudQuantite.Name = "nudQuantite";
            this.nudQuantite.Size = new System.Drawing.Size(180, 20);
            this.nudQuantite.TabIndex = 4;
            // 
            // lblPanier
            // 
            this.lblPanier.AutoSize = true;
            this.lblPanier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(86)))));
            this.lblPanier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPanier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPanier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(208)))), ((int)(((byte)(192)))));
            this.lblPanier.Location = new System.Drawing.Point(139, 17);
            this.lblPanier.Name = "lblPanier";
            this.lblPanier.Size = new System.Drawing.Size(39, 15);
            this.lblPanier.TabIndex = 6;
            this.lblPanier.Text = "Panier";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(12, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(995, 501);
            this.panel1.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.92537F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.07462F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 191F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(23, 21);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(846, 123);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.92537F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(232, 5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(415, 113);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "La tomate de fanfan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "1.56CHF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(401, 39);
            this.label3.TabIndex = 2;
            this.label3.Text = "La tomate est une espèce de plantes herbacées de la famille des Solanacées, origi" +
    "naire du Nord-Ouest de l\'Amérique du Sud, largement cultivée pour son fruit. Le " +
    "terme désigne aussi ce fruit charnu.";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.nudQuantite, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnPanier, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(655, 5);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.8938F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.10619F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(186, 113);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // 
            // frmMagasin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(1019, 645);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblPanier);
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
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFrmLogin;
        private System.Windows.Forms.ComboBox cbxCategories;
        private System.Windows.Forms.Button btnPanier;
        private System.Windows.Forms.NumericUpDown nudQuantite;
        private System.Windows.Forms.Label lblPanier;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}

