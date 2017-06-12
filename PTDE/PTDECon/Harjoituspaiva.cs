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
        private int jakopv;
        public List<Harjoite> HpHarjoitteet;

        public Harjoituspaiva()
        {
            HpHarjoitteet = new List<Harjoite>();
        }
        public Harjoituspaiva(int jako, Harjoitusohjelma ha)
        {
            jakopv = jako;
            HpHarjoitteet = new List<Harjoite>();
            LisaaHjHarjoitteet(ha);
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
                if(h.Jako[jakopv] == true && h.Aktiivinen == true)
                {
                    HpHarjoitteet.Add(h);
                }
            }
        }
    }
}
