using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EyeCT4Rails
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //maak een gebruiker aan met de inloggegevens.
            Gebruiker login = new Gebruiker();
            //kijk of de tekstvelden niet leeg zijn.
            if (tbGebruikersnaam.Text == "" || tbWachtwoord.Text == "")
            {
                //Geef een foutmelding dat niet alle velden zijn ingevuld.
                MessageBox.Show("U heeft niet alle velden ingevuld.");
            }
            else
            {
                // roep de functie aan om te kijken of de inloggegevens juist zijn.
                if (login.Login(tbGebruikersnaam.Text, tbWachtwoord.Text))
                {
                    //Roep form2 aan en close form1.
                    Form2 form2 = new Form2();
                    this.Hide();
                    form2.ShowDialog();
                    this.Close();
                }
                else
                {
                    //Geef een foutmelding dat de inloggegevens onjuist zijn.
                    MessageBox.Show("De inloggegevens zijn onjuist.");
                }
            }
        }
    }
}
