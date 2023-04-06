using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMemberClass
{
    public class PlaneTicket
    {
        public string Origin { get; set; }
        public string Destination { get; set; }
        public int Cost { get; set; }
        public string Currency { get; set; }

        public void PrintSummary()
        {
            Console.WriteLine("Origin\t\t\t: {0}", Origin);
            Console.WriteLine("Destination\t\t: {0}", Destination);
            Console.WriteLine("Cost\t\t\t: {0} {1}", Cost, Currency);

            if (Currency == "(USD)")
            {
                Console.WriteLine("Convert to Rupiah\t: {0} ", (Cost * 15000));
            }
            else if (Currency == "(IDR)")
            {
                Console.WriteLine("Convert to Dollar\t: {0} ", Cost / 15000);
            }
        }


    }
}
