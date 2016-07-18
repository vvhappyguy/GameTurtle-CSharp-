using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turtle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CineAdviser: Welcome!!!");
            Console.WriteLine("What is your name?");
            String name = Console.ReadLine();
            Console.WriteLine("Hello, "+ name);

            Console.WriteLine("What genre of film do you prefer: comedy or drama or fantstic or drama");
            String genre = Console.ReadLine();
            if (genre == "comedy")
            {
                Console.WriteLine("In this situation, i recommend you this title of films:");
                Console.WriteLine("~ Operation 'I' and another advenure of Shurik");
                Console.WriteLine("~ Back into the Future");
                Console.WriteLine("~ Ivan Vasil'evic change profession");
            }else if (genre == "drama")
            {
                Console.WriteLine("In this situation, i recommend you this title of films:");
                Console.WriteLine("~ Green Mile");
                Console.WriteLine("~ Hatico");
                Console.WriteLine("~ 1+1");
            } else if (genre == "fantastic")
            {
                Console.WriteLine("In this situation, i recommend you this title of films:");
                Console.WriteLine("~ Autostop Galactic");
                Console.WriteLine("~ Back into the Future");
                Console.WriteLine("~ Star Way");
            } else if (genre == "erotic")
            {
                Console.WriteLine("Please, count your ages:")
                String YearSting = Console.ReadLine();
                int year = Int32.Parse(YearSting);
                if (year >= 18)
                {
                    Console.WriteLine("In this situation, i recommend you this title of films:");
                    Console.WriteLine("Nimfomanka");
                    Console.WriteLine("Sex-Drive");
                } else
                {
                    Console.WriteLine("I can't recommend you any films of this genre!");
                }
            }
            Console.Read();
        }
    }
}
