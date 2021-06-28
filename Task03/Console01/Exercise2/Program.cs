using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
         

            Console.WriteLine("Enter a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter c: ");
            int c = Convert.ToInt32(Console.ReadLine());

            int max = a;

            if (max < b)
            {
                max = b;
            }

            if (max < c)
            {
                max = c;
            }
     


            Console.WriteLine("Max trong 3 so {0}, {1}, {2} là {3}", a, b, c, max);

            Console.ReadKey();

        }
    }
}
