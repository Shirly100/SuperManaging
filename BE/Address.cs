﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public struct Address
    {
        public int HouseNumber { get; set; }
        public int Floor { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }

        public override string ToString()
        {

            string result = "Address:'\n'";
            result += "-------\n";
            result += Street + " ";
            result += HouseNumber + " "+",";
            result += "Floor" + " " + Floor + '\n';
            result += ZipCode + " ";
            result += City + '\n';
            result += Country+ '\n';
            return result;

        }
        public string ToAddress()
        {
            string ad = Street + ", " + HouseNumber + ", " + City + ", " + Country;
            return ad;
        }

    }
}
