using System;
using System.Linq;

namespace Example.LinqQuery
{
    public class Repeat
    {
        /// <summary>
        /// The Repeat() method generates a collection of IEnumerable<T> type with specified number of elements and each element contains same specified value.
        /// </summary>
        public void Example()
        {
            var intCollection = Enumerable.Repeat<int>(10, 10);
            Console.WriteLine("Total Count: {0} ", intCollection.Count());
		
            for(int i = 0; i < intCollection.Count(); i++)
                Console.WriteLine("Value at index {0} : {1}", i, intCollection.ElementAt(i));

        }
    }
}