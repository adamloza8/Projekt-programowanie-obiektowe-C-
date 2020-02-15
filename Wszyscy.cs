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
    public partial class Wszyscy : Form
    {
        public Wszyscy()
        {
            InitializeComponent();
            DataSet dataSet2 = new DataSet();
            dataSet2.ReadXml("lekarze.xml");
            dataGridView1.DataSource = dataSet2;
            dataGridView1.DataSource = dataSet2.Tables[0];

            DataSet dataSet1 = new DataSet();
            dataSet1.ReadXml("pielegniarki.xml");
            dataGridView2.DataSource = dataSet1;
            dataGridView2.DataSource = dataSet1.Tables[0];

            DataSet dataSet = new DataSet();
            dataSet.ReadXml("admini.xml");
            dataGridView3.DataSource = dataSet;
            dataGridView3.DataSource = dataSet.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Powrot_Click(object sender, EventArgs e)
        {
            logAdmin f3 = new logAdmin();
            Hide();
            f3.ShowDialog();
            Close();
            Environment.Exit(1);
        }
    }
}
