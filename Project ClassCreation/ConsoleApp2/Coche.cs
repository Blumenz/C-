using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Coche : Vehiculo
    {
        public Coche(String nombreCoche) : base(nombreCoche) { }

        public void terrestre()
        {
            Console.WriteLine("Viaja por tierra");
        }

        public override void motor()
        {
            Console.WriteLine("Poseo motor a 4 tiempos");
        }
    }
}

