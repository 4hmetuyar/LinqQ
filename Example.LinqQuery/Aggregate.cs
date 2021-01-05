using System;
using System.Collections.Generic;
using System.Linq;

namespace Example.LinqQuery
{
    public class Aggregate
    {
        /// <summary>
        /// The aggregation operators perform mathematical operations like Average, Aggregate, Count, Max, Min and Sum, on the numeric property of the elements in the collection.
        /// </summary>
        public void Example()
        {
            IList<String> strList = new List<String>() { "One", "Two", "Three", "Four", "Five"};

            var commaSeperatedString = strList.Aggregate((s1, s2) => s1 + ", " + s2);

            Console.WriteLine(commaSeperatedString);
        }
    }
}