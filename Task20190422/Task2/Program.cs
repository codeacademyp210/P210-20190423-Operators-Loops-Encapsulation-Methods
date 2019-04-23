using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Adinizi daxil edin: ");
            string name = Console.ReadLine();
            
            Console.Write("Soyadini daxil edin: ");
            string surname = Console.ReadLine();

            Console.WriteLine($"Salam {name} {surname}. Xosh gelmisiz!");


            Console.Read();

        }
    }
}
