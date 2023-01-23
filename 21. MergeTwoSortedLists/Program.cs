/*You are given the heads of two sorted linked lists list1 and list2.

Merge the two lists in a one sorted list. The list should be made by splicing together the nodes of the first two lists.

Return the head of the merged linked list.*/

public class SolutionC3
{

    class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    class MergeTwoList
    {
        static void Main(string[] args)
        {
            ListNode l1 = new ListNode();
            l1.val = 1;
            l1.next = new ListNode(2, new ListNode(4, null));

            ListNode l2 = new ListNode();
            l2.val = 1;
            l2.next = new ListNode(3, new ListNode(4, null));
            var recOutput = MergeTwoLinkedList(l1, l2);
            while (recOutput != null)
            {
                Console.WriteLine(recOutput.val);
                recOutput = recOutput.next;
            }
            Console.WriteLine();
            var output = MergeTwoLists(l1, l2);
            while (output != null)
            {
                Console.WriteLine(output.val);
                output = output.next;
            }
            Console.ReadLine();
        }

        static ListNode MergeTwoLinkedList(ListNode l1, ListNode l2)
        {
            if (l1 == null) return l2;
            if (l2 == null) return l1;

            if (l1.val < l2.val)
                return new ListNode(l1.val, MergeTwoLinkedList(l1.next, l2));
            else
                return new ListNode(l2.val, MergeTwoLinkedList(l1, l2.next));
        }

        static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode output = new ListNode();
            ListNode current = output;
            while (l1 != null && l2 != null)
            {
                if (l1.val < l2.val)
                {
                    current.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    current.next = l2;
                    l2 = l2.next;
                }
                current = current.next;
            }

            current.next = l1 == null ? l2 : l1;
            return output.next;
        }
    }

}