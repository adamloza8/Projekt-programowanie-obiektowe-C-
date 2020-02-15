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
    public partial class Administrator_D : Form
    {
        public Administrator_D()
        {

            InitializeComponent();
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            daneAdmina admini = new daneAdmina();
            XmlSerializer seria1 = new XmlSerializer(admini.GetType());
            TextReader read1 = new StreamReader("admini.xml");
            admini = (daneAdmina)seria1.Deserialize(read1);
            read1.Close();

          
                admini.DodajDaneA(box_imie.Text, Nazwisko_box.Text, Login_Box.Text, Haslo_Box.Text);



                XmlSerializer seria2 = new XmlSerializer(admini.GetType());
                TextWriter read2 = new StreamWriter("admini.xml");
                seria2.Serialize(read2, admini);
                read2.Close();
                MessageBox.Show("dodano pomyślnie");

                  
              
             
        }

       

    

        private void Powrot_Click(object sender, EventArgs e)
        {
            logAdmin f3 = new logAdmin();
            Hide();
            f3.ShowDialog();
            Close();
            Environment.Exit(1);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UsunAdministratora f3 = new UsunAdministratora();
            Hide();
            f3.ShowDialog();
            Close();
            Environment.Exit(1);
        }
    }
}
