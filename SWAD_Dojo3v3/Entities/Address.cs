using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAD_Dojo3v3.Entities
{
    class Address
    {

        String fname { get; set; }
        String lname { get; set; }
        String address { get; set; }
        String city { get; set; }
        int zip  { get; set; }



    public Address(String fname, String lname, String address, String city, int zip)
        {
            this.fname      = fname;
            this.lname      = lname;
            this.address    = address;
            this.city       = city;
            this.zip        = zip;  
        }


    }
}
