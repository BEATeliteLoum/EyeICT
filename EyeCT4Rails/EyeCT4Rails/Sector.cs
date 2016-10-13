using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCT4Rails
{
    class Sector
    {
        public int ID { get; set; }
        public int Lengte { get; set; }
        public int Spoor { get; set; }
        public bool Blokkeren { get; set; }

        public Sector(int _ID, int _Lengte, int _Spoor, bool _Blokkeren)
        {
            ID = _ID;
            Lengte = _Lengte;
            Spoor = _Spoor;
            Blokkeren = _Blokkeren;
        }

        public bool BlokkeerSector(bool _Blokkeer)
        {
            if (this.Blokkeren == true)
            {
                return false;
            }
            Blokkeren = true;
            return true;
        }
    }
}
