using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCT4Rails
{
    class Rooster
    {
        public int ID { get; set; }
        public Dag Dag { get; set; }
        public DateTime Tijd { get; set; }
        public string TramType { get; set; }
        public RoosterType Type { get; set; }

        public Rooster(int _ID, Dag _Dag, DateTime _Tijd, string _TramType, RoosterType _Type)
        {
            ID = _ID;
            Dag = _Dag;
            Tijd = _Tijd;
            TramType = _TramType;
            Type = _Type;
        }
    }
}
