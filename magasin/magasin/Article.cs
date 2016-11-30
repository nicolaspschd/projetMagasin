using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace magasin
{
   static class Article
    {
        static public TableLayoutPanel AfficherArticle(string nom, string prix, string description, string image, frmMagasin frm,int position)
        {
            #region Initialisation
            TableLayoutPanel tlpArticle = new TableLayoutPanel();
            PictureBox pbxImage = new PictureBox();
            TableLayoutPanel tlpInformationArticle = new TableLayoutPanel();
            Label lblTitre = new Label();
            Label lblPrix = new Label();
            TableLayoutPanel tlpGestionPanier = new TableLayoutPanel();
            Button btnPanier = new Button();
            Label lblDescription = new Label();
            NumericUpDown nudQuantite = new NumericUpDown();
            prix = (Math.Round(Convert.ToDecimal(prix) / 0.05m, 0) * 0.05m).ToString();
            #endregion

            #region Table Layout Panel Article
            // Article
            tlpArticle.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            tlpArticle.ColumnCount = 3;
            tlpArticle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.92537F));
            tlpArticle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.07462F));
            tlpArticle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 206F));
            tlpArticle.Controls.Add(pbxImage, 0, 0);
            tlpArticle.Controls.Add(tlpInformationArticle, 1, 0);
            tlpArticle.Controls.Add(tlpGestionPanier, 2, 0);
            tlpArticle.Location = new System.Drawing.Point(0, position*150+14);
            tlpArticle.Name = "Article"+nom;
            tlpArticle.Tag = nom;
            tlpArticle.RowCount = 1;
            tlpArticle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpArticle.Size = new System.Drawing.Size(846, 123);
            tlpArticle.TabIndex = 2;
            tlpArticle.Click += frm.panelProduit_Click;
            #endregion

            #region Picture Box Image
            // pbxImage
            pbxImage.Image = FTPdownloader.Download(image);
            pbxImage.Location = new System.Drawing.Point(5, 5);
            pbxImage.Name = "pbxImage"+nom;
            pbxImage.Tag = nom;
            pbxImage.Size = new System.Drawing.Size(214, 113);
            pbxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pbxImage.TabIndex = 0;
            pbxImage.TabStop = false;
            pbxImage.Click += frm.panelProduit_Click;
            #endregion

            #region Table Layout Panel Information Article
            // InformationArticle
            tlpInformationArticle.ColumnCount = 1;
            tlpInformationArticle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.92537F));
            tlpInformationArticle.Controls.Add(lblTitre, 0, 0);
            tlpInformationArticle.Controls.Add(lblPrix, 0, 1);
            tlpInformationArticle.Controls.Add(lblDescription, 0, 2);
            tlpInformationArticle.Location = new System.Drawing.Point(227, 5);
            tlpInformationArticle.Name = "InformationArticle"+nom;
            tlpInformationArticle.Tag = nom;
            tlpInformationArticle.RowCount = 3;
            tlpInformationArticle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpInformationArticle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            tlpInformationArticle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            tlpInformationArticle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpInformationArticle.Size = new System.Drawing.Size(405, 113);
            tlpInformationArticle.TabIndex = 3;
            tlpInformationArticle.Click += frm.panelProduit_Click;
            #endregion

            #region lblTitre
            // lblTitre
            lblTitre.AutoSize = true;
            lblTitre.Location = new System.Drawing.Point(3, 0);
            lblTitre.Name = "lblTitre"+nom;
            lblTitre.Tag = nom;
            lblTitre.Size = new System.Drawing.Size(102, 13);
            lblTitre.TabIndex = 0;
            lblTitre.Text = nom;
            lblTitre.Click += frm.panelProduit_Click;
            #endregion

            #region lblPrix
            // lblPrix
            lblPrix.AutoSize = true;
            lblPrix.Location = new System.Drawing.Point(3, 23);
            lblPrix.Name = "lblPrix"+nom;
            lblPrix.Tag = nom;
            lblPrix.Size = new System.Drawing.Size(49, 13);
            lblPrix.TabIndex = 1;
            lblPrix.Text = String.Format("{0:0.00}", Convert.ToDecimal(prix)) +" CHF";
            lblPrix.Click += frm.panelProduit_Click;
            #endregion

            #region lblDescription
            // lblDescription
            lblDescription.AutoSize = true;
            lblDescription.Location = new System.Drawing.Point(3, 49);
            lblDescription.Name = "lblDescription"+nom;
            lblDescription.Tag = nom;
            lblDescription.Size = new System.Drawing.Size(398, 39);
            lblDescription.TabIndex = 2;
            lblDescription.Text = description;
            lblDescription.Click += frm.panelProduit_Click;
            #endregion

            #region Table Layout Panel GestionPanier
            // GestionPanier
            tlpGestionPanier.ColumnCount = 1;
            tlpGestionPanier.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpGestionPanier.Controls.Add(nudQuantite, 0, 0);
            tlpGestionPanier.Controls.Add(btnPanier, 0, 1);
            tlpGestionPanier.Location = new System.Drawing.Point(640, 5);
            tlpGestionPanier.Name = "GestionPanier"+nom;
            tlpGestionPanier.Tag = nom;
            tlpGestionPanier.RowCount = 2;
            tlpGestionPanier.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.8938F));
            tlpGestionPanier.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.10619F));
            tlpGestionPanier.Size = new System.Drawing.Size(186, 113);
            tlpGestionPanier.TabIndex = 4;
            tlpGestionPanier.Click += frm.panelProduit_Click;
            #endregion

            #region nudQuantite
            // nudQuantite
            nudQuantite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(86)))));
            nudQuantite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nudQuantite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(208)))), ((int)(((byte)(192)))));
            nudQuantite.Location = new System.Drawing.Point(3, 3);
            nudQuantite.Name = "nudQuantite"+nom;
            nudQuantite.Tag = nom;
            nudQuantite.Size = new System.Drawing.Size(180, 22);
            nudQuantite.TabIndex = 4;
            nudQuantite.Tag = "1";
            nudQuantite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            #endregion

            #region btnPanier
            // btnPanier
            btnPanier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(86)))));
            btnPanier.Cursor = System.Windows.Forms.Cursors.Hand;
            btnPanier.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnPanier.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnPanier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(208)))), ((int)(((byte)(192)))));
            btnPanier.Location = new System.Drawing.Point(3, 29);
            btnPanier.Name = "btnPanier"+nom;
            btnPanier.Tag = nom;
            btnPanier.Size = new System.Drawing.Size(180, 81);
            btnPanier.TabIndex = 5;
            btnPanier.Text = "Ajouter au panier";
            btnPanier.UseVisualStyleBackColor = false;
            btnPanier.Click += frm.btnPanier_Click;
            #endregion

            return tlpArticle;
        }
    }
}
