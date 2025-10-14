namespace StudentScoreProject.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int[] Marks { get; set; }

        public int TotalMarks()
        {
            int sum = 0;
            for (int i = 0; i < Marks.Length; i++)
            {
                sum += Marks[i];
            }
            return sum;
        }

        public double AverageMarks()
        {
            return (double)TotalMarks() / Marks.Length;
        }
    }
}
