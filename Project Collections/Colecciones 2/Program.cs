namespace Colecciones2
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> numeros = new LinkedList<int>();

            foreach (int numero in new int[] {1,2,3}) 
            {

                numeros.AddLast(numero);

            }

            //numeros.Remove(2);

            LinkedListNode<int> nodoImportante = new LinkedListNode<int>(15);

            numeros.AddFirst(nodoImportante);

            /*foreach(int numero in numeros)
            {

                Console.WriteLine(numero);

            }*/

            for(LinkedListNode<int> nodo = numeros.First; nodo != null; nodo = nodo.Next)
            {

                int numero = nodo.Value;

                Console.WriteLine(numero);

            }
        }
    }
}