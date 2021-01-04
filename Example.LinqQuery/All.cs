using System;
using System.Collections.Generic;
using System.Linq;
using Example.LinqQuery.Model;

namespace Example.LinqQuery
{
    public class All
    {
        /// <summary>
        /// The quantifier operators evaluate elements of the sequence on some condition and return a boolean value to indicate that some or all elements satisfy the condition.
        /// </summary>
        public void Example()
        {
            IList<Student> studentList = new List<Student>() { 
                new Student() { StudentID = 1, StudentName = "John", Age = 13 } ,
                new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 } 
            };		
		
            // checks whether all the students are teenagers    
            bool areAllStudentsTeenAger = studentList.All(s => s.Age > 12 && s.Age < 20);
		
		
            Console.WriteLine(areAllStudentsTeenAger);
        }
    }
}