using System;
using System.Collections.Generic;
using System.Linq;

namespace Example.LinqQuery
{
    public class Concat
    {
        /// <summary>
        /// The Concat() method appends two sequences of the same type and returns a new sequence (collection).
        /// </summary>
        public void Example()
        {
            IList<string> collection1 = new List<string>() {"One", "Two", "Three"};
            IList<string> collection2 = new List<string>() {"Five", "Six"};

            var concateResult = collection1.Concat(collection2);

            foreach (string str in concateResult)
                Console.WriteLine(str);
        }
    }
}