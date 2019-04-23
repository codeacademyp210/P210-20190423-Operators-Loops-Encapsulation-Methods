using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Birinci ededi daxil edin:");
            string input1 = Console.ReadLine();
            int a = Convert.ToInt32(input1);

            Console.WriteLine("Ikinci ededi daxil edin:");
            string input2 = Console.ReadLine();
            int b;
            bool converted = Int32.TryParse(input2, out b);
            

            if (converted == true)
            {
                Console.WriteLine("Cemi: " + (a + b));
                Console.WriteLine("Ferqi: " + (a - b));
                Console.WriteLine("Hasili: " + (a * b));
                Console.WriteLine("Nisbeti: " + (a / b));
            } else
            {
                Console.WriteLine("Duzgun \\eded \"daxil\" etmediniz");
            }





            //int testInt = 50;

            //Console.WriteLine(testInt);

            //Number(out testInt);
            //Console.WriteLine(testInt);
            //Console.WriteLine(testInt);
            //Console.WriteLine(testInt);
            //Console.WriteLine(testInt);
            //Console.WriteLine(testInt);
            //Console.WriteLine(testInt);

            //int test2 = 100;
            //TestMethod(100);



            Console.Read();
        }

        //static void Number(out int a)
        //{
        //    a = 10;
        //}

        //static void TestMethod(int x)
        //{
        //    x = 20;
        //}
    }
}
