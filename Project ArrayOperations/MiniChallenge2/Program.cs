internal class Program
{
    private static void Main(string[] args)
    {
        string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

        // Split the orderStream into an array of strings
        string[] orderArray = orderStream.Split(',');

        // Check each value in the array
        foreach (string order in orderArray)
        {
            // Display each individual value
            Console.WriteLine($"Order: {order}");

            // If the value has less than 4 characters, throw an error message
            if (order.Length < 4 || order.Length>4)
            {
                Console.WriteLine($"Error: {order}");
                // You can throw an exception here or handle the error accordingly
            }
        }
    }
}