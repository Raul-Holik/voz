using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatVozila
{
    class Vozila
    {
        string model, godiste, brKotaca;
        string kategorija;
        

        public Vozila(string model,string godiste, string brKotaca)
        { 
            this.model = model;
            this.godiste = godiste;
            this.brKotaca = brKotaca;
             
            
        }

        public string Model { get=>model; set=>model=value; }
        public string Godiste { get=>godiste; set=>godiste=value; }
        public string BrKotaca { get=>brKotaca; set=>brKotaca=value; }
        public string Kategorija { get=>kategorija; set=>kategorija=value; }

        public override string ToString()
        {
            string ispis = "Model: " + model + ", godiste: " + godiste + ", broj kotaca: " + brKotaca +", kategorija: "+kategorija;
            return ispis;
        }

    }
}
