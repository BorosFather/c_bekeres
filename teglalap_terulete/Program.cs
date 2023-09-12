using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teglalap_terulete{

    internal class Program{


        static void Main(string[] args){

            Console.WriteLine("Teglalap terulet szamitas\n");
            Console.WriteLine("kerem adja meg a teglalap A es B oldalat");

            //ha csak write ot irunk akkor nincs sortores
            Console.Write("A oldal: ");
            string InaSide = Console.ReadLine();

            Console.Write("B oldal: ");
            string InbSide = Console.ReadLine();

            int aSide = int.Parse(InaSide);
            int bSide = int.Parse(InbSide);

            Console.WriteLine("teglalap terulete: {0}", aSide * bSide);

            Console.ReadKey();
        }
    }
}
