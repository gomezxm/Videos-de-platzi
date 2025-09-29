using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesApp.Models
{
    internal class AntiHeroe: SuperHeroe
    {
        public string RealizarAccionAntiHeroe(string accion)
        {
            return $"El AntiHeroe {nombreIdentidadSecreta} ha realizado {accion}";
        }
    }
}
