using System;
using System.Collections.Generic;
using System.Linq;
using Example.LinqQuery.Model;

namespace Example.LinqQuery
{
    public class WhereExample
    {
        /// <summary>
        /// The following query sample uses a Where operator to filter the students who is teen ager from the given collection (sequence).
        /// It uses a lambda expression as a predicate function.
        /// </summary>
        public void Example()
        {
            // Student collection
            IList<Student> studentList = new List<Student>() { 
                new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
                new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 } 
            };
		
            // LINQ Query Syntax to find out teenager students
            var teenAgerStudent = from s in studentList
                where s.Age > 12 && s.Age < 20
                select s;
            Console.WriteLine("Teen age Students:");
						  
            foreach(Student std in teenAgerStudent){			
                Console.WriteLine(std.StudentName);
            }
        }
    }
}