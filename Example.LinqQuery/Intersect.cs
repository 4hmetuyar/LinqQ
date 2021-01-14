using System;
using System.Collections.Generic;
using System.Linq;

namespace Example.LinqQuery
{
    public class Intersect
    {
        /// <summary>
        /// The Intersect extension method requires two collections. It returns a new collection that includes common elements that exists in both the collection. Consider the following example.
        /// </summary>
        public void Example()
        {
            IList<string> strList1 = new List<string>() { "One", "Two", "Three", "Four", "Five" };
            IList<string> strList2 = new List<string>() { "Four", "Five", "Six", "Seven", "Eight"};
		
            var result = strList1.Intersect(strList2);
		
            foreach(string str in result)
                Console.WriteLine(str);
        }
    }
}