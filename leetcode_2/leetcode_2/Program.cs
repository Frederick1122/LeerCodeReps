ListNode AddTwoNumbers()
{
    var l1 = new ListNode();
    var l2 = new ListNode();
    var ll1 = l1;
    var ll2 = l2;
    var list1 = new int[2, 3, 4];
    var list2 = new int[9, 2, 3, 4];

    foreach (var list in list1)
    {
        ll1.val = list;
        ll1 = ll1.next;
    }
    
    foreach (var list in list2)
    {
        ll2.val = list;
        ll2 = ll2.next;
    }
    
    if(l1 == null && l2 == null){
        return null;
    }
    else if(l1 == null){
        return l2;
    }
    else if(l2 == null){
        return l1;
    }

    
    var result = new ListNode();
    var p = result;
    var offset = 0;
    while (l1 != null && l2 != null)
    {
        p.val = (l1.val + l2.val + offset) % 10;
        offset = (p.val) / 10;
        p = p.next;
    }

    return p;
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