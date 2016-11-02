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
        
        MySqlConnection connectionDB = new MySqlConnection("server=127.0.0.1;database=magasin;user=root;password=;");
        MySqlCommand cmd;

        frmMagasin magas = new frmMagasin();
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string sql = "SELECT mdpUser FROM utilisateurs WHERE loginUser=@login";
            cmd = new MySqlCommand(sql, connectionDB);

            cmd.Parameters.AddWithValue("@login", tbxLogin.Text);

            try
            {
                connectionDB.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                //  Si le mot de passe et le login sont les même que dans la db
                while (reader.Read())
                {
                    if (reader.GetValue(0).ToString() == getSha1(tbxMdp.Text))
                    {
                        //  On l'autorise a se logger
                        login = tbxLogin.Text;
                        Console.WriteLine(reader[0]);
                        lblAvert.Text = "Vous êtes loguer !";
                    }
                    else
                    {
                        lblAvert.Text = "Erreur, veuillez réessayer";
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Il y a eu un problème", "Erreur", MessageBoxButtons.OK);
            }
            
            connectionDB.Close();
            
            if (login != string.Empty)
            {
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

                //  Desactive btnLogin
                btnLogin.Visible = false;

                //  Initialisation des paramètres de la nouvelle TextBox
                tbxNativ.Name = "tbxMdpConfirm";
                tbxNativ.Location = new Point(tbxMdp.Location.X, tbxMdp.Location.Y + 25);
                tbxNativ.Size = tbxMdp.Size;
                tbxNativ.PasswordChar = '*';
                tbxNativ.TabIndex = 2;
                tbxNativ.TextChanged += this.tbxMdp_TextChanged;

                //  Initialisation des paramètres du nouveau Label
                lblNativ.Text = "Confirmer le MDP";
                lblNativ.Location = new Point(lblMdpInfo.Location.X, tbxNativ.Location.Y);

                //  Ajout des nouveaux controls
                this.Controls.Add(tbxNativ);
                this.Controls.Add(lblNativ);
                #endregion
            }
            else
            {
                string requete = "SELECT loginUser FROM utilisateurs WHERE loginUser=@login";

                //  Préparation de la requête
                cmd = new MySqlCommand(requete, connectionDB);
                cmd.Parameters.AddWithValue("@login", tbxLogin.Text);

                connectionDB.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                //  Si il y a quelque chose en retour dans la base
                if (reader.Read())
                {
                    //  Si le login est déjà dans la base de donnée
                    if (reader[0].ToString() == tbxLogin.Text)
                    {
                        //  On lui demande de recommencer
                        MessageBox.Show("Login existant, veuillez en inserez un autre.", "Oups", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (mdpConfimation && tbxLogin.Text != string.Empty)
                    {
                        //  Fermeture de la connexion
                        connectionDB.Close();

                        //  Préparation de la requête
                        requete = "INSERT INTO utilisateurs(loginUser, mdpUser) VALUES(@login, @mdp)";

                        //  Envois de la requête à la base de données
                        cmd = new MySqlCommand(requete, connectionDB);
                        cmd.Parameters.AddWithValue("@login", tbxLogin.Text);
                        cmd.Parameters.AddWithValue("@mdp", getSha1(tbxMdp.Text));

                        connectionDB.Open();

                        //  Si la connexion et la requête s'est executée correctement s'est bien passée
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            //  L'utilisateur est inscrit
                            MessageBox.Show("Vous êtes désormais inscrit !", "Oui !", MessageBoxButtons.OK);
                            connectionDB.Close();
                            //  Connexion à l'application
                            btnLogin.PerformClick();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Veuillez rentrez un nom d'utilisateur valide et un mot de passe non vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                connectionDB.Close();
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
                    lblAvert.Text = "Le mot de passe ne correspond pas";
                    mdpConfimation = false;
                }
                else
                {
                    if (tbxMdp.Text != string.Empty)
                    {
                        //  Sinon, on dit ok
                        lblAvert.Text = "Pas de soucis";
                        mdpConfimation = true;
                    }
                    else
                    {
                        lblAvert.Text = string.Empty;
                        mdpConfimation = false;
                    }
                }
            }
        }

        public string getSha1(string text)
        {
            byte[] resultat;
            StringBuilder stringBuild = new StringBuilder();
            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();

            sha1.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));
            resultat = sha1.Hash;

            foreach (var carac in resultat)
            {
                stringBuild.Append(carac.ToString("x2"));
            }

            return stringBuild.ToString();
        }
    }
}