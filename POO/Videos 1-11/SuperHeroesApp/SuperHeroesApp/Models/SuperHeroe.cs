using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesApp.Models
{
    class SuperHeroe
    {
        public int Id;
        public string nombre;
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
                Console.WriteLine($"{nombre} esta usando el super poder: {item.nombre}");
            }

            return sb.ToString();
        }


    }
