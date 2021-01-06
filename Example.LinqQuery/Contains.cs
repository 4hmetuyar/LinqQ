using System;
using System.Collections.Generic;

namespace Example.LinqQuery
{
    public class Contains
    {
        /// <summary>
        /// The Contains operator checks whether a specified element exists in the collection or not and returns a boolean.
        /// </summary>
        public void Example()
        {
            IList<int> intList = new List<int>() { 1, 2, 3, 4, 5 };
		
            bool result = intList.Contains(10); 
		
            Console.WriteLine(result);

        }
    }
}