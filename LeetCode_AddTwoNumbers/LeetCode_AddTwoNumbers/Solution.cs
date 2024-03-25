﻿
     // Definition for singly-linked list.
      public class ListNode {
          public int val;
          public ListNode next;
          public ListNode(int val=0, ListNode next=null) {
              this.val = val;
              this.next = next;
          }
      }
     
    public class Solution {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode sentinel = new ListNode(0);

            ListNode p = l1;
            ListNode q = l2;
            ListNode current = sentinel;

            int carry = 0;

            while (p != null || q != null)
            {
                int value1 = (p != null) ? p.val : 0;
                int value2 = (q != null) ? q.val : 0;

                int sum = carry + value1 + value2;

                carry = sum / 10;

                current.next = new ListNode(sum % 10);

                current = current.next;

                if (p != null)
                {
                    p = p.next;
                }
                if (q != null)
                {
                    q = q.next;
                }
            }

            if (carry > 0)
            {
                current.next = new ListNode(carry);
            }

            return sentinel.next;

        }
    }