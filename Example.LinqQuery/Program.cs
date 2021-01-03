using System;
using System.Linq;

namespace Example.LinqQuery
{
    class Program
    {
        /// <summary>
        /// This example is where
        /// </summary>
        static readonly WhereExample WhereExample = new WhereExample();
        
        /// <summary>
        /// This example is typeOf
        /// </summary>
        static readonly TypeOfExample TypeOfExample  = new TypeOfExample();
        
        
        /// <summary>
        /// 
        /// </summary>
        static readonly OrderBy OrderBy  = new OrderBy();
        
        
        static readonly ThenBy ThenBy  = new ThenBy();
        
        
        static void Main(string[] args)
        {
            // WhereExample.Example();
            // TypeOfExample.Example();
            // OrderBy.Example();
            ThenBy.Example();
        }
    }
}