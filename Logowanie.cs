using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Xml;
using System.Web;


using System.Windows.Forms;

namespace Szpital
{
    public partial class Logowanie : Form
    {
        public Logowanie()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void login_text_Click(object sender, EventArgs e)
        {

        }

        private void login_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void zaloguj_button_Click(object sender, EventArgs e)
        {

            user dane = new user();
            XmlSerializer serializer5 = new XmlSerializer(dane.GetType());
            TextReader textReader3 = new StreamReader("dane.xml");
            dane = (user)serializer5.Deserialize(textReader3);
            textReader3.Close();

            daneAdmina admini = new daneAdmina();
            XmlSerializer serializer10 = new XmlSerializer(admini.GetType());
            TextReader textReader10 = new StreamReader("admini.xml");
            admini = (daneAdmina)serializer10.Deserialize(textReader10);
            textReader10.Close();


            XmlDocument doc = new XmlDocument();
            doc.Load("dane.xml");
            foreach(XmlNode node in doc.SelectNodes("//DaneLogowania"))
            {
                String login = node.SelectSingleNode("login").InnerText;
                String haslo = node.SelectSingleNode("haslo").InnerText;
                String imie = node.SelectSingleNode("imie").InnerText;
                String nazwisko = node.SelectSingleNode("nazwisko").InnerText;

                if (login ==login_box.Text && haslo == password_box.Text)
                {
                    MessageBox.Show("Zalogowano jako "+ imie + " "+ nazwisko);
                    logUser f2 = new logUser();
                    Hide();
                    f2.ShowDialog();
                    Close();

                }
                
                
            }


            XmlDocument doc1 = new XmlDocument();
            doc1.Load("admini.xml");
            foreach (XmlNode node in doc1.SelectNodes("//admini"))
            {
                String login = node.SelectSingleNode("login").InnerText;
                String haslo = node.SelectSingleNode("haslo").InnerText;
                String imie = node.SelectSingleNode("imie").InnerText;
                String nazwisko = node.SelectSingleNode("nazwisko").InnerText;

                if (login == login_box.Text && haslo == password_box.Text)
                {
                    MessageBox.Show("Zalogowano administratora " + imie + " " + nazwisko);
                    logAdmin f2 = new logAdmin();
                    Hide();
                    f2.ShowDialog();
                    Close();

                }


            }


            MessageBox.Show("Podałeś błędne dane");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    }

