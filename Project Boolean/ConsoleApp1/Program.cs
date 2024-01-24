using System.Reflection.Metadata;

internal class Program
{
    private static void Main(string[] args)
    {
        /*Use of == operator
         * Console.WriteLine("a" == "a");
        Console.WriteLine("a" == "A");
        Console.WriteLine(1 == 2);

        string myValue = "a";
        Console.WriteLine(myValue == "a");*/

        /*string value1 = " a";
        string value2 = "A ";
        Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());*/

        /*Use of != operator
        Console.WriteLine("a" != "a");
        Console.WriteLine("a" != "A");
        Console.WriteLine(1 != 2);

        string myValue = "a";
        Console.WriteLine(myValue != "a");*/

        //Use of >, <, >=, <= operators
        /*Console.WriteLine(1 > 2);
        Console.WriteLine(1 < 2);
        Console.WriteLine(1 >= 1);
        Console.WriteLine(1 <= 1);*/

        //Boolean results
        /*string pangram = "The quick brown fox jumps over the lazy dog.";
        Console.WriteLine(pangram.Contains("fox"));
        Console.WriteLine(pangram.Contains("cow"));*/
        // These two lines of code will create the same output

        /*Console.WriteLine(pangram.Contains("fox") == false);
        Console.WriteLine(!pangram.Contains("fox"));*/

        //Use of ! operator
        /*string pangram = "The quick brown fox jumps over the lazy dog.";
        Console.WriteLine(!pangram.Contains("fox"));
        Console.WriteLine(!pangram.Contains("cow"));*/

        //Use of != operator
        /*int a = 7;
        int b = 6;
        Console.WriteLine(a != b); // output: True
        string s1 = "Hello";
        string s2 = "Hello";
        Console.WriteLine(s1 != s2); // output: False*/

        //Use of ? operator
        int saleAmount = 1001;
        /*int discount = saleAmount > 1000 ? 100 : 50;
        Console.WriteLine($"Discount: {discount}");*/
        Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");


    }
}