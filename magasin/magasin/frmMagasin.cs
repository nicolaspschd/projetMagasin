/*
 * Auteur : Paschoud Nicolas, en cooperation avec Marco Vlajkovic
 * Nom du programme : Magasin
 * Description : Magasin en ligne
 * Date : 31 Août 2016
 * Version : 1.0
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace magasin
{
    public partial class frmMagasin : Form
    {
        public Dictionary<string, int> panier = new Dictionary<string, int>();
        int nbrPanier = 0;

        public frmMagasin()
        {
            InitializeComponent();
        }
        private void btnFrmLogin_Click(object sender, EventArgs e)
        {
            frmLogin FrmLogin = new frmLogin();

            if (btnFrmLogin.Text == "Login")
            {
                FrmLogin.ShowDialog();
                btnFrmLogin.Text = (FrmLogin.login == string.Empty) ? "Login" : FrmLogin.login;
            }
            else
            {
                DialogResult dr = MessageBox.Show("Voulez-vous vous déconnecter ?", "Deconnexion", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    btnFrmLogin.Text = "Login";
                }
            }
        }

        private void frmMagasin_Load(object sender, EventArgs e)
        {
            panelPanier.Controls.Clear();
            int i = 0;
            List<string> categories = Sql.selectCategories();
            while (i < categories.Count)
            {
                cbxCategories.Items.Add(categories[i]);
                i++;
            }
            cbxCategories.SelectedIndex = 0;
        }

        public void btnPanier_Click(object sender, EventArgs e)
        {
            string nomArticle = (sender as Button).Tag.ToString();
            int nbrArticle = Convert.ToInt32(((this.Controls.Find("nudQuantite" + (sender as Button).Tag.ToString(), true).FirstOrDefault()) as NumericUpDown).Value);
            
            if (!panier.ContainsKey(nomArticle))
            {
                panier.Add(nomArticle, nbrArticle);
                panelPanier.Controls.Add(Panier.AfficherPanier(nomArticle, nbrArticle, nbrPanier));
                nbrPanier++;
            }
            else
            {
                panier[nomArticle] = nbrArticle;
            }
        }

        private void cbxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxCategories.Enabled = false;
            panelProduit.Controls.Clear();

            Sql.selectProduits(cbxCategories.SelectedItem.ToString());

            for (int i = 0; i < Sql.NomProduits.Count; i++)
            {
                panelProduit.Controls.Add(Article.AfficherArticle(Sql.NomProduits[i], Sql.PrixProduits[i], Sql.DescriptionProduits[i], Sql.LienImageProduits[i], this, i));
            }
            cbxCategories.Enabled = true;
            panelProduit.Focus();
        }

        public void panelProduit_Click(object sender, EventArgs e)
        {
            panelProduit.Focus();
        }
    }
}
