using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAD_Dojo3v3.Entities
{
    public class Currency
    {
        public String name { get; set;}
        public Double oneUnitInEUR {   get; set;}
        

        public Currency(String name, Double oneUnitInEUR)
        {
            this.name = name;
            this.oneUnitInEUR = oneUnitInEUR;
        }
    }
}
