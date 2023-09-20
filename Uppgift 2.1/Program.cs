using System;
namespace Uppgift2_1
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Vilken är din favorit bok?");
            string bok = Console.ReadLine();
            Console.WriteLine("Din favorit bok är " + bok + ".");
            Console.ReadKey();
        }
    }
}