using System;
using System.Collections.Generic;
using System.Linq;
using Example.LinqQuery.Model;

namespace Example.LinqQuery
{
    public class Into
    {
        /// <summary>
        /// Use into keyword in LINQ query to form a group or to continue a query after a select clause.
        /// </summary>
        public void Example()
        {
            // Student collection
            IList<Student> studentList = new List<Student>()
            {
                new Student() {StudentID = 1, StudentName = "John", Age = 13},
                new Student() {StudentID = 2, StudentName = "Moin", Age = 21},
                new Student() {StudentID = 3, StudentName = "Bill", Age = 18},
                new Student() {StudentID = 4, StudentName = "Ram", Age = 20},
                new Student() {StudentID = 5, StudentName = "Ron", Age = 15}
            };

            var teenAgerStudents = from s in studentList
                where s.Age > 12 && s.Age < 20
                select s
                into teenStudents
                where teenStudents.StudentName.StartsWith("B")
                select teenStudents;


            foreach (Student std in teenAgerStudents)
            {
                Console.WriteLine(std.StudentName);
            }
        }
    }
}