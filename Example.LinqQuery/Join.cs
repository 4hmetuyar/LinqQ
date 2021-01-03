using System;
using System.Collections.Generic;
using System.Linq;
using Example.LinqQuery.Model;

namespace Example.LinqQuery
{
    public class Join
    {
        public void Example()
        {
            // Student collection
            IList<string> strList1 = new List<string>
            {
                "One",
                "Two",
                "Three",
                "Four"
            };

            IList<string> strList2 = new List<string>
            {
                "One",
                "Two",
                "Five",
                "Six"
            };

            var innerJoinResult = strList1.Join( // outer sequence 
                strList2, // inner sequence 
                str1 => str1, // outerKeySelector
                str2 => str2, // innerKeySelector
                (str1, str2) => str1);

            foreach (var str in innerJoinResult) Console.WriteLine("{0} ", str);
        }

        /// <summary>
        ///     let's understand join metohod using following Student and Standard class where Student class includes StandardID
        ///     that matches with StandardID of Standard class.
        /// </summary>
        public void ExampleTwo()
        {
            // Student collection
            IList<Student> studentList = new List<Student>
            {
                new Student {StudentID = 1, StudentName = "John", Age = 18, StandardID = 1},
                new Student {StudentID = 2, StudentName = "Steve", Age = 21, StandardID = 1},
                new Student {StudentID = 3, StudentName = "Bill", Age = 18, StandardID = 2},
                new Student {StudentID = 4, StudentName = "Ram", Age = 20, StandardID = 2},
                new Student {StudentID = 5, StudentName = "Ron", Age = 21}
            };

            IList<Standard> standardList = new List<Standard>
            {
                new Standard {StandardID = 1, StandardName = "Standard 1"},
                new Standard {StandardID = 2, StandardName = "Standard 2"},
                new Standard {StandardID = 3, StandardName = "Standard 3"}
            };

            var innerJoinResult = studentList.Join( // outer sequence 
                standardList, // inner sequence 
                student => student.StandardID, // outerKeySelector
                standard => standard.StandardID, // innerKeySelector
                (student, standard) => new // result selector
                {
                    student.StudentName, standard.StandardName
                });

            foreach (var obj in innerJoinResult) Console.WriteLine("{0} - {1}", obj.StudentName, obj.StandardName);
        }
    }
}