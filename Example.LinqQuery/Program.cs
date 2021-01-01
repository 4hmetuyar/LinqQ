using System;
using System.Linq;

namespace Example.LinqQuery
{
    class Program
    {
     
        static void Main(string[] args)
        {
            

            ExampleOne();
        }


        /// <summary>
        /// Where example
        /// </summary>
        private static void ExampleOne()
        {
            var list = new int[] { 1, 3, 33, 44, 56, 101 };
 
            var oddNumbers =
                from number in list
                where number % 2 == 1
                select number;
 
            foreach (var value in oddNumbers)   
            {
                Console.WriteLine(value);
            }
 
            Console.ReadKey();
        }
        
        class Plant
        {
            public string Name { get; set; }
        }
        
        class CarnivorousPlant : Plant
        {
            public string TrapType { get; set; }
        }

        
        /// <summary>
        /// 
        /// </summary>
        private static void ExampleTwo()
        {
        Plant[] plants = new Plant[] {
            new CarnivorousPlant { Name = "Venus Fly Trap", TrapType = "Snap Trap" },
            new CarnivorousPlant { Name = "Pitcher Plant", TrapType = "Pitfall Trap" },
            new CarnivorousPlant { Name = "Sundew", TrapType = "Flypaper Trap" },
            new CarnivorousPlant { Name = "Waterwheel Plant", TrapType = "Snap Trap" }
        };
            
        var query = from CarnivorousPlant cPlant in plants
                where cPlant.TrapType == "Snap Trap"
                select cPlant;

        foreach (Plant plant in query)
        {
            Console.WriteLine(plant.Name);
        }
             

        }
        
    }
}