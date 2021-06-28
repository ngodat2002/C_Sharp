using System;

namespace OutputFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Currency formating - {0:C} {1:4}", 88.8, 888.8);
            Console.WriteLine("Interger formating - {0:5D}", 88);
            DateTime dt = DateTime.Now;
            Console.WriteLine("Today d format: {0:d}", dt);
            Console.WriteLine("Today D format: {0:D}", dt);
            Console.ReadLine();
        }
    }
}
