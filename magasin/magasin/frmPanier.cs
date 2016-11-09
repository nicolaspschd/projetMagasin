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
    public partial class frmPanier : Form
    {
        frmMagasin magas;

        public frmPanier()
        {
            InitializeComponent();
        }

        private void frmPanier_Load(object sender, EventArgs e)
        {
            int i = 0;
            magas = (frmMagasin)this.Owner;
            
            while (i <= magas.panier.Count())
            {
                i++;
                Console.WriteLine(magas.panier.ElementAt(i));
                lsbListPanier.Items.Add(magas.panier.ElementAt(i).Key + "  x " + magas.panier.ElementAt(i).Value);
            }
        }
    }
}
