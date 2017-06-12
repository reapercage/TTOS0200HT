using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTDECon
{
    class Program
    {
        static void Main1(string[] args)
        {
            bool[] hp = new bool[7];
            Harjoitusohjelma hj1 = new Harjoitusohjelma();
            //Testisyöte
            //Aseta harjoitusohjelman nimi, toimii
            hj1.Nimi = "Schwarzeneggerin 6 osainen";
            //Aseta harjoitusohjelman jakoisuus toimii
            hj1.Monijakoinen = 2;
            //Lisää harjoite, toimii
            hj1.LisääHarjoite();
            //Lisää sarja, toimii
            hj1.harjoitteet[0].LisaaSarja();
            hj1.harjoitteet[0].LisaaSarja();
            hj1.harjoitteet[0].LisaaSarja();
            //Monta sarjaa Droplist, toimii
            hj1.harjoitteet[0].MontaSarjaa = 3;
            //Poista sarja, toimii
            hj1.harjoitteet[0].PoistaSarja(hj1.harjoitteet[0].sarjat.Count - 1, false);
            hj1.harjoitteet[0].MontaSarjaa = 3;
            //Monta sarjaa Droplist2, toimii
            hj1.harjoitteet[0].TarkistaSarjaLkm(hj1.harjoitteet[0]);

            //Poista harjoite
            //Nollaa harjoitusohjelma tyhjäksi

            //Aseta ja poista harjoitusjako, toimii
            //Kun harjoitusohjelman jakoisuutta muutetaan, muuttuvat myös
            //harjoitteiden jakoisuudet
            //Aseta jakoisuus voidaan korvata myös bool[16]
            //ja jakoisuudet näkyvät ja ovat käytössä hj1.Monijakoinen mukaan
            
            //lisää harjoite jakoisuus check, (turha?)
            hj1.JakoisuusCheck();
            //Jakoisuudet erikseen kullekkin harjoitteelle?
            //hj1.harjoitteet[0].AsetaJakoisuus(hj1.Monijakoinen);
            //hj1.harjoitteet[1].AsetaJakoisuus(hj1.Monijakoinen);

            //AsetaHarjoitusjako, toimii
            hj1.harjoitteet[0].AsetaHarjoitusjako(0);
            hj1.harjoitteet[0].AsetaHarjoitusjako(1);
            //PoistaHarjoitusjako, toimii
            hj1.harjoitteet[0].PoistaHarjoitusjako(1);
            hj1.harjoitteet[1].AsetaHarjoitusjako(1);
            //jakoisuutta muuttaessa pitäisi muistaa vanhat merkinnät?
            //hj1.Monijakoinen = 1;
            //Harjoitus aktiivinen - ei ?

            //Aseta harjoituspäivä click toimii
            hj1.AsetaHarjoituspäivä(0, 0);
            hj1.AsetaHarjoituspäivä(0, 2);
            hj1.AsetaHarjoituspäivä(0, 5);
            //Poista harjoituspäivä click toimii
            hj1.PoistaHarjoituspäivä(0, 5);
            hj1.AsetaHarjoituspäivä(0, 4);
            hj1.AsetaHarjoituspäivä(0, 6);
            //Lisää harjoitusviikko toimii
            hj1.LisääHarjoitusviikko();
            hj1.AsetaHarjoituspäivä(1, 1);
            hj1.AsetaHarjoituspäivä(1, 3);
            hj1.AsetaHarjoituspäivä(1, 5);
            hj1.LisääHarjoitusviikko();
            //Poista harjoitusviikko toimii
            hj1.PoistaHarjoitusviikko(2);

            //method siirrä harjoituspäivä
            //Aseta aloituspäivä

            //Asetetaan harjoitusohjelma aktiiviseksi
            hj1.Aktiivinen = true;
            //Aseta lähtöpainot
            hj1.harjoitteet[0].Lahtopainot = 10;
            //Muuta sarjojen painoja
            //hj1.harjoitteet[0].MuutaSarjaPainot(0, 10);
            //3 sarjaa tällä hetkellä
            //Automaattinen painojen muutos per sarja, toimii
            //custom painojen muutos algoritmi
            hj1.harjoitteet[0].PainojenmuutosPerSarja = 2.5;
            //PainoCheck tarkastaa painot kullekkin harjoituspäivälle, toimii
            hj1.harjoitteet[0].PainoCheck(0);
            //Automaattinen painojen muutos pois, toimii
            //hj1.harjoitteet[0].PainojenmuutosPerSarja = 0;
            //hj1.harjoitteet[0].PainoCheck(0);
            //Automaattinen painojenmuutos per päivä, toimii
            hj1.harjoitteet[0].PainojenmuutosPerD = 2.5;
            hj1.harjoitteet[0].PainoCheck(0);
            //Painojenmuutos per päivä pois, toimii
            hj1.harjoitteet[0].PainojenmuutosPerD = 0;
            hj1.harjoitteet[0].PainoCheck(3);

            //Muuta sarjojen toistoja
            //Tallenna käsinsyötetyt toistomäärät sarjoille
            hj1.harjoitteet[0].sarjat[0].Toistot = 10;
            hj1.harjoitteet[0].sarjat[1].Toistot = 7;
            hj1.harjoitteet[0].sarjat[2].Toistot = 5;
            //Automaattinen toistojenmuutos per sarja



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
            Console.WriteLine("\n\n\n\n");
            Console.WriteLine("Harjoituspäivä + numero:");
            Console.WriteLine("Harjoitteet:");
            Console.ReadKey();
            //muuta tilapäisesti painoja/toistoja
            //muuta pysyvästi painoja/toistoja
        }
    }
}
