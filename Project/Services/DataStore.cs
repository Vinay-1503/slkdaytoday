using System;
using StudentScoreProject.Models;
using StudentScoreProject.Utilities;

namespace StudentScoreProject.Services
{
    public static class DataStore
    {
        private static Student[] students = new Student[100];
        private static int count = 0;

        public static void AddStudent()
        {
            Console.Write("Enter Student ID: ");
            int id = Utility.ReadInt();

            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter number of subjects: ");
            int n = Utility.ReadInt();

            int[] marks = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter mark {i + 1}: ");
                marks[i] = Utility.ReadInt();
            }

            students[count++] = new Student { Id = id, Name = name, Marks = marks };
            Console.WriteLine("Student added successfully!\n");
        }

        public static void DisplayStudents()
        {
            Console.WriteLine("\n--- Student List ---");
            for (int i = 0; i < count; i++)
            {
                var s = students[i];
                Console.WriteLine($"ID: {s.Id}, Name: {s.Name}, Total: {s.TotalMarks()}, Avg: {s.AverageMarks():F2}");
            }
        }

        public static Student[] GetAllStudents() => students;
        public static int GetCount() => count;
    }
}
