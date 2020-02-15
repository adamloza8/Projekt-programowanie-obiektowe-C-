using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szpital
{
    public partial class logAdmin : Form
    {
        public logAdmin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


   

        private void button4_Click(object sender, EventArgs e)
        {

        }

 

        private void Dodaj_lekarzaBTN_Click(object sender, EventArgs e)
        {
            Lekarz_D f2 = new Lekarz_D();
            Hide();
            f2.ShowDialog();
            Close();
        }

        private void Dodaj_pielęgniarkeBTN_Click(object sender, EventArgs e)
        {
            Pielegniarka_D f2 = new Pielegniarka_D();
            Hide();
            f2.ShowDialog();
            Close();
        }

        private void Dodaj_adminaBTN_Click(object sender, EventArgs e)
        {

            Administrator_D f2 = new Administrator_D();
            Hide();
            f2.ShowDialog();
            Close();
        }

        private void ZalogowanoAdmina_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Wszyscy f2 = new Wszyscy();
            Hide();
            f2.ShowDialog();
            Close();
        }
    }
}
