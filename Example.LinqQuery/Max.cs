using System;
using System.Collections.Generic;
using System.Linq;

namespace Example.LinqQuery
{
    public class Max
    {
        /// <summary>
        ///     The Max() method returns the largest numeric element from a collection.
        /// </summary>
        public void Example()
        {
            IList<int> intList = new List<int> {10, 21, 30, 45, 50, 87};

            var largest = intList.Max();

            Console.WriteLine("Largest Element: {0}", largest);

            var largestEvenElements = intList.Max(i =>
            {
                if (i % 2 == 0)
                    return i;

                return 0;
            });

            Console.WriteLine("Largest Even Element: {0}", largestEvenElements);
        }
    }
}