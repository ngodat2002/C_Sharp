using System;

namespace OutParametters
{
    class Program
    {
        static void Main(string[] args)
        {
            int value;
            Deperciation(out value);
        }
        static void Deperciation(out int val)
        {
            val = 20000;
            int dep = val * 5 / 100;
            int amt = val - dep;
            Console.WriteLine("Depreciation Amount : " + dep);
            Console.WriteLine("Reduced value after depreciation: " + amt);

        }
    }
}
