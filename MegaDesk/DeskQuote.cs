using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{

    public enum ShippingType
    {
        Rush3Day, 
        Rush5Day,
        Rush7Day,
        NoRush
    }
    class DeskQuote
    {
        public int RushDays { get; set; }
        public string CustomerName { get; set; }
        public DateTime QuoteDate { get; set; }
        public decimal QuoteAmount { get; set; }
        public ShippingType ShippingType { get; set; }

        // hold the logic in determining the desk quote total
    }
}
