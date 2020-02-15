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
    public class user:Pracownik
    {
       
        [XmlArrayItem("DaneLogowania", typeof(user), IsNullable = false)]
        public List<user> dane;
        public string login;
        public string haslo;
        public user()
        {
            dane = new List<user>();
        }

        public user(string new_nazwa, string new_nazwisko, string new_login, string new_haslo):base(new_nazwa, new_nazwisko)
        {
           
            this.login = new_login;
            this.haslo = new_haslo;

        }
    
        public void DodajDane(string new_nazwa, string new_nazwisko, string new_login, string new_haslo)
        {
            user daneLogowania = new user(new_nazwa, new_nazwisko, new_login, new_haslo);
            dane.Add(daneLogowania);
        }
       

    }
}
