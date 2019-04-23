using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {

        int x = 0;
        static void Main(string[] args)
        {
            //int finalValue = Calculate(20,10, '/');
            //Console.WriteLine(finalValue);

            Console.WriteLine( Demo(1));


            Console.ReadLine();

        }


        public static int Demo(int a)
        {

            if (a < 5)
            {
                Console.WriteLine(Demo(++a));
            }
            return a;
        }

        static int Calculate(int a, int b, char oper)
        {
            int res = 0;
            switch (oper)
            {
                case '+':
                    res = a + b;
                    break;
                case '-':
                    res = a - b;
                    break;
                case '*':
                    res = a * b;
                    break;
                case '/':
                    res = a / b;
                    break;
                default:
                    break;
            }
            

            return res;
        }

    }
}
