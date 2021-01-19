using System;
using System.Collections.Generic;
using System.Linq;

namespace Example.LinqQuery
{
    public class LastOrDefault
    {
        /// <summary>
        /// Last and LastOrDefault has two overload methods. One overload method doesn't take any input parameter and returns last element from the collection.
        /// Second overload method takes a lambda expression to specify a condition and returns last element that satisfies the specified condition.
        /// </summary>
        public void LastExample()
        {
            IList<int> intList = new List<int>() {7, 10, 21, 30, 45, 50, 87};
            IList<string> strList = new List<string>() {null, "Two", "Three", "Four", "Five"};
            IList<string> emptyList = new List<string>();

            Console.WriteLine("Last Element in intList: {0}", intList.Last());
            Console.WriteLine("Last Even Element in intList: {0}", intList.Last(i => i % 2 == 0));

            Console.WriteLine("Last Element in strList: {0}", strList.Last());

            Console.WriteLine("emptyList.Last() throws an InvalidOperationException");
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine(emptyList.Last());
        }

        /// <summary>
        /// The LastOrDefault() method does the same thing as Last() method.
        /// The only difference is that it returns default value of the data type of a collection if a collection is empty or doesn't find any element that satisfies the condition.
        /// </summary>
        public void LastOrDefaultExample()
        {
            IList<int> intList = new List<int>() {7, 10, 21, 30, 45, 50, 87};
            IList<string> strList = new List<string>() {null, "Two", "Three", "Four", "Five"};
            IList<string> emptyList = new List<string>();

            Console.WriteLine("Last Element in intList: {0}", intList.LastOrDefault());

            Console.WriteLine("Last Even Element in intList: {0}",
                intList.LastOrDefault(i => i % 2 == 0));

            Console.WriteLine("Last Element in strList: {0}", strList.LastOrDefault());

            Console.WriteLine("Last Element in emptyList: {0}", emptyList.LastOrDefault());
        }
    }
}