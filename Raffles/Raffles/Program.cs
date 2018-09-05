using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raffles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Raffles = new string[20] { "fippy", "goldburg", "jamie", "sandra", "stevenson", "manable", "devan", "bob", "jessy", "joel", "alan", "eric", "zac", "ashton", "keegan", "conner", "dougel", "zane", "harry", "jess" };
            Console.WriteLine("The 20 raffle tickets: ");
            for (int i = 0; i < Raffles.Length; i++)
            {
                Console.WriteLine($"Ticket {i + 1}: {Raffles[i]}");
            }

            Random rand = new Random();
              int R = rand.Next(1, 20);

            Console.WriteLine($"The winning ticket is: {R}");

            Console.WriteLine("**********************************");
            Console.WriteLine($"The Winner of $1,000,000 is: "+Raffles[R-1]);
            Console.WriteLine("**********************************");
            Console.ReadLine();
        }
    }
}
