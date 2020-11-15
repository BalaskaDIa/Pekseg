using System;
using System.Collections.Generic;
using System.Text;

namespace Pekseg
{
    class Pekaruk
    {
        private string nev;
        private int ar;
        private bool laktozmentes;
        public Pekaruk(string nev, int ar, bool laktozmentes)
        {
            this.Nev = nev;
            this.Ar = ar;
            this.Laktozmentes = laktozmentes;
        }
        public string Nev { get => nev; set => nev = value; }
        public int Ar { get => ar; set => ar = value; }
        public bool Laktozmentes { get => laktozmentes; set => laktozmentes = value; }

        public override string ToString()
        {
            return String.Format("{0} ({1} Ft/Db)", this.nev, this.ar);
        }
    }
}
