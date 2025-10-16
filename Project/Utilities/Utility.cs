using System;
using StudentScoreProject.Services;

namespace StudentScoreProject.Utilities
{
    public static class Utility
    {
        public static int ReadInt()
        {
            int value;
            while (!int.TryParse(Console.ReadLine(), out value))
            {
                Console.Write("Invalid input. Enter a number: ");
            }
            return value;
        }

        public static void SearchStudentByName()
        {
            Console.Write("Enter name to search: ");
            string name = Console.ReadLine().Trim().ToLower();

            var students = DataStore.GetAllStudents();
            int count = DataStore.GetCount();
            bool found = false;

            for (int i = 0; i < count; i++)
            {
                if (students[i] != null && students[i].Name.ToLower().Contains(name))
                {
                    Console.WriteLine($"Found -> ID: {students[i].Id}, Name: {students[i].Name}, Average: {students[i].AverageMarks():F2}");
                    found = true;
                }
            }

            if (!found)
                Console.WriteLine("No student fhat name.");
        }
    }
}
