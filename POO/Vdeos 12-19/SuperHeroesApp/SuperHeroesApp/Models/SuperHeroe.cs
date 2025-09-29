using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesApp.Models
{
    class SuperHeroe : Heroe, in
    {
        private string _nombre;
        public int Id;
        public override string nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                _nombre = value.Trim();
            }
        }

        public string nombreIdentidadSecreta
        {
            get
            {
                return $"{nombre} ({IdentidadSecreta})";
            }
        }

        public string IdentidadSecreta;
        public string ciudad;
        public List<SuperPoder> SuperPoderes;
        public bool PuedoVolar;

        public SuperHeroe()
        {
            SuperPoderes = new List<SuperPoder>();
            PuedoVolar = false;

        }

        public string UsarSuperPoderes()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in SuperPoderes)
            {
                Console.WriteLine($"{nombreIdentidadSecreta} esta usando el super poder: {item.nombre}");
            }

            return sb.ToString();
        }

        public override string SalvarElMundo()
        {
            return $"{nombreIdentidadSecreta} ha salvado el mundo";
        }

        public override string salvarTierra()
        {
            return $"{nombreIdentidadSecreta} ha salvado la tierra";
        }
    }
}
