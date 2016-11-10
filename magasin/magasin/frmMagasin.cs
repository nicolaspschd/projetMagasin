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
        Sql requetteDB = new Sql();

        public Dictionary<string, int> panier = new Dictionary<string,int>();

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
                btnFrmLogin.Text = (FrmLogin.login == string.Empty)?"Login":FrmLogin.login;
            }
            else
            {
                DialogResult dr = MessageBox.Show("Voulez-vous vous déconnecter ?","Deconnexion",MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    btnFrmLogin.Text = "Login";
                }
            }
        }

        private void frmMagasin_Load(object sender, EventArgs e)
        {
            int i = 0;
            List<string> categories = requetteDB.selectCategories();
            while (i < categories.Count)
            {
                cbxCategories.Items.Add(categories[i]);
                i++;
            }
        }

        private void btnPanier_Click(object sender, EventArgs e)
        {
            panier.Add(((Button)(sender)).Tag.ToString(),
                (int)((NumericUpDown)this.Controls.Find("nud" + ((Button)(sender)).Tag.ToString(), true).FirstOrDefault()).Value);
        }

    }
}
