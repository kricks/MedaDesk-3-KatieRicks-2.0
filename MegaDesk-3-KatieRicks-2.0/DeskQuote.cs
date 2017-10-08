using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_KatieRicks_2._0
{
    class DeskQuote
    {
        //constants
        const decimal BASE_DESK_PRICE = 200.00m;
        const decimal DESKTOP_SURFACE_AREA = 1.00m;
        const decimal DRAWERS = 50.00m;
        const decimal OAK = 200.00m;
        const decimal LAMINATE = 100.00m;
        const decimal PINE = 50.00m;
        const decimal ROSEWOOD = 300.00m;
        const decimal VENEER = 125.00m;
        const decimal RUSH_3DAY_LESS_THAN_1000 = 60.00m;
        const decimal RUSH_3DAY_1000_TO_2000 = 70.00m;
        const decimal RUSH_3DAY_GREATER_THAN_2000 = 80.00m;
        const decimal RUSH_5DAY_LESS_THAN_1000 = 40.00m;
        const decimal RUSH_5DAY_1000_TO_2000 = 50.00m;
        const decimal RUSH_5DAY_GREATER_THAN_2000 = 60.00m;
        const decimal RUSH_7DAY_LESS_THAN_1000 = 30.00m;
        const decimal RUSH_7DAY_1000_TO_2000 = 35.00m;
        const decimal RUSH_7DAY_GREATER_THAN_2000 = 40.00m;

        //enums
        public enum Delivery
        {
            Rush3Days,
            Rush5Days,
            Rush7Days,
            Normal14Days
        }

        //properties
        public Desk desk { get; set; }
        public string customerName { get; set; }
        public DateTime QuoteDate { get; set; }
        public Delivery DeliveryType { get; set; }
        public decimal QuoteAmount { get; set; }
    }
}
