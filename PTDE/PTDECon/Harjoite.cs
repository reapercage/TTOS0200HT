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
        private int nimi;
        public int Nimi
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
        private int paivacounter;
        private bool aktiivinen;
        public bool Aktiivinen
        {
            get
            {
                return aktiivinen;
            }
            set
            {
                aktiivinen = value;
            }
        }
        private bool[] jako;
        public bool[] Jako
        {
            get{ return jako; }
        }
        private bool osaHarjohj;
        public bool OsaHarjohj
        {
            get
            {
                return osaHarjohj;
            }
            set
            {
                osaHarjohj = value;
            }
        }
        private bool skip;
        public bool Skip
        {
            get
            {
                return skip;
            }
            set
            {
                skip = value;
            }
        }

        private double lahtopainot;
        private bool autoPainojenMuutosD;
        private bool autoPainojenMuutosSarja;
        private double painojenMuutosD;
        private double painojenMuutosSarja;
        private double painojenMuutosSarjaTemp;
        private bool autoMuutosSarja;
        private int montaSarjaa;
        public List<Sarja> Sarjat;
        private int index;

        public Harjoite()
        {
            paivacounter = 0;
            jako = new bool[7];
            lahtopainot = 0;
            painojenMuutosD = 0;
            painojenMuutosSarja = 0;
            montaSarjaa = 0;
            Sarjat = new List<Sarja>();
            //LisaaSarja();
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
            Sarjat.Add(srj);
            montaSarjaa++;
        }
        public void LisaaSarjaAiemmanPohjalta()
        {
            Sarja srj = new Sarja();
            srj.Toistot = Sarjat[Sarjat.Count() - 1].Toistot;
            srj.Painot = Sarjat[Sarjat.Count() - 1].Painot;
            Sarjat.Add(srj);
            montaSarjaa++;
        }
        public void PoistaSarja(int index, bool laskuri)
        {
            if(Sarjat.Count > 1)
            {
                Sarjat.RemoveAt(index);
                if(laskuri == false) montaSarjaa--;
            }
            //if vain yksi sarja, ei edes poista painiketta
        }
        public int LaskeSarjat()
        {
            return Sarjat.Count;
        }
        public void TarkistaSarjaLkm(Harjoite hrj)
        {
            if (hrj.MontaSarjaa > hrj.Sarjat.Count)
            {
                for (int i = 0; i < hrj.MontaSarjaa - hrj.Sarjat.Count; i++)
                {
                    hrj.LisaaSarja();
                    hrj.montaSarjaa--;
                }
                //tallenna johonkin väliaikaisesti
            }
            else if (hrj.MontaSarjaa < hrj.Sarjat.Count)
            {
                //tallenna johonkin väliaikaisesti ennen poistoa
                //oldSarjat = currentSarjat
                //jonka jälkeen
                for (int i = hrj.Sarjat.Count; i > hrj.MontaSarjaa; i--)
                {
                    hrj.PoistaSarja(i - 1, true);
                }

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
        public void LahtopainoCheck()
        {

        }
        public double PainojenmuutosPerSarja
        {
            get
            {
                return painojenMuutosSarja;
            }
            set
            {
                painojenMuutosSarjaTemp = painojenMuutosSarja;
                painojenMuutosSarja = value;
            }
        }
        //Sarjojen painojen muutos aiemman sarjan perusteella
        public int Paivacounter
        {
            get
            {
                return paivacounter;
            }
            set
            {
                paivacounter = Paivacounter;
            }
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
        public void PainoCheck(int trainingday)
        {
            foreach (Sarja s in Sarjat)
            {
                for(int i = 0; i < Sarjat.Count; i++)
                {
                    MuutaSarjaPainot(i, lahtopainot + painojenMuutosD * trainingday + i * painojenMuutosSarja);
                }
            }
        }
        public void MuutaSarjaPainot(int index, double painot)
        {
            Sarjat[index].Painot = painot;
            //if (index == 0) lahtopainot = painot;
            if (index > 0) autoMuutosSarja = false;
        }
        //Toistot
        private int lahtotoistot;
        private int toistojenMuutosD;
        private int toistojenMuutosSarja;
        private int[] toistoMuutosSarjaTaulu;
        public int Lahtotoistot
        {
            get
            {
                return lahtotoistot;
            }
            set
            {
                lahtotoistot = value;
            }
        }
        public int ToistoMuutosSarja
        {
            get
            {
                return toistojenMuutosSarja;
            }
            set
            {
                toistojenMuutosSarja = value;
            }
        }
        public void MuutaSarjaToistot(int index, int toistot)
        {
            Sarjat[index].Toistot = toistot;
        }
        public void ToistoCheck(int trainingday)
        {
            foreach (Sarja s in Sarjat)
            {
                for (int i = 0; i < Sarjat.Count; i++)
                {
                    MuutaSarjaToistot(i, lahtotoistot + toistojenMuutosD * trainingday + i * toistojenMuutosSarja);
                }
            }
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
            toistot = 0;
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
        public readonly string[] Harjoitukset = new string[]
            { "Penkkipunnerrus", "Maastaveto", "Rinnalleveto",
            "Pystypunnerrus", "Ylätalja", "Alatalja",
            "Vatsalihakset", "Vatsalihaslaite", "Selkälihakset",
            "Soutulaite", "Reisilihaslaite", "Kääntölaite",
            "Käsipainot - hauis", "Käsipainot - hauiskääntö",
            "Käsipainot - pystypunnerrus", "Käsipainot - veto",
            "Tanko - hauikset", "Leukojenveto", "Custom" };
        public HarjoiteNimi()
        {

        }
    }
}