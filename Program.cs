using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.Getters_and_setters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Movie movie1 = new Movie("Titanic", "Jim", "PG-13");//new
            Movie movie2 = new Movie("Unreleased", "Mercy", "PG");

            Console.WriteLine(movie1.Rating);
            Console.ReadLine();
        }
    }
}
