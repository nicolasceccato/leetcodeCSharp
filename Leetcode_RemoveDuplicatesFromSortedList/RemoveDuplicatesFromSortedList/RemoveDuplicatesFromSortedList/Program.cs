using System;

namespace RemoveDuplicatesFromSortedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            ListNode listNode = new ListNode(1);
            listNode.next.val = 1;
            listNode.next.next.val = 2;

            ListNode result = solution.DeleteDuplicates(listNode);

            while (result.next != null)
            {
                Console.WriteLine(result.val);
                result = result.next;
            }
        }
    }
}