using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTDECon
{
    class Program2
    {
        static void Main(string[] args)
        {
            Harjoitusohjelma hj1 = new Harjoitusohjelma();

            //Aseta harjoitusohjelman nimi, toimii
            hj1.Nimi = "Schwarzeneggerin 6 osainen";
            //Aseta harjoitusohjelman jakoisuus toimii
            hj1.Monijakoinen = 2;
            //Lisää harjoite, valitse harjoite ja jako
            hj1.LisääHarjoite();
            hj1.harjoitteet[0].Nimi = 0;
            hj1.harjoitteet[0].AsetaHarjoitusjako(0);
            hj1.LisääHarjoite();
            hj1.harjoitteet[1].Nimi = 1;
            hj1.harjoitteet[1].AsetaHarjoitusjako(0);
            hj1.LisääHarjoite();
            hj1.harjoitteet[2].Nimi = 2;
            hj1.harjoitteet[2].AsetaHarjoitusjako(0);
            hj1.LisääHarjoite();
            hj1.harjoitteet[3].Nimi = 3;
            hj1.harjoitteet[3].AsetaHarjoitusjako(1);
            hj1.LisääHarjoite();
            hj1.harjoitteet[4].Nimi = 4;
            hj1.harjoitteet[4].AsetaHarjoitusjako(1);
            hj1.LisääHarjoite();
            hj1.harjoitteet[5].Nimi = 5;
            hj1.harjoitteet[5].AsetaHarjoitusjako(1);

            //Aseta harjoituspäivät toimii
            hj1.LisääHarjoitusviikko();
            hj1.AsetaHarjoituspäivä(0, 0);
            hj1.AsetaHarjoituspäivä(0, 2);
            hj1.AsetaHarjoituspäivä(0, 4);
            hj1.AsetaHarjoituspäivä(0, 6);
            hj1.AsetaHarjoituspäivä(1, 1);
            hj1.AsetaHarjoituspäivä(1, 3);
            hj1.AsetaHarjoituspäivä(1, 5);

            //Asetetaan harjoitusohjelma aktiiviseksi
            hj1.Aktiivinen = true;
            //Aloituspäivä
            hj1.Aloituspaiva = new DateTime(2017, 6, 19);

            //Tulostus
            Console.WriteLine("Harjoitusohjelma\n----------------");
            Console.WriteLine("\nNimi: " + hj1.Nimi);
            Console.WriteLine("Aloituspäivä: ");
            Console.WriteLine(hj1.Aloituspaiva.ToString("dd. MMMM yyyy"));
            Console.WriteLine("Monijakoinen: " + hj1.Monijakoinen);
            Console.WriteLine("Harjoituspäivät:");
            for (int k = 0; k < hj1.LaskeHarjoitusviikot(); k++)
            {
                for (int i = 0; i < 7; i++)
                {
                    if (hj1.OnkoHarjoituspäivä(k, i))
                    {
                        Console.Write("[x]");
                    }
                    else
                    {
                        Console.Write("[ ]");
                    }
                }
                Console.Write("\n");
            }
            Console.WriteLine("\n\nHarjoitteet:");
            hj1.NäytäHarjoitteet();

            Console.Clear();

            //Harjoituspäivän tulostus
            Console.WriteLine("Harjoituspäivä ");
            //harjoituspäivän jakosysteemi ratkaisematta
            Harjoituspaiva hp1 = new Harjoituspaiva(1, hj1);
            //DateTime hppvm = new DateTime(2017, 6, 19);
            DateTime hppvm = DateTime.Today;
            hp1.Pvm = hppvm;
            Console.WriteLine(hp1.Pvm.ToString("dd. MMMM yyyy\n------------------"));
            hp1.HpHarjoitteet[0].LisaaSarja();
            hp1.HpHarjoitteet[0].Sarjat[0].Painot = 20;
            hp1.HpHarjoitteet[0].Sarjat[0].Toistot = 10;
            hp1.HpHarjoitteet[0].LisaaSarjaAiemmanPohjalta();

            hp1.LisaaHarjoite();
            //lisää vain tälle päivälle / pysyvästi

            hp1.NäytäHarjoitteet();
            
            Console.ReadKey();
        }
    }
}
