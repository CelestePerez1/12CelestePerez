using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_P2.Models
{
    internal class AntiHeroe : SuperHeroe
    {
        public string realizarAccionDeAntiHeroe(string accion)
        {
            return $"El Antiheroe {nombreIdentidadSecreta} ha realizado: {accion}";
        }
    }
}
