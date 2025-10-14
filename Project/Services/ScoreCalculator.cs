using System;

namespace StudentScoreProject.Services
{
    public static class ScoreCalculator
    {
        public static void CalculateAverage()
        {
            var students = DataStore.GetAllStudents();
            int count = DataStore.GetCount();
            if (count == 0)
            {
                Console.WriteLine("No student data found!");
                return;
            }

            double total = 0;
            for (int i = 0; i < count; i++)
            {
                total += students[i].AverageMarks();
            }

            Console.WriteLine($"\nClass Average Score: {(total / count):F2}");
        }
    }
}
