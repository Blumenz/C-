using System.Data;
using System.Diagnostics.Metrics;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        /*Enter your role name(Administrator, Manager, or User)
        Admin
        The role name that you entered, "Admin" is not valid.Enter your role name(Administrator, Manager, or User)
        Administrator
        Your input value(Administrator) has been accepted.*/
        string? readResult;
        bool validEntry = false;
        Console.WriteLine("Enter your role name");
        do
        {
            readResult = Console.ReadLine();

            ;
            if (readResult != null)
            {
                if (readResult == "Administrator" | readResult == "Manager" | readResult == "User")
                {
                    Console.WriteLine("Welcome " + readResult.ToLower().Trim());

                    validEntry = true;
                }
                else
                {
                    Console.WriteLine($"The role name {readResult}, is not valid. Enter your role name");
                }
            }
        } while (validEntry == false);
    }
}