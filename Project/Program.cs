using System;
using StudentScoreProject.Models;
using StudentScoreProject.Services;
using StudentScoreProject.Utilities;

namespace StudentScoreProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Student Score Management System ===\n");
            int choice;

            do
            {
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Display Students");
                Console.WriteLine("3. Calculate Average Score");
                Console.WriteLine("4. Search Student by Name");
                Console.WriteLine("5. Exit");
                Console.Write("\nEnter your choice: ");
                choice = Utility.ReadInt();

                switch (choice)
                {
                    case 1:
                        DataStore.AddStudent();
                        break;
                    case 2:
                        DataStore.DisplayStudents();
                        break;
                    case 3:
                        ScoreCalculator.CalculateAverage();
                        break;
                    case 4:
                        Utility.SearchStudentByName();
                        break;
                    case 5:
                        Console.WriteLine("Exiting... Thank you!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }

                Console.WriteLine();
            } while (choice != 5);
        }
    }
}
