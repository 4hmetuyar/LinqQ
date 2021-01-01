using System;
using System.Linq;

namespace Example.LinqQuery
{
    class Program
    {
        class Plant
        {
            public string Name { get; set; }
        }
        
        class CarnivorousPlant : Plant
        {
            public string TrapType { get; set; }
        }
        
        static void Main(string[] args)
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
                    Console.WriteLine(plant.Name);
            
            Console.WriteLine("Hello World!");
        }
        
        
    }
}