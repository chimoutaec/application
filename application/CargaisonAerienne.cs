using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application
{
     class CargaisonAerienne : Cargaison
    {
        public CargaisonAerienne(int d): base(d) {  }

        public override double cout()
        {
            if (GetVolumeTotal() < 80000)
                return 10 * distance * GetVolumeTotal();
            else
                return 12 * distance * GetPoidsTotal();
        }

        public override string ToString()
        {
            return "Cargaison Aérienne Distance =" + distance;
        }
    }
}
