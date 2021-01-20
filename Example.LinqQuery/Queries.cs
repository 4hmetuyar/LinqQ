using System;
using System.Collections.Generic;
using System.Linq;
using Example.LinqQuery.Model;

namespace Example.LinqQuery
{
    public class Queries
    {
        /// <summary>
        /// In this section, you will learn some complex LINQ queries. We will use the following Student and Standard collection for our queries.
        /// </summary>
        public void Example()
        {
            // Student collection
            IList<Student> studentList = new List<Student>()
            {
                new Student() {StudentID = 1, StudentName = "John", Age = 18, StandardID = 1},
                new Student() {StudentID = 2, StudentName = "Steve", Age = 21, StandardID = 1},
                new Student() {StudentID = 3, StudentName = "Bill", Age = 18, StandardID = 2},
                new Student() {StudentID = 4, StudentName = "Ram", Age = 20, StandardID = 2},
                new Student() {StudentID = 5, StudentName = "Ron", Age = 21}
            };

            var studentNames = studentList.Where(s => s.Age > 18)
                .Select(s => s)
                .Where(st => st.StandardID > 0)
                .Select(s => s.StudentName);


            foreach (var name in studentNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}