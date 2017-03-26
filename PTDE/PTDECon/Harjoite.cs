using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTDECon
{
    //harjoituskerta
    class Harjoite
    {
        private string nimi;
        private int paivacounter;
        private bool[] jako;
        private double lahtopainot;
        private bool autoPainojenMuutosD;
        private bool autoPainojenMuutosSarja;
        private double painojenMuutosD;
        private double painojenMuutosSarja;
        private int montaSarjaa;
        public List<Sarja> sarjat;
        private int index;

        public Harjoite()
        {
            paivacounter = 0;
            jako = new bool[7];
            lahtopainot = 0;
            painojenMuutosD = 0;
            painojenMuutosSarja = 0;
            montaSarjaa = 0;
            sarjat = new List<Sarja>();
            LisaaSarja();
        }
        //harjoitteen nimi listasta tai custom
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
        public int MontaSarjaa
        {
            get
            {
                return montaSarjaa;
            }
            set
            {
                montaSarjaa = value;
            }
        }
        public double Lahtopainot
        {
            get
            {
                return lahtopainot;
            }
            set
            {
                lahtopainot = value;
            }
        }
        public bool TarkistaOnkoHp(int index)
        {
            return jako[index];
        }
        public void AsetaJakoisuus(int jakoisuus)
        {
            jako = new bool[jakoisuus];
        }
        public void AsetaHarjoitusjako(int index)
        {
            jako[index] = true;
        }
        public void PoistaHarjoitusjako(int index)
        {
            jako[index] = false;
        }
        public double PainojenmuutosPerD
        {
            get
            {
                return painojenMuutosD;
            }
            set
            {
                painojenMuutosD = value;
            }
        }
        public double PainojenmuutosPerSarja
        {
            get
            {
                return painojenMuutosSarja;
            }
            set
            {
                painojenMuutosSarja = value;
            }
        }
        //public void reset
        //muuta sarjojen painoja
        //muuta sarjojen toistoja
        //tehdyt harjoituspäivät sarjoineen ja painoineen
        public void KerääSarjat()
        {
            
        }
        public void LisaaSarja()
        {
            Sarja srj = new Sarja();
            sarjat.Add(srj);
            montaSarjaa++;
        }
        public void PoistaSarja(int index, bool laskuri)
        {
            if(sarjat.Count > 1)
            {
                sarjat.RemoveAt(index);
                if(laskuri == false) montaSarjaa--;
            }
            //if vain yksi sarja, ei edes poista painiketta
        }
        public int LaskeSarjat()
        {
            return sarjat.Count;
        }
        public void TarkistaSarjaLkm(Harjoite hrj)
        {
            if (hrj.MontaSarjaa > hrj.sarjat.Count)
            {
                for (int i = 0; i < hrj.MontaSarjaa - hrj.sarjat.Count; i++)
                {
                    hrj.LisaaSarja();
                    hrj.montaSarjaa--;
                }
                //tallenna johonkin väliaikaisesti
            }
            else if (hrj.MontaSarjaa < hrj.sarjat.Count)
            {
                //tallenna johonkin väliaikaisesti ennen poistoa
                //oldSarjat = currentSarjat
                //jonka jälkeen
                for (int i = hrj.sarjat.Count; i > hrj.MontaSarjaa; i--)
                {
                    hrj.PoistaSarja(i - 1, true);
                }

            }
        }
        public void MuutaSarjaPainot(int index, double painot)
        {
            sarjat[index].Painot = painot;
        }
        public void MuutaSarjaToistot(int index, int toistot)
        {
            sarjat[index].Toistot = toistot;
        }
    }
    //wpf lista painojen korotuksista ja toistoista, oma luokka?
    class Sarja
    {
        private double painot;
        private int toistot;

        public Sarja()
        {
            painot = 0;
            toistot = 1;
        }
        public double Painot
        {
            get
            {
                return painot;
            }
            set
            {
                painot = value;
            }
        }
        public int Toistot
        {
            get
            {
                return toistot;
            }
            set
            {
                toistot = value;
            }
        }
    }
    class Painot
    {
        //korotus 1.25 * 2 * 4 = 10
    }
    class HarjoiteNimi
    {
        public string[] harjoitukset = new string[]
            { "Penkkipunnerrus", "Maastaveto", "Rinnalleveto",
            "Pystypunnerrus", "Ylätalja", "Alatalja",
            "Vatsalihakset", "Vatsalihaslaite", "Selkälihakset",
            "Soutulaite", "Reisilihaslaite", "Kääntölaite",
            "Käsipainot - hauis", "Käsipainot - hauiskääntö",
            "Käsipainot - pystypunnerrus", "Käsipainot - veto",
            "Tanko - hauikset", "Leukojenveto", "Custom" };
    }
}