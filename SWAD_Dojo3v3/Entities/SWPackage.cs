using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAD_Dojo3v3.Entities
{
    public class SWPackage
    {
        public String name { get; set; }
        public String group { get; set; }
        public Decimal salesPrice { get; set; }
        public Decimal purchasePrice { get; set; }
        public int onStock { get; set; }

        public SWPackage(String name, String group, Decimal salesPrice, Decimal purchasePrice, int onStock)
        {
            this.name = name;
            this.group = group;
            this.salesPrice = salesPrice;
            this.purchasePrice = purchasePrice;
            this.onStock = onStock;
        }


    }
}
