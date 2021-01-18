using System;
using System.Collections.Generic;
using System.Linq;

namespace Task05_Students_2_0
{
    class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string City { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> thisYearStudents = new List<Student>();

            while (true)
            {
                string comand = Console.ReadLine();

                if (comand == "end")
                {
                    break;
                }

                string[] rawData = comand.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string firstName = rawData[0];
                string lastName = rawData[1];
                int age = int.Parse(rawData[2]);
                string city = rawData[3];

                Student nextName = new Student()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Age = age,
                    City = city
                };
                
                if(IsStudentExist(thisYearStudents, firstName, lastName))
                {
                    Student existingStudent = GetExistingStudent(thisYearStudents, firstName, lastName);

                    existingStudent.FirstName = firstName;
                    existingStudent.LastName = lastName;
                    existingStudent.Age = age;
                    existingStudent.City = city;
                }

                else
                {
                    thisYearStudents.Add(nextName);
                }
                
            }

            string filterCity = Console.ReadLine();

            List<Student> filteredList = thisYearStudents.Where(s => s.City == filterCity).ToList();

            foreach (Student inList in filteredList)
            {
                Console.WriteLine($"{inList.FirstName} {inList.LastName} is {inList.Age} years old.");
            }
        }

        private static Student GetExistingStudent(List<Student> thisYearStudents, string firstName, string lastName)
        {
            Student findedExistingStudent = null;

            foreach (Student chek in thisYearStudents)
            {
                if (chek.FirstName == firstName && chek.LastName == lastName)
                {
                    findedExistingStudent = chek;
                }
            }

            return findedExistingStudent;

        }

        private static bool IsStudentExist(List<Student> thisYearStudents, string firstName, string lastName)
        {
            foreach(Student chek in thisYearStudents)
            {
                if(chek.FirstName == firstName && chek.LastName == lastName)
                {
                    return true;
                }
            }

            return false;
        }
    }
}