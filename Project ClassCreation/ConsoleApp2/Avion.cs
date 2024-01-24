using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Avion : Vehiculo
    {
        public Avion(String nombreAvion) : base(nombreAvion) { }
        public void volador()
        {
            Console.WriteLine("Viaja por aire");
        }

        public override void motor()
        {
            Console.WriteLine("Poseo un motor jet");
        }
    }
    
    }

