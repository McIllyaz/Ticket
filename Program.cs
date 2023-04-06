using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMemberClass
{
    public class Program
    {
        static void Main(string[] args)
        {
            PlaneTicket satu = new PlaneTicket();
            PlaneTicket dua = new PlaneTicket();

            satu.Origin = "JGJ";
            satu.Destination = "PKU";
            satu.Cost = 100;
            satu.Currency = "(USD)";
            satu.PrintSummary();

            Console.WriteLine();

            dua.Origin = "JKT";
            dua.Destination = "PKU";
            dua.Cost = 750000;
            dua.Currency = "(IDR)";

            dua.PrintSummary();
            Console.ReadKey();
        }
    }
}
