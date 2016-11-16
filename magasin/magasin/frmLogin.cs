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
using System.Security.Cryptography;
using MySql.Data.MySqlClient;

namespace magasin
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        bool mdpConfimation = false;
        public string login = string.Empty;


        frmMagasin magas = new frmMagasin();
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Sql.selectMdpUser(tbxMdp.Text, tbxLogin.Text,lblAvert)) 
            {
                Console.WriteLine("login");
                login = tbxLogin.Text;

                this.Close();
            }
        }

        private void btnInscription_Click(object sender, EventArgs e)
        {
            //  Si l'interface d'inscription n'est pas
            if (this.Controls.Find("tbxMdpConfirm", true).Count() == 0)
            {
                #region Création lbl + tbx
                TextBox tbxNativ = new TextBox();
                Label lblNativ = new Label();
                Color fondCouleur = new Color();
                Color textCouleur = new Color();
                fondCouleur = Color.FromArgb( 78, 78, 86);
                textCouleur = Color.FromArgb(220, 208, 192);

                //  Desactive btnLogin
                btnLogin.Visible = false;

                //  Initialisation des paramètres de la nouvelle TextBox
                tbxNativ.Name = "tbxMdpConfirm";
                tbxNativ.BackColor = fondCouleur;
                tbxNativ.ForeColor = textCouleur;
                tbxNativ.BorderStyle = BorderStyle.FixedSingle;
                tbxNativ.Font = new Font("Microsoft Sans Serif", 12);
                tbxNativ.Location = new Point(tbxMdp.Location.X, tbxMdp.Location.Y + 32);
                tbxNativ.Size = tbxMdp.Size;
                tbxNativ.PasswordChar = '*';
                tbxNativ.TabIndex = 2;
                tbxNativ.TextChanged += this.tbxMdp_TextChanged;

                //  Initialisation des paramètres du nouveau Label
                lblNativ.Text = "Confirmer le MDP";
                lblNativ.Width = 115;
                lblNativ.ForeColor = textCouleur;
                lblNativ.Font = new Font("Microsoft Sans Serif", 9.75f);
                lblNativ.Location = new Point(lblMdpInfo.Location.X, tbxNativ.Location.Y);

                //  Ajout des nouveaux controls
                this.Controls.Add(tbxNativ);
                this.Controls.Add(lblNativ);
                #endregion
            }
            else
            {
                if (Sql.selectLoginUser(tbxLogin.Text, tbxMdp.Text, mdpConfimation))
                {
                    btnLogin_Click(null, null);
                    Console.WriteLine("inscrit");
                }
            }
        }

        private void tbxMdp_TextChanged(object sender, EventArgs e)
        {
            string mdpConfirm = string.Empty;

            //  Si le composant "tbxMdpConfirm" existe
            if (this.Controls.Find("tbxMdpConfirm", false).Count() != 0)
            {
                //  On récupère le contenu de la tbx
                mdpConfirm = (this.Controls.Find("tbxMdpConfirm", false).ElementAt(0) as TextBox).Text;

                //  On test si les 2 mots de passe sont ok
                if (tbxMdp.Text != mdpConfirm)
                {
                    //  Si non, on affiche erreur
                    lblAvert.Text = "Les mots de passe ne correspond pas";
                    mdpConfimation = false;
                }
                else
                {
                    //  Sinon, on dit ok
                    if (tbxMdp.Text != string.Empty)
                    {
                        lblAvert.Text = "Mot de passe : ✔";
                        mdpConfimation = true;
                        if (tbxLogin.Text != string.Empty)
                        {
                            lblAvert.Text = "Login : ✔\nMot de passe : ✔";
                        }
                    }
                    else
                    {
                        lblAvert.Text = string.Empty;
                        mdpConfimation = false;
                    }
                }
            }
        }
    }
}