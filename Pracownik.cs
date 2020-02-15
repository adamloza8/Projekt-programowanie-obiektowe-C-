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
    [Serializable]
    public class Pracownik
    {
        public string imie;
        public string nazwisko;
       
        public Pracownik()
        {

        }

        public Pracownik(string new_nazwa, string new_nazwisko)
        {
            this.imie = new_nazwa;
            this.nazwisko = new_nazwisko;
           

        }
       

    }
}