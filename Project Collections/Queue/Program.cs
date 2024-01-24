namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> numeros = new Queue<int>();

            //rellenado o agregando elementos a la cola

            foreach (int numero in new int[5] { 2, 4, 6, 8, 10 })
            {
                numeros.Enqueue(numero);
            }

            //recorriendo la cola

            Console.WriteLine("Recorriendo el Queue");

            foreach (int numero in numeros)
            {

                Console.WriteLine(numero);

            }

            //eliminando elementos de la Queue
            Console.WriteLine("Eliminando elementos");

            numeros.Dequeue();

            foreach (int numero in numeros)
            {

                Console.WriteLine(numero);

            }

        }
    }
}