class Solution
{
    public static void Main()
    {
        LinkedList<int> list = new LinkedList<int>();

        int n = 10;
        for(int i = 0; i < n; i++)
        {
            list.AddAtLast((i + 1) * 10);
        }

        list.AddAtFirst(-10);

        list.RemoveAtLast();

        list.RemoveAtFirst();

        //list.RemoveNthFromEnd(4);

        //list.RemoveNthFromStart(3);

        list.ReverseAllNodes();

        // Node<int> mid = list.FindMidNode();
        // Console.WriteLine("mid is {0}", mid.Value);

        //Console.WriteLine("median is {0}", list.FindMedian());

        // list.RemoveNthFromEnd(3);

        list.PrintAllNodes();
    }
}