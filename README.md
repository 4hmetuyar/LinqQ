## LINQ (Language Integrated Query)

IEnumerable koleksiyonuna veya IQueryable veri kaynaklarına LINQ sorgusu yazmanın iki temel yolu vardır.

### 1.Query Syntax (Sorgu Sözdizimi)
```Csharp
from <range variable> in <IEnumerable<T> or IQueryable<T> Collection>

<Standard Query Operators> <lambda expression>

<select or groupBy operator> <result formation>
```

```Csharp
// string collection
IList<string> stringList = new List<string>() { 
    "C# Tutorials",
    "VB.NET Tutorials",
    "Learn C++",
    "MVC Tutorials" ,
    "Java" 
};

// LINQ Query Syntax
var result = from s in stringList
            where s.Contains("Tutorials") 
            select s;
            
```


``` Csharp

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
                      
```

### OfType in Query Syntax (Tipi bilinen Sorgu Sözdizimi)



```Csharp

IList mixedList = new ArrayList();
mixedList.Add(0);
mixedList.Add("One");
mixedList.Add("Two");
mixedList.Add(3);
mixedList.Add(new Student() { StudentID = 1, StudentName = "Bill" });

var stringResult = from s in mixedList.OfType<string>()
                select s;

var intResult = from s in mixedList.OfType<int>()
                select s;
```

### Standard Query Operators (Standart Sorgu Operatörleri)
#### 1.Where
```Csharp
IList<Student> studentList = new List<Student>() { 
        new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
        new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
        new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
        new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
        new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 } 
    };

var filteredResult = from s in studentList
                    where s.Age > 12 && s.Age < 20
                    select s.StudentName;

```
#### 2.OrderBy
```Csharp
IList<Student> studentList = new List<Student>() { 
    new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
    new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
    new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
    new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
    new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 } 
};

var orderByResult = from s in studentList
                   orderby s.StudentName 
                   select s;

var orderByDescendingResult = from s in studentList
                   orderby s.StudentName descending
                   select s;
```
#### 3.Join
```Csharp
IList<Student> studentList = new List<Student>() { 
    new Student() { StudentID = 1, StudentName = "John", StandardID =1 },
    new Student() { StudentID = 2, StudentName = "Moin", StandardID =1 },
    new Student() { StudentID = 3, StudentName = "Bill", StandardID =2 },
    new Student() { StudentID = 4, StudentName = "Ram" , StandardID =2 },
    new Student() { StudentID = 5, StudentName = "Ron"  } 
};

IList<Standard> standardList = new List<Standard>() { 
    new Standard(){ StandardID = 1, StandardName="Standard 1"},
    new Standard(){ StandardID = 2, StandardName="Standard 2"},
    new Standard(){ StandardID = 3, StandardName="Standard 3"}
};

var innerJoin = studentList.Join(// outer sequence 
                      standardList,  // inner sequence 
                      student => student.StandardID,    // outerKeySelector
                      standard => standard.StandardID,  // innerKeySelector
                      (student, standard) => new  // result selector
                                    {
                                        StudentName = student.StudentName,
                                        StandardName = standard.StandardName
                                    });
```
#### 4.Distinct
```Csharp
IList<Student> studentList = new List<Student>() { 
        new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
        new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
        new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
        new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
        new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
        new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
        new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 } 
    };


var distinctStudents = studentList.Distinct(new StudentComparer()); 
```
#### 5.Take & TakeWhile
```Csharp
IList<string> strList = new List<string>(){ "One", "Two", "Three", "Four", "Five" };

var newList = strList.Take(2);
```

```Csharp
IList<string> strList = new List<string>() { 
                                            "Three", 
                                            "Four", 
                                            "Five", 
                                            "Hundred"  };

var result = strList.TakeWhile(s => s.Length > 4);
```
#### 6.Let
```Csharp
var lowercaseStudentNames = from s in studentList
                            let lowercaseStudentName = s.StudentName.ToLower()
                                where lowercaseStudentName.StartsWith("r")
                                select lowercaseStudentName;

foreach (var name in lowercaseStudentNames)
	Console.WriteLine(name);
```
#### 7.Sum
```Csharp
IList<int> intList = new List<int>() { 10, 21, 30, 45, 50, 87 };

var total = intList.Sum();
```
#### 8.Max
```Csharp
IList<int> intList = new List<int>() { 10, 21, 30, 45, 50, 87 };

var largest = intList.Max();
```
#### 9.Concat
```Csharp
IList<string> collection1 = new List<string>() { "One", "Two", "Three" };
IList<string> collection2 = new List<string>() { "Five", "Six"};

var collection3 = collection1.Concat(collection2);

/* OutPut : 
    One
    Two
    Three
    Five
    Six 
*/
```
#### 10.DefaultIfEmpty
```Csharp
IList<Student> emptyStudentList = new List<Student>();

var newStudentList1 = studentList.DefaultIfEmpty(new Student());
                 
var newStudentList2 = studentList.DefaultIfEmpty(new Student(){ 
                StudentID = 0, 
                StudentName = "" });
```
#### 11.Except
```Csharp
IList<string> strList1 = new List<string>(){"One", "Two", "Three", "Four", "Five" };
IList<string> strList2 = new List<string>(){"Four", "Five", "Six", "Seven", "Eight"};

var result = strList1.Except(strList2);
/* Output : One Two Three */
```

#### 12. Intersect
```Csharp
IList<string> strList1 = new List<string>() { "One", "Two", "Three", "Four", "Five" };
IList<string> strList2 = new List<string>() { "Four", "Five", "Six", "Seven", "Eight"};

var result = strList1.Intersect(strList2);
/* Output : Four Five */
```
#### 13. Union
```Csharp
IList<string> strList1 = new List<string>() { "One", "Two", "three", "Four" };
IList<string> strList2 = new List<string>() { "Two", "THREE", "Four", "Five" };

var result = strList1.Union(strList2);
/* Output : One Two three THREE Four Five */
```
