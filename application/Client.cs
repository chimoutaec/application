using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application
{
    public class Client
    {
        string nom;
        public List<Cargaison> cargaisons = new List<Cargaison>();

        public Client(string N)
        {
            this.nom = N;
        }

        public void AddCargaison( Cargaison c )
        {
            cargaisons.Add(c);
        }

        public void AddMarchandise ( Marchandise m, int i)
        {
            cargaisons[i].AddM(m);
        }

        public double GetCoutTotal()
        {
            double ct = 0;
            foreach (Cargaison c in cargaisons)
            {
                ct += c.cout();
            }
            return ct;
        }
    }
}
