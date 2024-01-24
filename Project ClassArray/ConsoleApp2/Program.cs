internal class Program
{
    static void Main(string[] args)
    {

        /*int[] numeros = new int[4];

        numeros[0] = 7;
        numeros[1] = 8;
        numeros[2] = 9;
        numeros[3] = 10;

        ProcesaDatos(numeros);

        foreach(int i in numeros)
        {

            Console.WriteLine(i);

        }
    }

    /tatic void ProcesaDatos(int[] datos)
    {
        for(int i=0; i<4; i++)
        {

            datos[i] += 10;

        }
    }*/
        int[] arrayElementos = LeerDatos();

        Console.WriteLine("Imprimiendo desde el main");

        foreach (int i in arrayElementos) Console.WriteLine(i);
    }
    //para que funcione lo de arriba comentar lo de abajo
    static int[] LeerDatos()
    {

        Console.WriteLine("Cuantos elementos quieres que tenga el array?");

        string respuesta = Console.ReadLine();

        int numElementos = int.Parse(respuesta);

        int[] datos = new int[numElementos];

        for(int i = 0; i < numElementos; i++)
        {
             
            Console.WriteLine($"Introduce el dato para la posicion {i} ");

            respuesta = Console.ReadLine();

            int datosElemento= int.Parse(respuesta);

            datos[i] = datosElemento;


        }

        return datos; 
    }

}


