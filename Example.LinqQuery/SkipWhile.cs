using System;
using System.Collections.Generic;
using System.Linq;

namespace Example.LinqQuery
{
    public class SkipWhile
    {
        /// <summary>
        /// The Skip() method skips the specified number of element starting from first element and returns rest of the elements.
        /// </summary>
        public void SkipExample()
        {
            IList<string> strList = new List<string>() {"One", "Two", "Three", "Four", "Five"};

            var result = strList.Skip(2);

            foreach (var str in result)
                Console.WriteLine(str);
        }

        /// <summary>
        /// As the name suggests, the SkipWhile() extension method in LINQ skip elements in the collection till the specified condition is true.
        /// It returns a new collection that includes all the remaining elements once the specified condition becomes false for any element.
        /// </summary>
        public void SkipWhileExample()
        {
            IList<string> strList = new List<string>()
            {
                "One",
                "Two",
                "Three",
                "Four",
                "Five",
                "Six"
            };

            var result = strList.SkipWhile(s => s.Length < 4);

            foreach (string str in result)
                Console.WriteLine(str);
        }
    }
}