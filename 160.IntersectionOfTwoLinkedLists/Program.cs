//Given the heads of two singly linked-lists headA and headB, return the node at which the two lists intersect. If the two linked lists have no intersection at all, return null.

using System;
using System.Collections.Generic;

class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int x) { val = x; }
}

class Solution
{

    static void Main(string[] args)
    {
        ListNode headA = new ListNode(4);
        headA.next = new ListNode(1);
        headA.next.next = new ListNode(8);
        headA.next.next.next = new ListNode(4);
        headA.next.next.next.next = new ListNode(5);

        ListNode headB = new ListNode(5);
        headB.next = new ListNode(6);
        headB.next.next = headA.next.next;

        Solution solution = new Solution();
        ListNode intersection = solution.GetIntersectionNode(headA, headB);
        if (intersection != null)
        {
            Console.WriteLine("Intersected at '" + intersection.val + "'");
        }
        else
        {
            Console.WriteLine("No intersection found");
        }
        Console.ReadLine();
    }


    public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
    {
        HashSet<ListNode> set = new HashSet<ListNode>();
        while (headA != null)
        {
            set.Add(headA);
            headA = headA.next;
        }
        while (headB != null)
        {
            if (set.Contains(headB))
            {
                return headB;
            }
            headB = headB.next;
        }
        return null;
    }
}


