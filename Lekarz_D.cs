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
    public partial class Lekarz_D : Form
    {
        public Lekarz_D()
        {
            InitializeComponent();
              
           
        }

   

        private void button1_Click(object sender, EventArgs e)
        {
            user dane = new user();
            XmlSerializer serializer5 = new XmlSerializer(dane.GetType());
            TextReader textReader3 = new StreamReader("dane.xml");
            dane = (user)serializer5.Deserialize(textReader3);
            textReader3.Close();
           

                Lekarz lekarze = new Lekarz();
                XmlSerializer serializer3 = new XmlSerializer(lekarze.GetType());
                TextReader textReader = new StreamReader("lekarze.xml");
                lekarze = (Lekarz)serializer3.Deserialize(textReader);
                textReader.Close();
              

                    lekarze.DodajLekarza(pzxbox.Text, Specjalizacja_Box.Text, imie_Box.Text, Nazwisko_box.Text);
                    dane.DodajDane(imie_Box.Text, Nazwisko_box.Text, Login_Box.Text, Haslo_Box.Text);

                    XmlSerializer serializer1 = new XmlSerializer(lekarze.GetType());
                    TextWriter textWriter1 = new StreamWriter("lekarze.xml");
                    serializer1.Serialize(textWriter1, lekarze);
                    textWriter1.Close();

                    XmlSerializer serializer = new XmlSerializer(dane.GetType());
                    TextWriter textWriter = new StreamWriter("dane.xml");
                    serializer.Serialize(textWriter, dane);
                    textWriter.Close();
                    MessageBox.Show("dodano pomyślnie");


        }
    
            private void label2_Click(object sender, EventArgs e)
            {

            }
        private void button2_Click(object sender, EventArgs e)
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

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            UsunLekarza f3 = new UsunLekarza();
            Hide();
            f3.ShowDialog();
            Close();
            Environment.Exit(1);
        }
    }
    }

