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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            List<Tram> SchoonmaakTrams = new List<Tram>();
            SchoonmaakTrams.Add( new Tram(1, "11g", 100, 1, Status.Schoonmaak, 1 ));
            SchoonmaakTrams.Add(new Tram(2, "11g", 100, 1, Status.Schoonmaak, 1));
            foreach (Tram t in SchoonmaakTrams)
            {
                lbSchoonmaak.Items.Add(t);
            }
        }
    }
}
