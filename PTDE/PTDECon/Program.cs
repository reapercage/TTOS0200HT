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
            //Testisyöte
            //Lisää harjoite button, toimii
            hj1.LisääHarjoite();
            //Lisää sarja button, toimii
            hj1.harjoitteet[0].LisaaSarja();
            hj1.harjoitteet[0].LisaaSarja();
            hj1.harjoitteet[0].LisaaSarja();
            //Monta sarjaa Droplist, toimii
            hj1.harjoitteet[0].MontaSarjaa = 3;
            //Poista sarja button, toimii
            hj1.harjoitteet[0].PoistaSarja(hj1.harjoitteet[0].sarjat.Count - 1, false);
            //Monta sarjaa Droplist2, toimii
            hj1.harjoitteet[0].TarkistaSarjaLkm(hj1.harjoitteet[0]);
            //Aseta harjoituspäivä click toimii
            hj1.AsetaHarjoituspäivä(0, 0);
            hj1.AsetaHarjoituspäivä(0, 2);
            hj1.AsetaHarjoituspäivä(0, 5);
            //Poista harjoituspäivä click toimii
            hj1.PoistaHarjoituspäivä(0, 5);
            hj1.AsetaHarjoituspäivä(0, 4);
            hj1.AsetaHarjoituspäivä(0, 6);
            //Lisää harjoitusviikko

            //method siirrä harjoituspäivä
            //hj1.AsetaAloituspäivä(2017-03-23);
            //hj1.Nimi = "empty";



            //Tulostus
            Console.WriteLine("Harjoitusohjelma\n----------------");
            Console.WriteLine("\nNimi: " + hj1.Nimi );
            Console.WriteLine("Aloituspäivä: ");
            hj1.Aloituspäivä();
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
            Console.WriteLine("\n\nHarjoitteet:");
            hj1.NäytäHarjoitteet();
            Console.ReadKey();
        }
    }
}
