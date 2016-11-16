using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace magasin
{
    class Panier
    {
        public GroupBox AfficherPanier(string nomProduit, int nombreProduit, int i)
        {
            GroupBox gbxProduit = new GroupBox();
            Label lblProduitPanier = new Label();
            Button btnSupprimer = new Button();
            // 
            // gbxProduit
            // 
            gbxProduit.Controls.Add(lblProduitPanier);
            gbxProduit.Controls.Add(btnSupprimer);
            gbxProduit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            gbxProduit.Location = new System.Drawing.Point(7, 3);
            gbxProduit.Name = "gbxProduit";
            gbxProduit.Size = new System.Drawing.Size(267, 38);
            gbxProduit.TabIndex = 2;
            gbxProduit.TabStop = false;

            // 
            // lblProduitPanier
            // 
            lblProduitPanier.Location = new System.Drawing.Point(6, 10);
            lblProduitPanier.Name = "lblProduitPanier";
            lblProduitPanier.Size = new System.Drawing.Size(185, 25);
            lblProduitPanier.TabIndex = 0;
            lblProduitPanier.Text = "La tomate de fanfan x15";
            lblProduitPanier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // btnSupprimer
            // 
            btnSupprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(86)))));
            btnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnSupprimer.Location = new System.Drawing.Point(197, 10);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new System.Drawing.Size(64, 22);
            btnSupprimer.TabIndex = 1;
            btnSupprimer.Text = "X";
            btnSupprimer.UseVisualStyleBackColor = false;

            return gbxProduit;
        }
    }
}
