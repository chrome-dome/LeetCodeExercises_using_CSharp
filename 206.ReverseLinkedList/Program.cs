//Given the head of a singly linked list, reverse the list, and return the reversed list.


class Program
{
    static void Main()
    {
        // create a linked list: 1->2->3->4->5
        ListNode head = new ListNode(1);
        head.next = new ListNode(2);
        head.next.next = new ListNode(3);
        head.next.next.next = new ListNode(4);
        head.next.next.next.next = new ListNode(5);

        Solution solution = new Solution();
        ListNode reversedHead = solution.ReverseList(head);

        // print the reversed linked list: 5->4->3->2->1
        while (reversedHead != null)
        {
            Console.Write(reversedHead.val + "->");
            reversedHead = reversedHead.next;
        }

        Console.ReadLine();
    }
}



class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int x) { val = x; }
}

class Solution
{
    public ListNode ReverseList(ListNode head)
    {
        ListNode prev = null;
        ListNode current = head;
        while (current != null)
        {
            ListNode nextTemp = current.next;
            current.next = prev;
            prev = current;
            current = nextTemp;
        }
        return prev;
    }
}


