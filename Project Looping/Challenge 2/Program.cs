internal class Program
{
    private static void Main(string[] args)
    {
        /*string? readResult;
        bool validEntry = false;
        Console.WriteLine("Enter a string containing at least three characters:");
        do
        {
            readResult = Console.ReadLine();
            if (readResult != null)
            {
                if (readResult.Length >= 3)
                {
                    validEntry = true;
                }
                else
                {
                    Console.WriteLine("Your input is invalid, please try again.");
                }
            }
        } while (validEntry == false);*/

        // capture user input in a string variable named readResult

        //string? readResult;
        int? numericValue;
        bool validNumber = false;

        Console.WriteLine("Por favor ingrese un numero entero entre 5 y 10");
        do
        {
            numericValue = int.Parse(Console.ReadLine());
            if (numericValue != null)
            {
                if (numericValue >= 5 && numericValue <= 10)
                {
                    Console.WriteLine("Valor aceptado");
                    validNumber = true;
                }
                else
                {
                    Console.WriteLine("Input invalido por favor vuelva a intentar");
                }
            }

        } while (validNumber == false);
    }
}