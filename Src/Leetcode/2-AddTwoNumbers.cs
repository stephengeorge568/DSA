namespace DSA.Src.Leetcode;


public class AddTwoNumbers
{
    /*
        https://leetcode.com/problems/add-two-numbers/
        Given:
            Two linked listed in reverse order
            No starting 0
            sum both linked lists
        First Solution: 
            Can cleanup but perfect solution. Looks like most people used iterative approach instead of recursive. big deal
    */
    public static ListNode AddTooNumbers(ListNode l1, ListNode l2) {
        return AddTooNumbers(l1, l2, 0);
    }

    private static ListNode AddTooNumbers(ListNode? l1, ListNode? l2, int carry)
    {   
        ListNode newNode = new ListNode();

        if (l1 != null)
        {
            newNode.val += l1.val;
        }

        if (l2 != null)
        {
            newNode.val += l2.val;
        }

        if (carry > 0)
        {
            newNode.val += carry;
        }

        carry = 0;
        if (newNode.val > 9)
        {
            newNode.val -= 10;
            carry = 1;
        }

        if (l1?.next != null || l2?.next != null)
        {
            newNode.next = AddTooNumbers(l1 == null ? null : l1.next, l2 == null ? null : l2.next, carry);
        }
        else if (carry > 0)
        {
            newNode.next = new ListNode()
            {
                val = 1
            };
        }
        return newNode;
    }
}

public class ListNode
{
    public ListNode? next { get; set;}
    public int val { get; set;}
}
