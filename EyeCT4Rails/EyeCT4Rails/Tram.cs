using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCT4Rails
{
    public class Tram
    {
        public int ID { get; set; }
        public string Tramtype { get; set; }
        public int Lengte { get; set; }
        public int Lijn { get; set; }
        public Status Status { get; set; }
        public int Prioriteit { get; set; }

        public Tram(int _ID, string _Tramtype, int _Lengte, int _Lijn, Status _Status, int _Prioriteit)
        {
            ID = _ID;
            Tramtype = _Tramtype;
            Lengte = _Lengte;
            Lijn = _Lijn;
            Status = _Status;
            Prioriteit = _Prioriteit;
        }

        public bool StatusWijzigen(Status _Status, int _Prioriteit)
        {
            if (Status == _Status)
            {
                return false;
            }
            Status = _Status;
            Prioriteit = _Prioriteit;
            return true;
        }
    }
}
