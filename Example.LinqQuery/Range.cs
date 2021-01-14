using System;
using System.Linq;

namespace Example.LinqQuery
{
    public class Range
    {
        /// <summary>
        /// The Range() method returns a collection of IEnumerable<T> type with specified number of elements and sequential values starting from the first element.
        /// </summary>
        public void Example()
        {
            var intCollection = Enumerable.Range(10, 10);
            Console.WriteLine("Total Count: {0} ", intCollection.Count());

            for (int i = 0; i < intCollection.Count(); i++)
                Console.WriteLine("Value at index {0} : {1}", i, intCollection.ElementAt(i));
        }
    }
}