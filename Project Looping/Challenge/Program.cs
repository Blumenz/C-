using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Random random = new Random();
        int vidaHeroe = 10;
        int vidaMonstruo = 10;
        int ataqueHeroe = random.Next(1, 10);
        int ataqueMonstruo = random.Next(1, 10);

        do
        {
            ataqueHeroe = random.Next(1, 10);

            vidaMonstruo = vidaMonstruo - ataqueHeroe;
           
            ataqueMonstruo = random.Next(1, 10);

            vidaHeroe = vidaHeroe - ataqueMonstruo;

            Console.WriteLine("Vida del monstruo es " +vidaMonstruo);
            Console.WriteLine("Vida del Heroe es " + vidaHeroe);
            if (vidaMonstruo <= 0) Console.WriteLine("El Heroes es el ganador");
            else if (vidaHeroe <= 0) Console.WriteLine("El Monstruo es el ganador");


            
        } while (vidaHeroe >0 && vidaMonstruo >0);

    }
}