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
    public partial class UsunPielegniarke : Form
    {
        public UsunPielegniarke()
        {
            InitializeComponent();
            DataSet dataSet = new DataSet();
            dataSet.ReadXml("pielegniarki.xml");
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

        private void button2_Click(object sender, EventArgs e)
        {
            Pielegniarka pielegniarki = new Pielegniarka();
            XmlSerializer serializer4 = new XmlSerializer(pielegniarki.GetType());
            TextReader textReader2 = new StreamReader("pielegniarki.xml");
            pielegniarki = (Pielegniarka)serializer4.Deserialize(textReader2);
            textReader2.Close();
            int x = dataGridView1.CurrentCell.RowIndex;
            pielegniarki.Remove(x);

            XmlSerializer serializer2 = new XmlSerializer(pielegniarki.GetType());
            TextWriter textWriter2 = new StreamWriter("pielegniarki.xml");
            serializer2.Serialize(textWriter2, pielegniarki);
            textWriter2.Close();

            DataSet dataSet = new DataSet();
            dataSet.ReadXml("pielegniarki.xml");
            dataGridView1.DataSource = dataSet;
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void label12_Click(object sender, EventArgs e)
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
