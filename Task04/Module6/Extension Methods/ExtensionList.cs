using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Methods
{
    static class ExtensionList
    {
        public static List<T> RemoveDulicate<T> (this List<T> allCities)
        {
            List<T> finalCities = new List<T>();
            foreach(var eachCity in allCities)
                if (!finalCities.Contains(eachCity))
                {
                    finalCities.Add(eachCity);
                }
            return finalCities;
        }
    }
}
