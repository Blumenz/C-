internal class Program
{
    private static void Main(string[] args)
    {
        string[] matrix = new string[8];

        matrix[0] = "B123";
        matrix[1] = "C234";
        matrix[2] = "A345";
        matrix[3] = "C15";
        matrix[4] = "B177";
        matrix[5] = "G3003";
        matrix[6] = "C235";
        matrix[7] = "B179";

        foreach (string value in matrix)
        {
            if (value.StartsWith("B"))
            {
                Console.WriteLine(value);
            }
        }
    }
}