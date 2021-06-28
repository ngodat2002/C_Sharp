using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int i, j;
            for (i = 1; i<=9; i++)
            {
                    Console.WriteLine(n + " x " + i + "=" + n * i);
               
            }
            Console.ReadKey();
        }
    }
}
