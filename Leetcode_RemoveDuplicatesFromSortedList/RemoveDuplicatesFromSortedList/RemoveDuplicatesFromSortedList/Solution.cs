namespace RemoveDuplicatesFromSortedList;

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode DeleteDuplicates(ListNode head)
    {
        if (head != null)
        {
            ListNode current = head;
            
            while (current.next != null)
            {
                if (current.val == current.next.val )
                {
                    ListNode temp = current.next;
                    current.next = temp.next;
                }
                else
                {
                    current = current.next;
                }
            }
        }
        return head;
    }
}
public class ListNode {
     public int val;
     public ListNode next;
     public ListNode(int val=0, ListNode next=null) 
     { 
         this.val = val;
         this.next = next;
     }
 }