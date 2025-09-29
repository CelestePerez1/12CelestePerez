using POO_P2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_P2
{
    internal class ImprimirInfo
    {
        public void ImprimirSuperHeroe(ISuperHeroe superHeroe)
        {
            Console.WriteLine($"ID: {superHeroe.id}");
            Console.WriteLine($"Nombre: {superHeroe.nombre}");
            Console.WriteLine($"Identidad secreta: {superHeroe.identidadSecreta}");
        }
    }
}
