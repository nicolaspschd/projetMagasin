using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace magasin
{
    public partial class frmMagasin : Form
    {
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
                btnFrmLogin.Text = FrmLogin.login;
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

        }
    }
}
