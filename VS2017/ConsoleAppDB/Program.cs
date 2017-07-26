using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using ConsoleAppDB.Model;

namespace ConsoleAppDB
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Program p = new Program();
            p.runSomeQueries();
            Console.WriteLine("*** DONE ***");
            Console.Read();
        }
        private void runSomeQueries(){
            NorthwindContext n = new NorthwindContext();

            // get a random country name
            Random r = new Random();
            int skipTo = r.Next(0,20);
            var query1 = (from cnty in n.Customers orderby cnty.Country select cnty.Country).Skip(skipTo).Take(1);
            string selectedCountry = query1.FirstOrDefault();
            Console.WriteLine();
            Console.WriteLine("Listing random country {0}", selectedCountry);
        }
        
    }
}
