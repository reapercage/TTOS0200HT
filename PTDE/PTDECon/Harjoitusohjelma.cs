using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTDECon
{
    class Harjoitusohjelma
    {
        private DateTime aloituspaiva;
        private string nimi = "Harjoitusohjelma"; // + counter 1
        private string currentTrainingDay;
        private string currentTrainingWeek;
        private int monijakoinen = 1;
        private List<bool[]> harjoituspäivät;
        private List<Harjoite> harjoite;

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
        public Harjoitusohjelma()
        {
            harjoituspäivät = new List<bool[]>();
            LisääHarjViikko();
            //for(int i = 0; i < 7; i++)
            //{
            //    harjoituspäivät[0][i] = false;
            //}
        }
        public bool OnkoHarjoituspäivä(int ind1, int ind2)
        {
            return harjoituspäivät[ind1][ind2];
        }
        public void LisääHarjViikko()
        {
            harjoituspäivät.Add(new bool[7]); 
        }
        public void PoistaHarjViikko(int index)
        {
            harjoituspäivät.RemoveAt(index);
        }
        public int LaskeHarjoitusviikot()
        {
            return harjoituspäivät.Count;
        }
    }
}
