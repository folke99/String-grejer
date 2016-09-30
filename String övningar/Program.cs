using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_övningar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Övning 1
            /*
            Console.WriteLine("\u0056\u00E4\u0157\u006D\u0064\u00F6\u0020\u0047\u0079\u006D\u006E\u0061\u0073\u0069\u0075\u006D");
            Console.ReadKey();
            */
            //Övning 2
            /*
            Console.WriteLine("\"Hello world\"");
            Console.ReadKey();
            */
            //Övning 3
            /*
            string y = "Hello world";
            string x = y.ToUpper();
            Console.WriteLine(x);
            Console.ReadKey();
            */
            //Övning 4
            /*
            string y = "HELLO WORLD";
            string x = y.ToLower();
            Console.WriteLine(x);
            Console.ReadKey();
            */
            //Övning 5

            Console.WriteLine("Skriv in något:");
            string inmatat = Console.ReadLine();

            for (int i = inmatat.Length; i > inmatat.Length; i--)
            {
                Console.WriteLine(inmatat[i]);
            }
            Console.ReadKey();



        }
    }
}
