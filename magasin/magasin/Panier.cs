using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace magasin
{
    static class Panier
    {
        static public GroupBox AfficherPanier(string nomProduit, int nombreProduit, int position, frmMagasin magas){
            
            GroupBox gbxProduit = new GroupBox();
            Label lblProduitPanier = new Label();
            Button btnSupprimer = new Button();
            Label lblNbrPanier = new Label();

            #region gbxProduit
            gbxProduit.Controls.Add(lblProduitPanier);
            gbxProduit.Controls.Add(btnSupprimer);
            gbxProduit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            gbxProduit.Location = new System.Drawing.Point(7, position * 40 + 10);
            gbxProduit.Controls.Add(lblProduitPanier);
            gbxProduit.Controls.Add(lblNbrPanier);
            gbxProduit.Controls.Add(btnSupprimer);
            gbxProduit.Name = "gbx" + nomProduit;
            gbxProduit.Size = new System.Drawing.Size(267, 38);
            gbxProduit.TabIndex = 2;
            gbxProduit.TabStop = false;
            #endregion

            #region lblProduitPanier
            lblProduitPanier.Location = new System.Drawing.Point(6, 10);
            lblProduitPanier.Name = "lblProduitPanier";
            lblProduitPanier.Size = new System.Drawing.Size(127, 25);
            lblProduitPanier.TabIndex = 0;
            lblProduitPanier.Text = nomProduit;
            lblProduitPanier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            #endregion

            #region btnSupprimer
            btnSupprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(86)))));
            btnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnSupprimer.Location = new System.Drawing.Point(197, 10);
            btnSupprimer.Name = "btn" + nomProduit;
            btnSupprimer.Tag = nomProduit;
            btnSupprimer.Size = new System.Drawing.Size(64, 22);
            btnSupprimer.TabIndex = 1;
            btnSupprimer.Text = "X";
            btnSupprimer.UseVisualStyleBackColor = false;
            btnSupprimer.Click += magas.btnSupprimerArticle_Click;
            #endregion

            #region lblNbrPanier
            lblNbrPanier.Location = new System.Drawing.Point(139, 10);
            lblNbrPanier.Name = "lblNbrPanier" + nomProduit;
            lblNbrPanier.Size = new System.Drawing.Size(52, 25);
            lblNbrPanier.TabIndex = 0;
            lblNbrPanier.Text = " x" + nombreProduit.ToString();
            lblNbrPanier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            #endregion

            return gbxProduit;
        }
    }
}
