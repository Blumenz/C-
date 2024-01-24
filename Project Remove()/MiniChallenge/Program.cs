internal class Program
{
    private static void Main(string[] args)
    {
        const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

        string quantity = "";
        string output = "";

        // Your work here

        //code for quantity
        const string openSpan = "<span>";
        const string closeSpan = "</span>";
        int openingPosition = input.IndexOf(openSpan);
        int closingPosition = input.IndexOf(closeSpan);
        openingPosition += openSpan.Length;
        int length = closingPosition - openingPosition;
        quantity = input.Substring(openingPosition, length);


        //code for output
        output = input;
        output = output.Replace("&trade", "&reg");
        output = output.Replace("<div>", "");
        output = output.Replace("</div>", "");

        Console.WriteLine("Quantity: "+ quantity);
        Console.WriteLine(output);
    }
}