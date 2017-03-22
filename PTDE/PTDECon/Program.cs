using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTDECon
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] hp = new bool[7];
            Harjoitusohjelma hj1 = new Harjoitusohjelma();
            hj1.Nimi = "empty";
            Console.WriteLine("Harjoitusohjelma\n----------------");
            Console.WriteLine("\nNimi: " + hj1.Nimi );
            Console.WriteLine("Monijakoinen: " + hj1.Monijakoinen);
            Console.WriteLine("Harjoituspäivät:");
            for (int k = 0; k < hj1.LaskeHarjoitusviikot(); k++)
            {
                for (int i = 0; i < 7; i++)
                {
                    if (hj1.OnkoHarjoituspäivä(0, i))
                    {
                        Console.Write("[x]");
                    }
                    else
                    {
                        Console.Write("[ ]");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
