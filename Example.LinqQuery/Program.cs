using System;
using System.Linq;

namespace Example.LinqQuery
{
    class Program
    {
        static readonly WhereExample WhereExample = new WhereExample();
        static readonly TypeOfExample TypeOfExample  = new TypeOfExample();
        static void Main(string[] args)
        {
            WhereExample.Example();
            TypeOfExample.Example();
        }
    }
}