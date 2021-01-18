using System;
using System.Collections.Generic;
using System.Linq;

namespace Example.LinqQuery
{
    public class FirstOrDefault
    {
        /// <summary>
        /// The First and FirstOrDefault method returns an element from the zeroth index in the collection i.e. the first element. Also, it returns an element that satisfies the specified condition.
        /// </summary>
        public void FirstExample()
        {
            IList<int> intList = new List<int>() {7, 10, 21, 30, 45, 50, 87};
            IList<string> strList = new List<string>() {null, "Two", "Three", "Four", "Five"};
            IList<string> emptyList = new List<string>();

            Console.WriteLine("1st Element in intList: {0}", intList.First());
            Console.WriteLine("1st Even Element in intList: {0}", intList.First(i => i % 2 == 0));

            Console.WriteLine("1st Element in strList: {0}", strList.First());

            Console.WriteLine("emptyList.First() throws an InvalidOperationException");
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine(emptyList.First());
        }

        /// <summary>
        /// Be careful while specifying condition in First() or FirstOrDefault(). First() will throw an exception if a collection does not include any element that satisfies the specified condition or includes null element.
        /// </summary>
        public void FirstOrDefaultExample()
        {
            IList<int> intList = new List<int>() {7, 10, 21, 30, 45, 50, 87};
            IList<string> strList = new List<string>() {null, "Two", "Three", "Four", "Five"};
            IList<string> emptyList = new List<string>();

            Console.WriteLine("1st Element in intList: {0}", intList.FirstOrDefault());

            Console.WriteLine("1st Even Element in intList: {0}", intList.FirstOrDefault(i => i % 2 == 0));

            Console.WriteLine("1st Element in strList: {0}", strList.FirstOrDefault());

            Console.WriteLine("1st Element in emptyList: {0}", emptyList.FirstOrDefault());
        }
    }
}