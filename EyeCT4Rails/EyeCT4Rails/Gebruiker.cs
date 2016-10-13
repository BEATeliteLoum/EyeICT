using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCT4Rails
{
    class Gebruiker
    {
        public int ID { get; set; }
        public string Naam { get; set; }
        public Functie Functie { get; set; }
        
        public Gebruiker(int _ID, string _Naam, Functie _Functie)
        {
            ID = _ID;
            Naam = _Naam;
            Functie = _Functie;
        }
    }
}
