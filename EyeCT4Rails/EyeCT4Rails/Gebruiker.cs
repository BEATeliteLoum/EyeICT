using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace EyeCT4Rails
{
    public class Gebruiker
    {
        public int ID { get; set; }
        public string Naam { get; set; }
        public Functie Functie { get; set; }
        public string Gebruikersnaam { get; set; }
        public string Wachtwoord { get; set; }

        
        public Gebruiker(int _ID, string _Naam, Functie _Functie)
        {
            ID = _ID;
            Naam = _Naam;
            Functie = _Functie;
        }

        public Gebruiker()
        {
            Gebruikersnaam = "Admin";
            Wachtwoord = "Admin";
        }

        public bool Login(string _Gebruikersnaam, string _Wachtwoord)
        {
            if (Gebruikersnaam == _Gebruikersnaam && Wachtwoord == _Wachtwoord)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
