using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Xml;

namespace Szpital
{
    public partial class Pielegniarka_D : Form
    {
        public Pielegniarka_D()
        {
            InitializeComponent();
           
          
               
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           


        }

        private void button1_Click(object sender, EventArgs e)
        {


            Pielegniarka pielegniarki = new Pielegniarka();
            XmlSerializer serializer4 = new XmlSerializer(pielegniarki.GetType());
            TextReader textReader2 = new StreamReader("pielegniarki.xml");
            pielegniarki = (Pielegniarka)serializer4.Deserialize(textReader2);
            textReader2.Close();

            user dane = new user();
            XmlSerializer serializer5 = new XmlSerializer(dane.GetType());
            TextReader textReader3 = new StreamReader("dane.xml");
            dane = (user)serializer5.Deserialize(textReader3);
            textReader3.Close();




            pielegniarki.DodajPielegniarke(box_imie.Text, Nazwisko_box.Text);
            dane.DodajDane(box_imie.Text, Nazwisko_box.Text, Login_Box.Text, Haslo_Box.Text);


            XmlSerializer serializer2 = new XmlSerializer(pielegniarki.GetType());
            TextWriter textWriter2 = new StreamWriter("pielegniarki.xml");
            serializer2.Serialize(textWriter2, pielegniarki);
            textWriter2.Close();


            XmlSerializer serializer = new XmlSerializer(dane.GetType());
            TextWriter textWriter = new StreamWriter("dane.xml");
            serializer.Serialize(textWriter, dane);
            textWriter.Close();
            MessageBox.Show("dodano");

           
         
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UsunPielegniarke f3 = new UsunPielegniarke();
            Hide();
            f3.ShowDialog();
            Close();
            Environment.Exit(1);

        
            
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
