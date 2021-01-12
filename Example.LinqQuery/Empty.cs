using System;
using System.Linq;
using Example.LinqQuery.Model;

namespace Example.LinqQuery
{
    public class Empty
    {
        /// <summary>
        /// The Empty() method is not an extension method of IEnumerable or IQueryable like other LINQ methods.
        /// It is a static method included in Enumerable static class. So, you can call it the same way as other static methods like Enumerable.Empty<TResult>().
        /// The Empty() method returns an empty collection of a specified type as shown below.
        /// </summary>
        public void Example()
        {
            var emptyCollection1 = Enumerable.Empty<string>();
            var emptyCollection2 = Enumerable.Empty<Student>();
        
            Console.WriteLine("Type: {0}", emptyCollection1.GetType().Name);
            Console.WriteLine("Count: {0}", emptyCollection1.Count());
		
            Console.WriteLine("Type: {0}", emptyCollection2.GetType().Name);
            Console.WriteLine("Count: {0}", emptyCollection2.Count());		
        }
    }
}