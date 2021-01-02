using System;
using System.Collections;
using System.Linq;

namespace Example.LinqQuery
{
    public class TypeOfExample
    {
        public class Student{

            public int StudentID { get; set; }
            public string StudentName { get; set; }
            public int Age { get; set; }
	
        }
        /// <summary>
        /// The OfType operator filters the collection based on the ability to cast an element in a collection to a specified type.
        /// </summary>
        public void Example()
        {
            IList mixedList = new ArrayList();
            mixedList.Add(0);
            mixedList.Add("One");
            mixedList.Add("Two");
            mixedList.Add(3);
            mixedList.Add(new Student() { StudentID = 1, StudentName = "Bill" });
		
            var stringResult = from s in mixedList.OfType<string>()
                select s;
		
            var intResult = from s in mixedList.OfType<int>()
                select s;
		
            var stdResult = from s in mixedList.OfType<Student>()
                select s;
		
            foreach (var str in stringResult)
                Console.WriteLine($"String Example : {str}");
		
            foreach (var integer in intResult)
                Console.WriteLine($"Integer Example : {integer}");
		
            foreach (var std in stdResult)
                Console.WriteLine(std.StudentName);

        }
    }
}