namespace LeetCode;

public class ReverseLinkedListClass
{
	public static void InternalMain()
	{
		ListNode head = new ListNode(1);
		head.next = new ListNode(2);
		head.next.next = new ListNode(3);
		head.next.next.next = new ListNode(4);
		head.next.next.next.next = new ListNode(5);

		// Call ReverseList method with the input head
		ListNode reversedList = ReverseList(head);
	}

	public static ListNode ReverseList(ListNode head)
	{

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
