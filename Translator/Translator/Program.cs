using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I can translate 'hello' in 5 different languages:");
            string[] trans = new string[6]{ "Hello", "Kia ora", "Kon'Nichiwa", "Namaste", "Bonjour","Talofa"};
            Console.WriteLine("Select a Language:");
            Console.WriteLine("Select 1 for English");
            Console.WriteLine("Select 2 for Maori");
            Console.WriteLine("Select 3 for Japanese");
            Console.WriteLine("Select 4 for Hindi");
            Console.WriteLine("Select 5 for French");
            Console.WriteLine("Select 6 for Talofa");
            Console.Write("Please Make a Selecetion: ");
            int selection = int.Parse(Console.ReadLine());

            switch (selection)
            {
                case 1:
                    Console.WriteLine(trans[selection - 1]);
                    break;
                case 2:
                    Console.WriteLine(trans[selection - 1]);
                    break;
                case 3:
                    Console.WriteLine(trans[selection - 1]);
                    break;
                case 4:
                    Console.WriteLine(trans[selection - 1]);
                    break;
                case 5:
                    Console.WriteLine(trans[selection - 1]);
                    break;
                case 6:
                    Console.WriteLine(trans[selection - 1]);
                    break;
                default:
                    Console.WriteLine("Oops somthing went wrong");
                    break;
            }
            Console.ReadLine();
        }
    }
}
