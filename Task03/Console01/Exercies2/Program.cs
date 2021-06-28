using System;

namespace Exercies2
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter Number:");
          int   days = Convert.ToInt32(Console.ReadLine());
            switch (days)
            {
                case 1:
                    Console.WriteLine("Thu Hai");
                break;
                case 2:
                    Console.WriteLine("Thu Ba");
                    break;
                case 3:
                    Console.WriteLine("Thu Tu");
                    break;
                case 4:
                    Console.WriteLine("Thu Nam");
                    break;
                case 5:
                    Console.WriteLine("Thu Sau");
                    break;
                case 6:
                    Console.WriteLine("Thu Bay");
                    break;
                case 7:
                    Console.WriteLine("Chu Nhat");
                    break;
                default:
                    break;
            }
        }
    }
}
