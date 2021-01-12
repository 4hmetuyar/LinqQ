using System;
using System.Collections.Generic;
using System.Linq;

namespace Example.LinqQuery
{
    public class Except
    {
        /// <summary>
        /// The Except() method requires two collections. It returns a new collection with elements from the first collection which do not exist in the second collection (parameter collection).
        /// </summary>
        public void Example()
        {
            IList<string> strList1 = new List<string>(){"One", "Two", "Three", "Four", "Five" };
            IList<string> strList2 = new List<string>(){"Four", "Five", "Six", "Seven", "Eight"};
		
            var result = strList1.Except(strList2);
		
            foreach(string str in result)
                Console.WriteLine(str);
        }
    }
}