using System;
using System.Linq;

namespace Example.LinqQuery
{
    class Program
    {
        static readonly WhereExample WhereExample = new WhereExample();
        static void Main(string[] args)
        {
            WhereExample.Example();
        }
    }
}