using POO_P2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_P2.Models
{
    class SuperHeroe : Heroe, ISuperHeroe
    {
        private string _nombre;
        public int id { get; set;  } = 1;
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
                return $"{nombre} ({identidadSecreta})";
            }
        }

        public string identidadSecreta { get; set;  }
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
                sb.Append($"{nombreIdentidadSecreta} esta usando el super poder {item.nombre} !! \n");
            }
            return sb.ToString();
        }
        public override string salvarelmundo()
        {
            return $"{nombreIdentidadSecreta} ha salvado el mundo";
        }

        public override string salvaerLaTierra()
        {
            //return base.salvaerLaTierra();
            return $"{nombreIdentidadSecreta} ha salvado la tierra";
        }
    }

}
