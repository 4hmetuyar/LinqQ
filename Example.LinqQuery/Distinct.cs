using System;
using System.Collections.Generic;
using System.Linq;
using Example.LinqQuery.Helper;
using Example.LinqQuery.Model;

namespace Example.LinqQuery
{
   
    public class Distinct
    {
        /// <summary>
        /// The Distinct extension method returns a new collection of unique elements from the given collection.
        /// </summary>
        public void Example()
        {
            IList<string> strList = new List<string>() {"One", "Two", "Three", "Two", "Three"};

            IList<int> intList = new List<int>() {1, 2, 3, 2, 4, 4, 3, 5};

            var distinctList1 = strList.Distinct();

            foreach (var str in distinctList1)
                Console.WriteLine(str);

            var distinctList2 = intList.Distinct();

            foreach (var i in distinctList2)
                Console.WriteLine(i);
        }

        /// <summary>
        /// Now, you can pass an object of the above StudentComparer class in the Distinct() method as a parameter to compare the Student objects as shown below.
        /// </summary>
        public void ExampleTwo()
        {
            IList<Student> studentList = new List<Student>()
            {
                new Student() {StudentID = 1, StudentName = "John", Age = 18},
                new Student() {StudentID = 2, StudentName = "Steve", Age = 15},
                new Student() {StudentID = 3, StudentName = "Bill", Age = 25},
                new Student() {StudentID = 3, StudentName = "Bill", Age = 25},
                new Student() {StudentID = 3, StudentName = "Bill", Age = 25},
                new Student() {StudentID = 3, StudentName = "Bill", Age = 25},
                new Student() {StudentID = 5, StudentName = "Ron", Age = 19}
            };


            var distinctStudents = studentList.Distinct(new StudentComparer());

            foreach (var std in distinctStudents)
                Console.WriteLine(std.StudentName);
        }
    }
}