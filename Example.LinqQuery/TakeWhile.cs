using System;
using System.Collections.Generic;
using System.Linq;

namespace Example.LinqQuery
{
    public class TakeWhile
    {
        /// <summary>
        /// The Take() extension method returns the specified number of elements starting from the first element.
        /// </summary>
        public void TakeExample()
        {
            IList<string> strList = new List<string>() {"One", "Two", "Three", "Four", "Five"};

            var newList = strList.Take(2);

            foreach (var str in newList)
                Console.WriteLine(str);
        }

        /// <summary>
        /// The TakeWhile() extension method returns elements from the given collection until the specified condition is true. If the first element itself doesn't satisfy the condition then returns an empty collection.
        /// </summary>
        public void TakeWhileExample()
        {
            IList<string> strList = new List<string>() {"Three", "Four", "Five", "Hundred"};

            var newList = strList.TakeWhile(s => s.Length > 4);

            foreach (var str in newList)
                Console.WriteLine(str);
        }

        /// <summary>
        /// The TakeWhile method has two overload methods. One method accepts the predicate of Func<TSource, bool> type and the other overload method accepts the predicate Func<TSource, int, bool> type that passes the index of element.
        /// </summary>
        public void TakeWhileExampleTwo()
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

            var resultList = strList.TakeWhile((s, i) => s.Length > i);

            foreach (string str in resultList)
                Console.WriteLine(str);
        }
    }
}