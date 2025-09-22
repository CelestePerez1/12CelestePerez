using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_P2.Models
{
    class SuperHeroe
    {
        public int id;
        public string nombre;
        public string identidadSecreta;
        public string ciudad;
        public List<SuperPoder> superPoderes;
        public bool PuedeVolar;

        public SuperHeroe()
        {
            id = 1;
            superPoderes = new List<SuperPoder>();
            PuedeVolar = false;
        }

        public string UsarSuperPoderes()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in superPoderes)
            {
                sb.Append($"{nombre} esta usando el super poder {item.nombre} !!");
            }
            return sb.ToString();
        }
    }

}
