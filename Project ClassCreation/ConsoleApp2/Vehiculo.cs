using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Vehiculo
    {
        private String nombreVehiculo;

        public void getNombre()
        {
            Console.WriteLine("El nombre del vehiculo es " + nombreVehiculo);
        }

        public Vehiculo(String nombre)
        {
            nombreVehiculo = nombre;
        }
        protected void arrancarMotor()
        {
            Console.WriteLine("Enciende motor");
        }

        protected void pararMotor()
        {
            Console.WriteLine("Detiene motor");
        }

        public virtual void motor()
        {
            Console.WriteLine("Poseo motor");
        }
    }
}
