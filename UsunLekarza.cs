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
    public partial class UsunLekarza : Form
    {
        public UsunLekarza()
        {
            InitializeComponent();
            DataSet dataSet = new DataSet();
            dataSet.ReadXml("lekarze.xml");
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
            Lekarz lekarze = new Lekarz();
            XmlSerializer serializer3 = new XmlSerializer(lekarze.GetType());
            TextReader textReader = new StreamReader("lekarze.xml");
            lekarze = (Lekarz)serializer3.Deserialize(textReader);
            textReader.Close();

            int numer = dataGridView1.CurrentCell.RowIndex;
            lekarze.Remove(numer);


            XmlSerializer serializer1 = new XmlSerializer(lekarze.GetType());
            TextWriter textWriter1 = new StreamWriter("lekarze.xml");
            serializer1.Serialize(textWriter1, lekarze);
            textWriter1.Close();




            DataSet dataSet = new DataSet();
            dataSet.ReadXml("lekarze.xml");
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
    }
}
