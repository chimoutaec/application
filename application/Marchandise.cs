using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application
{
    public class Marchandise
    {
        public int numero;
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public double poids;

        public double Poids
        {
            get { return poids; }
            set { poids = value; }
        }
        public double volume;

        public double Volume
        {
            get { return volume; }
            set { volume = value; }
        }


        public Marchandise(int num, double p, double v)
        {
            this.numero = num;
            this.poids = p;
            this.volume = v;

        }

        public override string ToString()
        {
            return "Num =" + numero + " Poids =" + poids + " volume =" + volume;
        }


    }
}

