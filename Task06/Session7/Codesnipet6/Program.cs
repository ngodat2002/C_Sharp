using System;

namespace Codesnipet6
{
    class Animal
    {
        public Animal()
        {
            Console.WriteLine("Animal contrucstor without parametters");
        }
        public Animal(String name)
        {
            Console.WriteLine("Animal constructor with a string parameters");

        }
    }
    class Canie : Animal
    {
        public Canie() : base("Lion")
        {
            Console.WriteLine("Derived Canine");
        }
        static void Main(string[] args)
        {
            Canie objCanie = new Canie();
        }
    }
}
