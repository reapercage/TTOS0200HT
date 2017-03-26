﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTDECon
{
    class Harjoitusohjelma
    {
        private DateTime aloituspaiva;
        private string nimi; // + counter 1
        private int currentTrainingDay = 1;
        private int currentTrainingWeek = 1;
        private int monijakoinen;
        private List<bool[]> harjoituspäivät;
        public List<Harjoite> harjoitteet;
        private int sarjaNroTemp = 0;
        //public void reset
        public Harjoitusohjelma()
        {
            aloituspaiva = DateTime.Today;
            nimi = "Harjoitusohjelma"; // counter +1
            harjoituspäivät = new List<bool[]>();
            LisääHarjoitusviikko();
            monijakoinen = 1;
            harjoitteet = new List<Harjoite>();
            Harjoite harjoite = new Harjoite();
            harjoitteet.Add(harjoite);
        }
        public string Nimi
        {
            get
            {
                return nimi;
            }
            set
            {
                nimi = value;
            }
        }
        //if monijakoinen = 3 => 1 : harjoite jako = 1, remember jako 3?
        public int Monijakoinen
        {
            get
            {
                return monijakoinen;
            }
            set
            {
                monijakoinen = value;
            }
        }
        public void Aloituspäivä()
        {
            Console.WriteLine(aloituspaiva);
        }
        public void AsetaAloituspäivä(DateTime ap)
        {
            aloituspaiva = ap;
        }

        //Harjoitusviikot
        public void LisääHarjoitusviikko()
        {
            harjoituspäivät.Add(new bool[7]);
        }
        public void PoistaHarjoitusviikko(int index)
        {
            if(harjoituspäivät.Count != 0)
            harjoituspäivät.RemoveAt(index);
        }
        public int LaskeHarjoitusviikot()
        {
            return harjoituspäivät.Count;
        }
        //Harjoituspäivät
        public void AsetaHarjoituspäivä(int ind1, int ind2)
        {
            harjoituspäivät[ind1][ind2] = true;
        }
        public void PoistaHarjoituspäivä(int ind1, int ind2)
        {
            harjoituspäivät[ind1][ind2] = false;
        }
        public bool OnkoHarjoituspäivä(int ind1, int ind2)
        {
            return harjoituspäivät[ind1][ind2];
        }
        //Harjoitteet
        //harjoitteiden selaus
        //tuple
        //http://stackoverflow.com/questions/748062/how-can-i-return-multiple-values-from-a-function-in-c
        public void NäytäHarjoitteet()
        {
            foreach(Harjoite h in harjoitteet)
            {
                sarjaNroTemp = 1;
                Console.WriteLine("Nimi: " + h.Nimi);
                Console.WriteLine("Harjoituspäivät: ");
                for(int i = 0; i < monijakoinen; i++)
                {
                    if(h.TarkistaOnkoHp(i))
                    {
                        Console.Write("[X]");
                    }
                    else
                    {
                        Console.Write("[ ]");
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Sarjojen lukumäärä: " + h.MontaSarjaa);
                foreach(Sarja s in h.sarjat)
                {
                    Console.WriteLine("Sarja " + sarjaNroTemp + ":");
                    Console.WriteLine("Painot: " + s.Painot
                                        + " Toistot: " + s.Toistot);
                    sarjaNroTemp++;
                }
            }
        }
        public void LisääHarjoite()
        {
            Harjoite harjoite = new Harjoite();
            harjoitteet.Add(harjoite);
        }
        public void PoistaHarjoite(int index)
        {
            if (harjoitteet.Count > 1)
                harjoitteet.RemoveAt(index);
        }
    }
}
