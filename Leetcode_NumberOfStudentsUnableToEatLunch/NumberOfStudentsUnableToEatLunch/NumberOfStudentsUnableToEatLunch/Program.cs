using System;

namespace NumberOfStudentsUnableToEatLunch // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] students = new int[] { 1, 1, 0, 0 };
            int[] sandwiches = new int[] { 0,1,0,1 };

            int studentsWithoutLunch = solution.CountStudents(students, sandwiches);
            Console.WriteLine(studentsWithoutLunch);

        }
    }
}