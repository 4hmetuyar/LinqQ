using System;
using System.Collections.Generic;
using System.Linq;
using Example.LinqQuery.Model;

namespace Example.LinqQuery
{
    public class Select
    {
        /// <summary>
        /// The Select operator always returns an IEnumerable collection which contains elements based on a transformation function.
        /// It is similar to the Select clause of SQL that produces a flat result set.
        /// </summary>
        public void Example()
        {
            // Student collection
            IList<Student> studentList = new List<Student>() { 
                new Student() { StudentID = 1, StudentName = "John" } ,
                new Student() { StudentID = 2, StudentName = "Moin" } ,
                new Student() { StudentID = 3, StudentName = "Bill" } ,
                new Student() { StudentID = 4, StudentName = "Ram" } ,
                new Student() { StudentID = 5, StudentName = "Ron"  } 
            };
		
            var selectResult = from s in studentList
                select s.StudentName;
						  
            foreach(var name in selectResult){			
                Console.WriteLine(name);
            }
        }
    }
}