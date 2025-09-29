using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesApp.Models
{
    internal abstract class Heroe
    {
        public abstract string nombre { get; set; }

        public abstract string SalvarElMundo();

        public virtual string salvarTierra()
        {
            return $"{nombre} ha salvado la tierra";
        }

    }
}
