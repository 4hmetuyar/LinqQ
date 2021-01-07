using System;
using System.Collections.Generic;
using System.Linq;
using Example.LinqQuery.Model;

namespace Example.LinqQuery
{
    public class GroupJoin
    {
        /// <summary>
        /// We have seen the Join operator in the previous section.
        /// The GroupJoin operator performs the same task as Join operator except that GroupJoin returns a result in group based on specified group key.
        /// The GroupJoin operator joins two sequences based on key and groups the result by matching key and then returns the collection of grouped result and key.
        /// </summary>
        public void Example()
        {
            // Student collection
            IList<Student> studentList = new List<Student>() { 
                new Student() { StudentID = 1, StudentName = "John", Age = 18, StandardID = 1 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 21, StandardID = 1 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 18, StandardID = 2 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20, StandardID = 2 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 21 } 
            };
		
            IList<Standard> standardList = new List<Standard>() { 
                new Standard(){ StandardID = 1, StandardName="Standard 1"},
                new Standard(){ StandardID = 2, StandardName="Standard 2"},
                new Standard(){ StandardID = 3, StandardName="Standard 3"}
            };
		
            var groupJoin = standardList.GroupJoin(studentList,  //inner sequence
                std => std.StandardID, //outerKeySelector 
                s => s.StandardID,     //innerKeySelector
                (std, studentsGroup) => new // resultSelector 
                {
                    Students = studentsGroup,
                    StandarFulldName = std.StandardName
                });

            foreach (var item in groupJoin)
            { 
                Console.WriteLine(item.StandarFulldName );
			
                foreach(var stud in item.Students)
                    Console.WriteLine(stud.StudentName);
            }
        }
    }
}