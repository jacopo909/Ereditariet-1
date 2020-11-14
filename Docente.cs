using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eredietarietà
{
    class Docente : Lavoratore
    {
        public double Mensile()
        {
            Stipendio = (8 * 6) * 30;
            return Stipendio;
        }
    }
}
