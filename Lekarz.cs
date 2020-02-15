using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using System.Collections;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace Szpital
{
    [XmlRoot("LekarzSzpitala")]
    public class Lekarz : Pracownik
    {

        [XmlElement]
        public List<Lekarz> lekarze;
        public string specjalizacja;
        public string numer_PWZ;

        
       

        public Lekarz()
        {
            lekarze = new List<Lekarz>();
        }
        public Lekarz(string new_numer_PWZ, string new_specjalizacja, string new_nazwa, string new_nazwisko)
            : base(new_nazwa, new_nazwisko)
        {
            this.numer_PWZ = new_numer_PWZ;
            this.specjalizacja = new_specjalizacja;
        }
       
        
        public void DodajLekarza(string new_numer_PWZ, string new_specjalizacja, string new_nazwa, string new_nazwisko)
        {
            Lekarz lekarz = new Lekarz(new_numer_PWZ,new_specjalizacja,new_nazwa,new_nazwisko);
            lekarze.Add(lekarz);
        }
        public void Remove(int Number)
        {
            lekarze.RemoveAt(Number);
        }
    }


}
