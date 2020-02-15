using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Xml;

namespace Szpital
{
    public partial class UsunAdministratora : Form
    {
        public UsunAdministratora()
        {
            InitializeComponent();
            DataSet dataSet = new DataSet();
            dataSet.ReadXml("admini.xml");
            dataGridView1.DataSource = dataSet;
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            U_Imie.Text = selectedRow.Cells[0].Value.ToString();
            U_Nazwisko.Text = selectedRow.Cells[1].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            daneAdmina admini = new daneAdmina();
            XmlSerializer serializer4 = new XmlSerializer(admini.GetType());
            TextReader textReader2 = new StreamReader("admini.xml");
            admini = (daneAdmina)serializer4.Deserialize(textReader2);
            textReader2.Close();
            int x = dataGridView1.CurrentCell.RowIndex;
            admini.Remove(x);

            XmlSerializer serializer2 = new XmlSerializer(admini.GetType());
            TextWriter textWriter2 = new StreamWriter("admini.xml");
            serializer2.Serialize(textWriter2, admini);
            textWriter2.Close();

            DataSet dataSet = new DataSet();
            dataSet.ReadXml("admini.xml");
            dataGridView1.DataSource = dataSet;
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void Powrot_Click(object sender, EventArgs e)
        {
            logAdmin f3 = new logAdmin();
            Hide();
            f3.ShowDialog();
            Close();
            Environment.Exit(1);
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
