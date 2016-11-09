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
            magas = this.Owner as frmMagasin;
            Console.WriteLine(panier.ElementAt(0));

            /*while (i < magas.panier.Count())
            {
                
                lsbListPanier.Items.Add(magas.panier.ElementAt(i).Key + "  x " + magas.panier.ElementAt(i).Value);
                i++;
            }*/
        }
    }
}
