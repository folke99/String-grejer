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
            //Övning 3a
            /*
            string y = "Hello world";
            string x = y.ToUpper();
            Console.WriteLine(x);
            Console.ReadKey();
            */
            //Övning 3b
            /*
            string y = "HELLO WORLD";
            string x = y.ToLower();
            Console.WriteLine(x);
            Console.ReadKey();
            */
            //Övning 4
            /*
            string world = "Hello world";
            Console.WriteLine(world.Length);
            Console.ReadKey();
            */
            //Övning 5
            /*
            Console.WriteLine("Skriv in något:");
            string inmatat = Console.ReadLine();
            string bakNamn = "";

            for (int i = inmatat.Length -1; i >= 0; i--)
            {
                bakNamn = bakNamn + inmatat[i];
            }
            Console.WriteLine(bakNamn);
            Console.ReadKey();
            */
            //Övning 6
            /*
            string låt = "{0} elefant{1} balanserade på en liten liten spindel trååååååd. \n"
                       + "Det tyckte {2} var så intressant,\n"
                       + "så {2} gick och hämtade en annan elefant";

            string index = string.Format(låt, "en", "", "han");
            Console.WriteLine(index);

            for (int i = 1; i < 10;)
            {
                index = string.Format(låt, ++i, "er", "de");
                Console.WriteLine(index);
            }
            Console.ReadKey();
            */
            //Övning 7 INTE KLAR

            // Övning 2.1
            /*
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt.ToString("d"));
            Console.ReadKey();
            */
            //Övning 2.2
            /*
            double cirkelArea = Math.PI * 4 * 4;
            Console.WriteLine(cirkelArea.ToString("F4"));
            Console.ReadKey();
            */
            //Övning 2.3
            /*
            Console.WriteLine("{0:000,000,000}", 1000000000);
            Console.ReadKey();
            */
            //Övning 2.4


        }
    }
}
