using System.Numerics;
using System.Reflection;
using System.Timers;
using static System.Runtime.InteropServices.JavaScript.JSType;
class Book
{
    public string Title;
    public int Pages;
}
class program
{
    static void Main()
    {
        // Q1
        Book P1 = new Book()
        {
            Title = "Clean Code ",
            Pages = 400
        };
        object P2 = P1;
        Console.WriteLine(P2);
        // Q2
        Console.WriteLine(P1.ToString());
        Console.WriteLine(P1.Equals(P1));
        Console.WriteLine(P1.GetHashCode());
        Console.WriteLine(P1.GetType());

    }
}

