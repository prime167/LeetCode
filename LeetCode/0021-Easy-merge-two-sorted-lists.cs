namespace LeetCode;

public partial class Problems
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        var lista = new List<int>();
        while (list1 != null)
        {
            lista.Add(list1.val);
            list1 = list1.next;
        }

        while (list2 != null)
        {
            lista.Add(list2.val);
            list2 = list2.next;
        }

        if (lista.Count == 0)
        {
            return null;
        }

        lista.Sort();
        ListNode head = new ListNode();
        ListNode current;
        head.val = lista[0];
        head.next = null;
        current = head;
        for (int i = 1; i < lista.Count; i++)
        {
            ListNode x = new ListNode();
            x.val = lista[i];
            x.next = null;
            current.next = x;
            current = x;
        }

        return head;
    }
}

public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}
