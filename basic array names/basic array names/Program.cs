using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_array_names
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Names = new string[5];
            for (int i = 0; i < Names.Length; i++) 
            {
                Console.Write($"please enter a name{i + 1}:");
                Names[i] = Console.ReadLine();
            }
            Console.WriteLine($"First name is:{Names[0]}");
            Console.WriteLine($"First name is:{Names[4]}");
            Console.ReadKey();
        }

    }
}
