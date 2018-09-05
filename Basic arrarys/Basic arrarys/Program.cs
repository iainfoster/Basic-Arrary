using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_arrarys
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to CrankWorx Medal Awards");
            String[] MedalWinners = new String[3];
            Console.Write("please enter the gold medal winnder:");
            MedalWinners[0] = Console.ReadLine();
            Console.Write("please enter the Silver medal winnder:");
            MedalWinners[1] = Console.ReadLine();
            Console.Write("please enter the Bronze medal winnder:");
            MedalWinners[2] = Console.ReadLine();

            Console.WriteLine("Which medalwinner did you want to see");
            Console.WriteLine("Press 1 for gold:");
            Console.WriteLine("Press 2 for silver:");
            Console.WriteLine("Press 3 for Bronze:");
            int imput = int.Parse(Console.ReadLine());
            if (imput == 1)
            {
                Console.WriteLine($"Gold medal went to: {MedalWinners[0]}");
            }
            else if (imput == 2)
            {
                Console.WriteLine($"Silver medal went to: {MedalWinners[1]}");
            }
            else if (imput == 3)
            {
                Console.WriteLine($"Bronze medal went to: {MedalWinners[2]}");
            }
            Console.ReadKey();
        }
    }
}
