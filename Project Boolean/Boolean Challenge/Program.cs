using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {
        //Evaluation of conditionals with the random class
        Random coin = new Random();
        int flip = coin.Next(0, 2);
        Console.WriteLine((flip == 0) ? "heads" : "tails");

        string userPermission = "Admin";
        int userLevel = 55;


        Console.WriteLine((userLevel > 55) ? "Welcome, Super Admin user." : (userLevel <= 55 && userPermission == "Admin") ? "Welcome, Admin user." : (userLevel > 20 && userPermission == "Director") ? "Contact an Admin for access." : (userLevel < 20 && userPermission == "Director") ? "You do not have sufficient privileges." : "You do not have sufficient privileges.");
    }
}