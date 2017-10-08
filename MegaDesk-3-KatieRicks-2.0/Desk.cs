using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_KatieRicks_2._0
{
    class Desk
    {
        public int deskWdith { get; set; }
        public int deskDepth { get; set; }
        public int numOfDrawers { get; set; }
        public deskMaterial material { get; set; }

        //desk object constructor


        //enum
        public enum deskMaterial
        {
            Oak,
            Laminate,
            Pine,
            Rosewood,
            Veneer
        }
    }
}
