using ConsoleApp2;

internal class Program
{
    static void Main(string[] args)
    {
        Avion miBoeing = new Avion("Boeing");

        Coche miFiat = new Coche("Fiat");

        Vehiculo[] almacenVehiculo = new Vehiculo[2];

        almacenVehiculo[0] = miBoeing;
        almacenVehiculo[1] = miFiat;

        for (int i = 0; i<almacenVehiculo.Length; i++)
        {

            almacenVehiculo[i].getNombre();
            almacenVehiculo[i].motor();
            if (almacenVehiculo[i] == miBoeing)
            {
                miBoeing.volador();
            }
            else if (almacenVehiculo[i] == miFiat)
            {
                miFiat.terrestre();
            }
        }
    }
}





