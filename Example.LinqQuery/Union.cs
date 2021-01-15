using System;
using System.Collections.Generic;
using System.Linq;
using Example.LinqQuery.Helper;
using Example.LinqQuery.Model;

namespace Example.LinqQuery
{
    public class Union
    {
        /// <summary>
        /// The Union extension method requires two collections and returns a new collection that includes distinct elements from both the collections. Consider the following example.
        /// </summary>
        public void Example()
        {
            IList<string> strList1 = new List<string>() {"One", "Two", "three", "Four"};
            IList<string> strList2 = new List<string>() {"Two", "THREE", "Four", "Five"};

            var result = strList1.Union(strList2);

            foreach (string str in result)
                Console.WriteLine(str);
        }

        public void ExampleTwo()
        {
            IList<Student> studentList1 = new List<Student>() { 
                new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 } 
            };
	
            IList<Student> studentList2 = new List<Student>() { 
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 } 
            };
		
            var result = studentList1.Union(studentList2,new StudentComparer()); 
		
            foreach(var std in result)
                Console.WriteLine(std.StudentName);
        }
    }
}