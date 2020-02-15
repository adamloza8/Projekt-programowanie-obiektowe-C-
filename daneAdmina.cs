using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace Szpital
{
    [XmlRoot("DaneSzpitala", IsNullable = false)]
    public class daneAdmina : Pracownik
    {

        [XmlElement]
        public List<daneAdmina> admini;
        public string login;
        public string haslo;
        public daneAdmina()
        {
            admini = new List<daneAdmina>();
        }

        public daneAdmina(string new_nazwa, string new_nazwisko, string new_login, string new_haslo) : base(new_nazwa, new_nazwisko)
        {

            this.login = new_login;
            this.haslo = new_haslo;

        }
        public void Remove(int Number)
        {
            admini.RemoveAt(Number);
        }

        public void DodajDaneA(string new_nazwa, string new_nazwisko, string new_login, string new_haslo)
        {
            daneAdmina daneLogowaniaA = new daneAdmina(new_nazwa, new_nazwisko, new_login, new_haslo);
            admini.Add(daneLogowaniaA);
        }
       
      
    }
}
