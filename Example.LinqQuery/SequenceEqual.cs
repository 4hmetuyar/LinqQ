using System;
using System.Collections.Generic;
using System.Linq;

namespace Example.LinqQuery
{
    public class SequenceEqual
    {
        /// <summary>
        /// There is only one equality operator: SequenceEqual. The SequenceEqual method checks whether the number of elements, value of each element and order of elements in two collections are equal or not.
        /// </summary>
        public void Example()
        {
            IList<string> strList1 = new List<string>(){"One", "Two", "Three", "Four", "Three"};

            IList<string> strList2 = new List<string>(){"One", "Two", "Three", "Four", "Three"};
		
            bool isEqual = strList1.SequenceEqual(strList2); 
		
            Console.WriteLine(isEqual); // This value : True
            
            
            IList<string> strList3 = new List<string>(){"One", "Two", "Three", "Four", "Three"};

            IList<string> strList4 = new List<string>(){"Two","One",  "Three", "Four", "Three"};
		
            bool isEqual2 = strList3.SequenceEqual(strList4); 
		
            Console.WriteLine(isEqual2); //This value : False
        }
    }
}