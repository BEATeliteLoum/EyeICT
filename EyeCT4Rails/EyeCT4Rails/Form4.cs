using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EyeCT4Rails
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void lbMonteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            List<Tram> RepareerTrams = new List<Tram>();
            RepareerTrams.Add(new Tram(1, "11g", 100, 1, Status.Schoonmaak, 1));
            RepareerTrams.Add(new Tram(2, "11g", 100, 1, Status.Schoonmaak, 1));
            foreach (Tram t in RepareerTrams)
            {
                lbMonteur.Items.Add(t);
            }
        }
    }
}
