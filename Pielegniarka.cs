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
    [XmlRoot("PielegniarkiSzpitala")]
    public class Pielegniarka : Pracownik
    {
        [XmlElement]
        public List<Pielegniarka> pielegniarki;
      

        public Pielegniarka()
        {
            pielegniarki = new List<Pielegniarka>();

        }
        public Pielegniarka(string new_nazwa, string new_nazwisko)
            : base(new_nazwa, new_nazwisko)
        {
          
        }

        public void Remove(int Number)
        {
            pielegniarki.RemoveAt(Number);
        }

        public void DodajPielegniarke(string new_nazwa, string new_nazwisko)
        {
            Pielegniarka pielegniarka = new Pielegniarka(new_nazwa, new_nazwisko);
            pielegniarki.Add(pielegniarka);
        }
    }
}