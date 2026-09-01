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

        //Q3
        // Compile - time error — you can't put text (string) into an int variable
        int pages = 464; // the rigth one 

        //Q4
        try
        {
            int x = 10; int y = 0;
            int z = x / y;
            Console.WriteLine(z);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero");
        }
        finally
        {
            Console.WriteLine("Done");
        }

        // Q5
        int Pages = 300;
        double Convert_Pages = Pages; // implicit
        Console.WriteLine(Convert_Pages);

        // Q6
        double price = 49.99;
        int Convert_Price = (int)price; // explicit
        Console.WriteLine(Convert_Price);

        //Q7
        string pagesText = "464";
        int Convert_pagesText = Convert.ToInt32(pagesText);
        Console.WriteLine(Convert_pagesText);

        //Q8
        string yearText = "2023";
        int parse_yearText = int.Parse(yearText);
        Console.WriteLine(parse_yearText);
        string badText = "abc";

        int.TryParse(badText, out int tryParse_badText);
        if (tryParse_badText == 1)
        {
            Console.WriteLine(tryParse_badText);
        }
        else
        {
            Console.WriteLine("Invalid number");
        }


        //Q9
        int Page = 464;
        string Conver_Pages = Page.ToString();
        Console.WriteLine(Conver_Pages.GetType());

        //Q10
        int copies = 100;
        object boxIt = copies; // implict boxing
        Console.WriteLine(boxIt);
        int copies_unbox = (int)boxIt; // explicit unboxing
        Console.WriteLine(copies_unbox);

        //Q11
        int? year = null;
        Console.WriteLine(year.HasValue); // return bolean "false"
        year = 2023;
        Console.WriteLine(year.Value);

        //Q12
        string? reviewer = null;
        Console.WriteLine(reviewer == null);

        //Q13
        Book? book = null;
        Console.WriteLine(book?.Title); // to prevent NullReferenceException
                                        // it will print nothing but there is no crash 


    }

}