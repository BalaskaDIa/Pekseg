using System;
using System.Collections.Generic;
using System.Text;

namespace Pekseg
{
    class Peksegek
    {
        private string nev;
        private List<Pekaruk> termekek;
        private DateTime alapitva;

        public Peksegek(string nev, DateTime alapitva)
        {
            this.nev = nev;
            this.termekek = new List<Pekaruk>();
            this.alapitva = alapitva;
        }
        public string Nev { get => nev; set => nev = value; }
        public List<Pekaruk> GetTermekek()
        {
            return this.termekek;
        }
        public DateTime GetAlapitva()
        {
            return this.alapitva;
        }
        public void SetTermekek(Pekaruk p)
        {
            termekek.Add(p);
        }
        public override string ToString()
        {
            return String.Format("{0} - {1}", this.nev, this.alapitva);
        }
    }
}
