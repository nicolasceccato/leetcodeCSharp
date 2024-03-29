using System;
using MergeTwoSortedLists;


public class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        ListNode l1 = new ListNode(1);
        l1.next = new ListNode(2);
        l1.next = new ListNode(4);

        ListNode l2 = new ListNode(1);
        l2.next = new ListNode(3);
        l2.next = new ListNode(4);

        PrintListNode(solution.MergeTwoLists(l1, l2));

        ListNode l3 = new ListNode();
        ListNode l4 = new ListNode();

        PrintListNode(solution.MergeTwoLists(l3, l4));

        ListNode l5 = new ListNode();
        ListNode l6 = new ListNode(0);

        PrintListNode(solution.MergeTwoLists(l5, l6));

    }

    public static void PrintListNode(ListNode listNode)
    {
        if (listNode != null)
        {
            while (listNode.next != null)
            {
                Console.WriteLine(listNode.val);
                listNode = listNode.next;
            }
        }
    }
}
