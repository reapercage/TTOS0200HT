using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTDECon
{
    class Harjoituspaiva
    {
        private DateTime pvm;
        public DateTime Pvm
        {
            get
            {
                return pvm;
            }
            set
            {
                pvm = value;
            }
        }
        private int jakopv;
        private int sarjacounter;
        public List<Harjoite> HpHarjoitteet;
        private HarjoiteNimi harNimi;

        public Harjoituspaiva()
        {
            HpHarjoitteet = new List<Harjoite>();
            harNimi = new HarjoiteNimi();
        }
        public Harjoituspaiva(int jako, Harjoitusohjelma ha)
        {
            jakopv = jako;
            HpHarjoitteet = new List<Harjoite>();
            LisaaHjHarjoitteet(ha);
            harNimi = new HarjoiteNimi();
        }
        public void LisaaHarjoite()
        {
            Harjoite harjoite = new Harjoite();
            HpHarjoitteet.Add(harjoite);
        }
        public void PoistaHarjoite(int index)
        {
            if(HpHarjoitteet[index].OsaHarjohj == false)
            {
                HpHarjoitteet.RemoveAt(index);
            }
        }
        public void LisaaHjHarjoitteet(Harjoitusohjelma hao)
        {
            foreach (Harjoite h in hao.harjoitteet){
                //if(h.Jako[jakopv] == true && h.Aktiivinen == true)
                if(h.Jako[jakopv] == true)
                {
                    HpHarjoitteet.Add(h);
                }
            }
        }
        public void NäytäHarjoitteet()
        {
            foreach (Harjoite h in HpHarjoitteet)
            {
                sarjacounter = 1;
                Console.WriteLine(harNimi.Harjoitukset[h.Nimi]);
                foreach (Sarja s in h.Sarjat)
                {
                    Console.WriteLine("Sarja " + sarjacounter + ":");
                    Console.WriteLine("Painot " + s.Painot + "kg, " +
                        "toistot " + s.Toistot);
                    sarjacounter++;
                }
                Console.WriteLine();
                //Console.WriteLine("Lähtöpainot: " + h.Lahtopainot);
            }
        }
    }
}
