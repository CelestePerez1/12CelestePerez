using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_P2.Models
{
    internal abstract class Heroe
    {
        public abstract string nombre 
        {  get;
           set; 
        }
        public abstract string salvarelmundo();

        public virtual string salvaerLaTierra()
        {
            return $"{nombre} ha salavado la tierra";
        }
    }
}
