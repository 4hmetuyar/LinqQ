using System;
using System.Collections.Generic;
using System.Linq;

namespace Example.LinqQuery
{
    public class Count
    {
        /// <summary>
        /// The Count operator returns the number of elements in the collection or number of elements that have satisfied the given condition.
        /// </summary>
        public void Example()
        {
            IList<int> intList = new List<int>(){ 10, 21, 30, 45, 50 };

            var totalElements = intList.Count();
		
            Console.WriteLine("Total Elements: {0}", totalElements);
		
            var evenElements = intList.Count(i => i%2 == 0);
		
            Console.WriteLine("Even Elements: {0}", evenElements);
        }
    }
}