using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application
{
    public abstract class Cargaison
    {
        protected int distance;
        protected List<Marchandise> marchandises = new List<Marchandise>();


        public List<Marchandise> GetMarchandises()
        {
            return marchandises;
        }

        public Cargaison(int d)
        {
            this.distance = d;
        }

        public void AddM(Marchandise m)
        {
            marchandises.Add(m);
        }

        public void afficher()
        {
            foreach(Marchandise m in marchandises)
            {
                Console.WriteLine(m.ToString());
            }
        }

        public Marchandise GetMarchandises (int num)
        {
            foreach (Marchandise m in marchandises)
            {
                if (m.Numero == num) return m;
            }
            return null;
        }

        public double GetPoidsTotal()
        {
            double P = 0;
            foreach (Marchandise m in marchandises)
            {
                P += m.Poids;
            }
            return P;
        }

        public double GetVolumeTotal()
        {
            double V = 0;
            foreach (Marchandise m in marchandises)
            {
                V += m.Volume;
            }
            return V;
        }

        public abstract double cout();
    }
}
