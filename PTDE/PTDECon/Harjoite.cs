using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTDECon
{
    class Harjoite
    {
        private int paivacounter = 0;
        private bool[] jako = new bool[7];
        private double painojenMuutosD = 0;
        private double painojenMuutosSarja = 0;
        List<Sarja> sarjat = new List<Sarja>();

        public void LisaaSarja(Sarja srj)
        {
            sarjat.Add(srj);
        }
        public void PoistaSarja(int index)
        {
            sarjat.RemoveAt(index);
        }
    }
    class Sarja
    {
        private double lahtopainot;
        private double painot;
        private int toistot;
    }
}
