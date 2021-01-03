using System;
using System.Collections.Generic;
using System.Linq;
using Example.LinqQuery.Model;

namespace Example.LinqQuery
{
    public class GroupBy
    {
        /// <summary>
        /// The GroupBy operator returns a group of elements from the given collection based on some key value.
        /// Each group is represented by IGrouping<TKey, TElement> object.
        /// Also, the GroupBy method has eight overload methods, so you can use appropriate extension method based on your requirement in method syntax.
        /// </summary>
        public void Example()
        {
            // Student collection
            IList<Student> studentList = new List<Student>() { 
                new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 21 } 
            };
		
            var groupedResult = from s in studentList
                group s by s.Age;
            //iterate each group        
            foreach (var ageGroup in groupedResult)
            {
                Console.WriteLine("Age Group: {0}", ageGroup.Key); //Each group has a key 
					 
                foreach(Student s in ageGroup) // Each group has inner collection
                    Console.WriteLine("Student Name: {0}", s.StudentName);
            }            
        }
    }
}