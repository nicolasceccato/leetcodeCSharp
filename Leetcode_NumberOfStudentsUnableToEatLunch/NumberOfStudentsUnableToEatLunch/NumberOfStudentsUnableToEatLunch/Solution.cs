namespace NumberOfStudentsUnableToEatLunch;

public class Solution {
    public int CountStudents(int[] students, int[] sandwiches)
    {
        Queue<int> queueOfStudents = new Queue<int>(students);
        Queue<int> queueOfSandwiches = new Queue<int>(sandwiches);

        int counter = 0;

        while (queueOfStudents.Count != 0)
        {
            if (queueOfStudents.Peek() == queueOfSandwiches.Peek())
            {
                queueOfStudents.Dequeue();
                queueOfSandwiches.Dequeue();
                counter = 0;
            }
        }

    }
}