using System;
using System.Collections.Generic;
using System.Linq;
using Example.LinqQuery.Model;

namespace Example.LinqQuery
{
    public class Any
    {
        /// <summary>
        /// Any checks whether any element satisfy given condition or not? In the following example,
        /// Any operation is used to check whether any student is teen ager or not.
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
		
            // checks whether any of the students is teenager   
            bool isAnyStudentTeenAger = studentList.Any(s => s.Age > 12 && s.Age < 20);

		
            Console.WriteLine(isAnyStudentTeenAger);
        }
    }
}