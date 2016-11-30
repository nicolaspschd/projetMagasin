using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace magasin
{
    static class Sql
    {
        static MySqlConnection connectionDB = new MySqlConnection("server=10.134.96.109;database=magasin;user=MagasinUser;password=fondue;");
        static MySqlCommand cmd;

        static List<string> _nomProduits = new List<string>();
        static List<string> _prixProduits = new List<string>();
        static List<string> _descriptionProduits = new List<string>();
        static List<string> _lienImageProduits = new List<string>();

        public static List<string> PrixProduits
        {
            get { return Sql._prixProduits; }
            set { Sql._prixProduits = value; }
        }

        public static List<string> DescriptionProduits
        {
            get { return Sql._descriptionProduits; }
            set { Sql._descriptionProduits = value; }
        }

        public static List<string> NomProduits
        {
            get { return Sql._nomProduits; }
            set { Sql._nomProduits = value; }
        }

        public static List<string> LienImageProduits
        {
            get { return Sql._lienImageProduits; }
            set { Sql._lienImageProduits = value; }
        }

        const string SELECTMDPUSER = "SELECT mdpUser FROM utilisateurs WHERE loginUser=@login";
        const string SELECTLOGINUSER = "SELECT loginUser FROM utilisateurs WHERE loginUser=@login";
        const string SELECTCATEGORIES = "SELECT * FROM categories";
        const string SELECTPRODUIT = "SELECT nomProduits, prix, description, lienImage FROM produits WHERE idCategorie = @categorie";
        const string INSERTUSER = "INSERT INTO utilisateurs(loginUser, mdpUser) VALUES(@login, @mdp)";
        const string SELECTSEARCHBAR = "SELECT nomProduits,prix,description,lienImage FROM produits WHERE nomProduits LIKE '%@search%'";

        static public bool conOK()
        {
            bool open = false;

            connectionDB.Open();

            if (connectionDB.State == System.Data.ConnectionState.Open)
            {
                open = true;
            }

            connectionDB.Close();
            return open;
        }

        static public string getSha1(string text)
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

        static public bool selectMdpUser(string mdp, string login, Label lbl)
        {
            bool loguer = false;
            cmd = new MySqlCommand(SELECTMDPUSER, connectionDB);

            cmd.Parameters.AddWithValue("@login", login);

            try
            {
                connectionDB.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                //  Si le mot de passe et le login sont les même que dans la db
                while (reader.Read())
                {
                    if (reader.GetValue(0).ToString() == getSha1(mdp))
                    {
                        //  On l'autorise a se logger
                        MessageBox.Show("Vous êtes loguer", ":)", MessageBoxButtons.OK);
                        loguer = true;

                    }
                    else
                    {
                        lbl.Text = "Il y a eu un problème";
                        loguer = false;
                    }
                }
            }
            catch (Exception)
            {
                lbl.Text = "Il y a eu un problème";
                loguer = false;
            }

            connectionDB.Close();

            return loguer;
        }

        static public bool selectLoginUser(string login, string mdp, bool mdpConfirm)
        {
            bool resultat = false;

            cmd = new MySqlCommand(SELECTLOGINUSER, connectionDB);
            cmd.Parameters.AddWithValue("@login", login);

            connectionDB.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                if (reader[0].ToString() == login)
                {
                    //  On lui demande de recommencer
                    resultat = false;
                    MessageBox.Show("Login existant, veuillez en inserez un autre.", "Oups", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (mdpConfirm && (login != string.Empty))
                {
                    connectionDB.Close();

                    cmd = new MySqlCommand(INSERTUSER, connectionDB);
                    cmd.Parameters.AddWithValue("@login", login);
                    cmd.Parameters.AddWithValue("@mdp", getSha1(mdp));

                    connectionDB.Open();

                    //  Si la connexion et la requête s'est executée correctement s'est bien passée
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        //  L'utilisateur est inscrit
                        MessageBox.Show("Vous êtes désormais inscrit !", "Oui !", MessageBoxButtons.OK);
                        resultat = true;
                        connectionDB.Close();
                    }
                }
                else
                {
                    resultat = false;
                    MessageBox.Show("Veuillez rentrez un nom d'utilisateur valide et un mot de passe", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            connectionDB.Close();

            return resultat;
        }

        static public List<string> selectCategories()
        {
            cmd = new MySqlCommand(SELECTCATEGORIES, connectionDB);
            List<string> categories = new List<string>();
            try
            {
                connectionDB.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    categories.Add(reader.GetValue(0).ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            connectionDB.Close();
            return categories;
        }

        static public void selectProduits(string categorie)
        {
            NomProduits.Clear();
            PrixProduits.Clear();
            DescriptionProduits.Clear();
            LienImageProduits.Clear();

            cmd = new MySqlCommand(SELECTPRODUIT, connectionDB);

            cmd.Parameters.AddWithValue("@categorie", categorie);

            try
            {
                connectionDB.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        NomProduits.Add(reader.GetString(0));
                        PrixProduits.Add(reader.GetString(1));
                        DescriptionProduits.Add(reader.GetString(2));
                        LienImageProduits.Add(reader.GetString(3));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            connectionDB.Close();
        }

        static public void selectProduit(string search)
        {
            NomProduits.Clear();
            PrixProduits.Clear();
            DescriptionProduits.Clear();
            LienImageProduits.Clear();

            cmd = new MySqlCommand("SELECT nomProduits,prix,description,lienImage FROM produits WHERE nomProduits LIKE '%"+search+"%'", connectionDB);
            try
            {
                connectionDB.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        NomProduits.Add(reader.GetString(0));
                        PrixProduits.Add(reader.GetString(1));
                        DescriptionProduits.Add(reader.GetString(2));
                        LienImageProduits.Add(reader.GetString(3));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            connectionDB.Close();
        }
    }
}
