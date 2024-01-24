namespace colecciones
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numeros = new List<int>(); //Declarar una lista (coleccion de tipo lista)

            /*int[] listaNumeros = new int[] {1,2,3,4,5};

            for(int i=0; i < 5; i++)
            {

                numeros.Add(listaNumeros[i]);

            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(numeros[i]);
            }
            

            Console.WriteLine("Cuantos elem quieres introducir?");

            int elem = Int32.Parse(Console.ReadLine());

            for(int i = 0; i < elem; i++)
            {

                numeros.Add(Int32.Parse(Console.ReadLine()));

            }

            Console.WriteLine("Elementos introducidos:");

            for (int i = 0; i < numeros.Count; i++)
            {

                Console.WriteLine(numeros[i]);

            }
            */

            Console.WriteLine("Introduce elementos en la coleccion (0 para salir)");

            int elem = 1;

            while(elem != 0)
            {
                elem = Int32.Parse(Console.ReadLine());

                numeros.Add(elem);
            }

            numeros.RemoveAt(numeros.Count - 1);

            Console.WriteLine("Elementos introducidos: ");

            foreach(int elemento in numeros)
            {
                Console.WriteLine(elemento);
            }
        }
    }
}