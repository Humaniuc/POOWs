using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using HelperClasses;

namespace LINQexamples
{
    class Program
    {
        delegate bool IsYoungerThan(Student stud, int youngAge);
        delegate bool IsYounger(Student stud);
        delegate void Print();
        static void Main(string[] args)
        {
            string[] names = { "Bill", "Steve", "James", "Mokhan" };
            var myLinqQuery = from name in names
                              where name.Contains('a')
                              select name;
            foreach (var name in myLinqQuery)
            {
                Console.Write(name + " ");
            }
            Console.WriteLine();

            Student[] studentArray =
            {
                new Student() {StudentId = 1, StudentName = "John", Age = 18, StandardId = 1},
                new Student() {StudentId = 2, StudentName = "Steve", Age = 21, StandardId = 1},
                new Student() {StudentId = 3, StudentName = "Bill", Age = 25, StandardId = 2},
                new Student() {StudentId = 4, StudentName = "Ram", Age = 20, StandardId = 3},
                new Student() {StudentId = 5, StudentName = "Ron", Age = 31, StandardId = 3},
                new Student() {StudentId = 6, StudentName = "Chris", Age = 17, StandardId = 2},
                new Student() {StudentId = 7, StudentName = "Rob", Age = 19}
            };
            //Use LINQ to find teenages students
            Student[] teenAgerStudents = studentArray.Where(s => s.Age > 12 && s.Age < 20).ToArray();

            //Use LINQ to find first student whose name is Bill
            Student bill = studentArray.Where(s => s.StudentName == "Bill").FirstOrDefault();
            //Use  LINQ to find whose StudentID is 5
            Student student5 = studentArray.Where(s => s.StudentId == 5).FirstOrDefault();

            //string collection
            IList<string> stringList = new List<string>()
            {
                "C# Tutorials",
                "VB.NET Tutorials",
                "Learn C++",
                "MVC Tutorials",
                "Java"
            };
            var result = from s in stringList
                         where s.Contains("Tutorials")
                         select s;
            Console.WriteLine("\nTutorials: ");
            foreach (var str in result)
            {
                Console.WriteLine(str);
            }

            //LINQ Query Syntax to find teenager students
            var teenAgerStudent = from s in studentArray
                                  where s.Age > 12 && s.Age < 20
                                  select s;
            Console.WriteLine("\nTeen Age Students: ");
            foreach (Student std in teenAgerStudent)
            {
                Console.WriteLine(std.StudentName);
            }

            //LINQ Method Syntax
            result = stringList.Where(s => s.Contains("Tutorials"));
            Console.WriteLine("\nStrings contains word Tutorials");
            foreach (string str in result)
            {
                Console.WriteLine(str);
            }

            //LINQ Method Syntax to find out teenager students
            teenAgerStudent = studentArray.Where(s => s.Age > 12 && s.Age < 20).ToList<Student>();
            Console.WriteLine("\nTeenAgers Students: ");
            foreach (Student s in teenAgerStudent)
            {
                Console.WriteLine($"{s.StudentName} has {s.Age} years");
            }

            //Specify Multiple parameters in lambda expression
            IsYoungerThan isYoungerThan = (s, youngAge) => s.Age < youngAge;
            //Specify Parameter type
            isYoungerThan = (Student s, int youngAge) => s.Age < youngAge;
            Student stud = new Student() { Age = 25 };
            Console.WriteLine("Is Younger than 26 years: " + isYoungerThan(stud, 26));

            //Lambda expression without parameters
            Print print = () => Console.WriteLine("This is parameter less lambda expression");
            print();

            // Multiple statements in Lambda expression body
            isYoungerThan = (s, yougAge) =>
            {
                Console.WriteLine("Lambda expression with multiple statemets in the body");
                return s.Age >= yougAge;
            };
            Console.WriteLine("Is younger than 26 years: " + isYoungerThan(stud, 26));

            // declare local variable in lambda expression
            IsYounger isYounger = s =>
            {
                int youngAge = 18;
                Console.WriteLine("Lambda expression with multiple statemets in the body and local variable ");
                return s.Age >= youngAge;
            };
            Console.WriteLine("Is younger than 18?: " + isYounger(stud));

            // Lambda expression assigned to Func Delegate
            Func<Student, bool> isStudentTeenAger = s => s.Age > 12 && s.Age < 20;
            stud = new Student() { Age = 21 };
            Console.WriteLine("Is Student teenAger?: " + isStudentTeenAger(stud));

            // Lambda expression assigned to action delegate
            Action<Student> PrintStudentDetail = s => Console.WriteLine($"Name: {s.StudentName}, Age: {s.Age}");
            stud = new Student() { StudentName = "Bill", Age = 21 };
            PrintStudentDetail(stud);

            // Func delegate in LINQ Methos Syntax
            Func<Student, bool> isStudTeenAger = s => s.Age > 12 && s.Age < 20;
            var teenStudents = studentArray.Where(isStudTeenAger).ToList<Student>();
            Console.Write("TeenAge Students: ");
            foreach(Student s in teenStudents)
            {
                Console.Write($"{s.StudentName} ");
            }
            Console.WriteLine();

            // Func delegate in LINQ Query Syntax
            Func<Student, bool> isStudTeenAge = s => s.Age > 12 && s.Age < 20;
            var teenAgeStudents = from s in studentArray
                           where isStudTeenAge(s)
                           select s;
            Console.Write("TeenAge Students: ");
            foreach (Student s in teenAgeStudents)
            {
                Console.Write($"{s.StudentName} ");
            }
            Console.WriteLine();

            // where clause - LINQ query syntax
            var filteredResult = from s in studentArray
                                 where s.Age > 12 && s.Age < 20
                                 select s.StudentName;
            Console.WriteLine("TeenAgers Names list: ");
            foreach (var s in filteredResult)
            {
                Console.WriteLine(s + " ");
            }
            Console.WriteLine();

            // Where extension method in Method Syntax
            var filterResults = studentArray.Where(s => s.Age > 12 && s.Age < 20);

            // LINQ Where extension method with index parameter
            var filterResult = studentArray.Where((s, i) =>
            {
                if (i % 2 == 0)
                    return true;
                return false;
            });
            Console.WriteLine("Even id Students: ");
            foreach(var std in filterResult)
            {
                Console.Write(std.StudentName + " ");
            }
            Console.WriteLine();

            // Multiple where clause
            filterResult = from s in studentArray
                           where s.Age > 12
                           where s.Age < 20
                           select s;
            Console.Write("TeenAgers: ");
            foreach(var s in filterResult)
            {
                Console.Write(s.StudentName + " ");
            }
            Console.WriteLine();
            filterResult = studentArray.Where(s => s.Age > 12).Where(s => s.Age < 20);
            Console.Write("TeenAgers: ");
            foreach (var s in filterResult)
            {
                Console.Write(s.StudentName + " ");
            }
            Console.WriteLine();

            // Filtering Operator - OfType
            IList mixedList = new ArrayList();
            mixedList.Add(0);
            mixedList.Add("One");
            mixedList.Add("Two");
            mixedList.Add(3);
            mixedList.Add(new Student() { StudentId = 1, StudentName = "Bill" });

            var stringResult = from s in mixedList.OfType<string>()
                               select s;
            var intResult = from s in mixedList.OfType<int>()
                            select s;
            var stdResult = from s in mixedList.OfType<Student>()
                            select s;

            // OfType in method Syntax
            stringResult = mixedList.OfType<string>();
            intResult = mixedList.OfType<int>();

            // OrderBy in Query Syntax

            var orderByResult = from s in studentArray
                                orderby s.StudentName
                                select s;
            var orderByDescending = from s in studentArray
                                    orderby s.StudentName descending
                                    select s;

            // OrderBy in Method Syntax
            orderByResult = studentArray.OrderBy(s => s.StudentName);
            orderByDescending = studentArray.OrderByDescending(s => s.StudentName);

            // OrderBy multile sorting in Query Syntax
            var orderByResults = from s in studentArray
                            orderby s.StudentName, s.Age
                            select new { s.StudentName, s.Age };

            // ThenBy & ThenByDescending
            var thenByResult = studentArray.OrderBy(s => s.StudentName).ThenBy(s => s.Age);
            var thenByDescResult = studentArray.OrderBy(s => s.StudentName).ThenByDescending(s => s.Age);

            // GroupBy in Query Syntax
            var groupedResult = from s in studentArray
                                group s by s.Age;
            //iterate each group
            Console.WriteLine();
            foreach(var ageGroup in groupedResult)
            {
                Console.WriteLine("Age Group: {0}", ageGroup.Key); // each group has a key
                foreach(Student s in ageGroup)
                {
                    Console.WriteLine("Student Name: {0}", s.StudentName);
                }
            }

            // GroupBy in Method Syntax
            groupedResult = studentArray.GroupBy(s => s.Age);
            //iterate each group
            Console.WriteLine();
            foreach (var ageGroup in groupedResult)
            {
                Console.WriteLine("Age Group: {0}", ageGroup.Key); // each group has a key
                foreach (Student s in ageGroup)
                {
                    Console.WriteLine("Student Name: {0}", s.StudentName);
                }
            }

            // ToLookup in method syntax
            var lookupResult = studentArray.ToLookup(s => s.Age);
            foreach (var group in lookupResult)
            {
                Console.WriteLine("Age Group: {0}", group.Key); // each group has a key
                foreach (Student s in group)
                {
                    Console.WriteLine("Student Name: {0}", s.StudentName);
                }
            }

            // Join Operator
            IList<string> firstList = new List<string>()
            {
                "One",
                "Two",
                "Three",
                "Four"
            };
            IList<string> secondList = new List<string>()
            {
                "One",
                "Two",
                "Five",
                "Six"
            };
            var innerJoinResult = firstList.Join( // outer sequence
                secondList, // inner sequence
                str1 => str1, // outerKeySelector
                str2 => str2, // innerKeySelector
                (str1, str2) => str1);
            foreach(var str in innerJoinResult)
            {
                Console.WriteLine("{0} ", str);
            }

            //LINQ join method syntax
            IList<Student> studentList = studentArray;
            IList<Standard> standardList = new List<Standard>()
            {
                new Standard() {StandardId = 1, StandardName = "Standard 1"},
                new Standard() {StandardId = 2, StandardName = "Standard 2"},
                new Standard() {StandardId = 3, StandardName = "Standard 3"},
                new Standard() {StandardId = 4, StandardName = "Standard 4"},
            };
            var innerJoin = studentList.Join( // outer sequence
                   standardList, // inner sequence
                   student => student.StandardId, // outerKeySelector
                   standard => standard.StandardId, // innerKeySelector
                   (student, standard) => new // result selector
                   {
                       StudentName = student.StudentName,
                       StandardName = standard.StandardName
                   });
            foreach(var obj in innerJoin)
            {
                Console.WriteLine("{0} - {1}", obj.StudentName, obj.StandardName);
            }

            // inner Join in Query Syntax
            var innerQueryJoin = from s in studentList
                                 join st in standardList
                                 on s.StandardId equals st.StandardId
                                 select new
                                 {
                                     StudentName = s.StudentName,
                                     StandardName = st.StandardName
                                 };

            // GroupJoin in method syntax
            var groupJoin = standardList.GroupJoin(studentList,
                std => std.StandardId,
                s => s.StandardId,
                (std, studentsGroup) => new
                {
                    Students = studentsGroup,
                    StandardFullName = std.StandardName
                });
            Console.WriteLine("GroupJoin in method syntax");
            foreach(var item in groupJoin)
            {
                Console.WriteLine(item.StandardFullName );
                foreach(var student in item.Students)
                {
                    Console.WriteLine(student.StudentName);
                }
            }

            // GroupJoin in query syntax
            var groupQueryJoin = from std in standardList
                                 join s in studentList
                                 on std.StandardId equals s.StandardId
                                    into studentGroup
                                 select new
                                 {
                                     Students = studentGroup,
                                     StandardName = std.StandardName
                                 };
            Console.WriteLine("GroupJoin in query syntax");
            foreach(var item in groupQueryJoin)
            {
                Console.WriteLine(item.StandardName );
                foreach(var student in item.Students)
                {
                    Console.WriteLine(student.StudentName);
                }
            }

            // Select in Query Syntax
            var selectResult = from s in studentList
                               select new { Name = "Mr. " + s.StudentName, Age = s.Age };
            Console.WriteLine("\nSelect results: ");
            foreach(var item in selectResult)
            {
                Console.WriteLine("Student Name: {0}, Age: {1}", item.Name, item.Age);
            }

            // Select in Method Syntax
            var selectMethodSyntax = studentList.Select(s => new { Name = s.StudentName, Age = s.Age });

            // All operator method syntax, not suported in query syntax
            bool areAllStudentsTeenAger = studentList.All(s => s.Age > 12 && s.Age < 20);
            Console.WriteLine("areAllStudentsTeenAger?: " + areAllStudentsTeenAger);

            // Any operator in Method Syntax, not suported in query syntax
            bool areAnyStudentTeenAges = studentList.Any(s => s.Age > 12 && s.Age < 20);
            Console.WriteLine("areAnyStudentTeenAges?: " + areAnyStudentTeenAges);

            // Contain Operator on primitive data types
            IList<int> intList = new List<int>() { 1, 2, 3, 4, 5, 6 };
            bool containResult = intList.Contains(10);

            // Contain Operator on Object Data Types
            Student stude = new Student() { StudentId = 3, StudentName = "Bill" };
            var studentsContainResult = studentList.Contains(stude, new StudentComparer());
            Console.WriteLine($"StudentList Contain {stude.StudentName} student?: {studentsContainResult}");

            // Aggregate in method syntax
            IList<string> strList = new List<string>() { "One", "Two", "Three", "Four", "Five" };
            var commaSeparatedString = strList.Aggregate((s1, s2) => s1 + ", " + s2);
            Console.WriteLine(commaSeparatedString);

            // Aggregate with seed value
            string commaSeparatedStudentNames = studentList.Aggregate<Student, string>(
                                                                "Student Names: ", // seed value
                                                                (str, s) => str += s.StudentName + ", ");
            Console.WriteLine(commaSeparatedStudentNames);

            int SumOfStudentAge = studentList.Aggregate<Student, int>(0, 
                                                                    (totalAge, s) => totalAge += s.Age);
            Console.WriteLine("Total students Age = " + SumOfStudentAge);

            commaSeparatedStudentNames = studentList.Aggregate<Student, string, string>(
                                                            String.Empty, // seed Value
                                                            (str, s) => str += s.StudentName + ", ", // returns result using seed value, String.Empty goes to lambda expression as str
                                                            str => str.Substring(0, str.Length - 2)); // result selector that removes last comma
            Console.WriteLine("Students: " + commaSeparatedStudentNames);

            // Average Method
            var avg = intList.Average();
            Console.WriteLine("Average: {0}", avg);

            var avgAge = studentList.Average(s => s.Age);
            Console.WriteLine("Students Age Average: {0}", avgAge);

            // Count method in Method Syntax
            var totalElements = intList.Count();
            Console.WriteLine("Total elements: {0}", totalElements);

            var evenElements = intList.Count(i => i % 2 == 0);
            Console.WriteLine("Even elements count: {0}", evenElements);

            var totalStudents = studentList.Count();
            Console.WriteLine("Total number of students: {0}", totalStudents);
            var adultStudents = studentList.Count(s => s.Age >= 18);
            Console.WriteLine("Number of adult students: {0}", adultStudents);

            // Count Operator in Query Syntax
            var totalStud = (from s in studentList
                            select s.Age).Count();
            Console.WriteLine("Total Students: {0}", totalStud);

            // Max method
            var largest = intList.Max();
            Console.WriteLine("Largest Element: {0}", largest);
            var largestEvenElem = intList.Max(i =>
            {
                if (i % 2 == 0)
                {
                    return i;
                }
                return 0;
            });
            Console.WriteLine("Largest Even Elem: {0}", largestEvenElem);

            // Max in method Syntax on complex type collection
            var oldest = studentList.Max(s => s.Age);
            Console.WriteLine("OLdest Student is: {0}", oldest);

            var studentWithLongName = studentList.Max();
            Console.WriteLine("Student ID: {0}, Student Name: {1}", studentWithLongName.StudentId, studentWithLongName.StudentName);

            // LINQ sum
            var total = intList.Sum();
            Console.WriteLine("Sum: {0}", total);
            var sumOfEvenElem = intList.Sum(i =>
            {
                if (i % 2 == 0)
                {
                    return i;
                }
                return 0;
            });
            Console.WriteLine("Sum of Even Elements: {0}", sumOfEvenElem);

            // LINQ sum on complex types
            var sumOfAge = studentList.Sum(s => s.Age);
            Console.WriteLine("Sum of all Student's age: {0}", sumOfAge);
            var sumOfAdultsAge = studentList.Sum(s =>
            {
                if (s.Age >= 18)
                    return s.Age;
                return 0;
            });
            Console.WriteLine("Sum of Adult's Age: {0}", sumOfAdultsAge);

            // ElementAt & ElementAtOrDefault
            intList = new List<int>() { 10, 21, 30, 45, 50, 87 };
            stringList = new List<string> { "One", "Two", null, "Four", "Five" };

            Console.WriteLine("2nd Element in intList: {0}", intList.ElementAt(1));
            Console.WriteLine("2nd Element in stringList: {0}", stringList.ElementAt(1));
            Console.WriteLine("3rd Element in intList: {0}", intList.ElementAtOrDefault(2));
            Console.WriteLine("3rd Element in stringList: {0}", stringList.ElementAtOrDefault(2));
            Console.WriteLine("9th Element in intList: {0}", intList.ElementAtOrDefault(8));
            Console.WriteLine("9th Element in stringList: {0}", stringList.ElementAtOrDefault(8));

            // LINQ First & FirstOrDefault 
            stringList = new List<string> { null, "Two", "Three", "Four", "Five" };
            IList<string> emptyList = new List<string>();

            Console.WriteLine("1st Element in intList: {0}", intList.First());
            Console.WriteLine("1st Even Element in intList: {0}", intList.First(i => i % 2 == 0));
            Console.WriteLine("1st Elem in stringList: {0}", stringList.First());
            Console.WriteLine("1st or depfault Elem in emptyList: {0}", emptyList.FirstOrDefault());

            // SequenceEqual in method Syntax
            IList<string> firstListString = new List<string>() { "One", "Two", "Three", "Four", "Five"};
            IList<string> secondListString = new List<string>() { "One", "Two", "Three", "Four", "Five" };
            bool isEqualStrings = firstListString.SequenceEqual(secondListString);
            Console.WriteLine("SequenceEqual: " + isEqualStrings);

            // Concat method
            var collectionConcat = firstListString.Concat(secondListString);
            Console.WriteLine("Concat method: ");
            foreach(string str in collectionConcat)
            {
                Console.Write(str + " ");
            }
            Console.WriteLine();

            // DefaultIfEmpty method
            var newList1 = emptyList.DefaultIfEmpty();
            var newList2 = emptyList.DefaultIfEmpty("none");
            Console.WriteLine("Count: {0}", newList1.Count());
            Console.WriteLine("Value: {0}", newList1.FirstOrDefault());
            Console.WriteLine("Count: {0}", newList2.Count());
            Console.WriteLine("Value: {0}", newList2.FirstOrDefault());

            // Range Method
            var intCollection = Enumerable.Range(10, 10);
            Console.WriteLine("Total Count: {0}", intCollection.Count());
            for(int i=0; i < intCollection.Count(); i++)
            {
                Console.WriteLine("Value at index {0} : {1}", i, intCollection.ElementAt(i));
            }

            // Repeat Method
            var intCollect = Enumerable.Repeat(10, 10);
            Console.WriteLine("Total Count: {0}", intCollect.Count());
            for (int i = 0; i < intCollect.Count(); i++)
            {
                Console.WriteLine("Value at index {0} : {1}", i, intCollect.ElementAt(i));
            }

            // Distinct method
            IList<string> stringsList = new List<string>() { "One", "Two", "Three", "Two", "Three"};
            intList = new List<int> { 1, 2, 3, 2, 4, 4, 3, 5 };

            var distinctStrings = stringsList.Distinct();
            Console.Write("Distinct strings: ");
            foreach(string s in distinctStrings)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();
            var dinstinctInts = intList.Distinct();
            Console.Write("Distinct Ints: ");
            foreach (int i in dinstinctInts)
            {
                Console.Write(i + " ");
            }

            var distinctStudents = studentList.Distinct(new StudentComparer());
            Console.WriteLine("Distinct students: ");
            foreach (Student s in distinctStudents)
            {
                Console.WriteLine("Id= {0}, Name= {1} ", s.StudentId, s.StudentName);
            }

            // Except method
            firstListString = new List<string> { "One", "Two", "Three", "Four", "Five" };
            secondListString = new List<string> { "Four", "Five", "Six", "Seven", "Eight" };
            var exceptResult = firstListString.Except(secondListString);
            Console.Write("\nExcept results: ");
            foreach(var str in exceptResult)
            {
                Console.Write(str + " ");
            }
            Console.WriteLine();

            // Except Result in complex types
            IList<Student> studentList2 = new List<Student>()
            {
                new Student() {StudentId = 1, StudentName = "John", Age = 18, StandardId = 1},
                new Student() {StudentId = 5, StudentName = "Human", Age = 30}
            };
            var resultedCol = studentArray.Except(studentList2, new StudentComparer());
            Console.WriteLine("Except on complex types: ");
            foreach(Student s in resultedCol)
            {
                Console.WriteLine(s.StudentName);
            }
        }   
    }
}
