using System;
using System.Collections.Generic;
using System.Linq;
using Example.LinqQuery.Model;

namespace Example.LinqQuery
{
    public class Let
    {
        /// <summary>
        /// As you can see, the ToLower() method is used multiple times in the above query.
        /// The following example use 'let' to introduce new variable 'lowercaseStudentName' that will be then used in every where.
        /// Thus, let keyword to make the query more readable.
        /// </summary>
        public void Example()
        {
            IList<Student> studentList = new List<Student>()
            {
                new Student() {StudentID = 1, StudentName = "John", Age = 13},
                new Student() {StudentID = 2, StudentName = "Steve", Age = 15},
                new Student() {StudentID = 3, StudentName = "Bill", Age = 18},
                new Student() {StudentID = 4, StudentName = "Ram", Age = 12},
                new Student() {StudentID = 5, StudentName = "Ron", Age = 21}
            };

            var lowercaseStudentNames = from s in studentList
                let lowercaseStudentName = s.StudentName.ToLower()
                where lowercaseStudentName.StartsWith("r")
                select lowercaseStudentName;


            foreach (var name in lowercaseStudentNames)
                Console.WriteLine(name);
        }
    }
}