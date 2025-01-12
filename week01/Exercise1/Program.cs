using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise1 Project.");
         
         Console.Write("What is Your First name?");
        string first= Console.ReadLine ();
        Console.Write ("What is Your Last name?");
        string last= Console.ReadLine ();
        Console.WriteLine ($"Your name is {last}, {first} {last}.");

    }
}