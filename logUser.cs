using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Xml;
using System.Web;
using System.Xml.Linq;
using System.Data;

namespace Szpital
{
    public partial class logUser : Form
    {
        public logUser()
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

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

            private void button1_Click(object sender, EventArgs e)
        {

          
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
