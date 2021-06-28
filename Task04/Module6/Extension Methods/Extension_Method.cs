using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Methods
{
    class Extension_Method
    {
        static void Main(string[] args)
        {
            string country = "Great Britain";
            Console.WriteLine(country.FirstLetterPower());
            List<string> cities = new List<string>();
            cities.Add("Seoul");
            cities.Add("Beijing");
            cities.Add("Seoul");
            cities.Add("Beijing");
            cities.Add("Seoul");
            cities.Add("Beijing");
            cities.Add("Seoul");
            cities.Add("Beijing");
            List<string> result = cities.RemoveDulicate();
            foreach (string city in result)
                Console.WriteLine(city);
            Console.ReadKey();
        }
    }
}
