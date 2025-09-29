using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesApp.Models
{
    class SuperPoder
    {
        public string nombre;
        public string descripcion;
        public NivelPoder nivel;

        public SuperPoder()
        {
            nivel = NivelPoder.NivelUno;
        }
    }
}
