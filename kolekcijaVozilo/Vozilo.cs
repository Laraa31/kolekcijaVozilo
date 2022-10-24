using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolekcijaVozilo
{
    internal class Vozilo
    {
        string model;
        int brKotaca, godProizvod;

        public Vozilo(string model, int godProizvod, int brKotaca)
        {
            Model = model;
            GodProizvod = godProizvod;
            BrKotaca = brKotaca;
        }

        public override string ToString()
        {
            string ispis = "\n"+this.Model + "\t   " +  this.GodProizvod + "\t" + "\t" + this.brKotaca + "\t"  +"\t" ;
            return ispis;
        }
        public string Model { get => model; set => model = value; }
        public int GodProizvod { get => godProizvod; set => godProizvod = value; }
        public int BrKotaca { get => brKotaca; set => brKotaca = value; }
    }
}
