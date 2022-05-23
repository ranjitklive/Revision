public class Node<T>
{
    public T Value;
    public Node<T> Next;

    public Node()
    {
        
    }
}

public class LinkedList<T>
{
    private Node<T> head;

    private Node<T> current;

    private int count;

    public LinkedList()
    {
        // head = new Node<T>();
        // current = head;
    }

    public void AddAtLast(T data)
    {
        Node<T> newNode = new Node<T>(){ Value = data};

        if(current == null)
        {
            current = newNode;
            head = current;
        }
        else
        {
            current.Next = newNode;
        }

        current = newNode;
        count++;
    }

    public void AddAtFirst(T data)
    {
        Node<T> newNode = new Node<T>(){ Value = data};

        if(current == null)
        {
            current = newNode;
            head = current;
        }
        else
        {
            newNode.Next = head;
            head = newNode;
        }     
        
        count++;
    }

    public void RemoveAtFirst()
    {
        head = head.Next;
    }

    public void RemoveAtLast()
    {
        Node<T> tail = head;
        Node<T> prevNode = tail;

        while(tail.Next != null)
        {
            prevNode = tail;
            tail = tail.Next;
        }

        prevNode.Next = tail.Next;    
        
        count--;
    }

    public void RemoveNthFromStart(int n)
    {
        var tail = head;
        var preDelete = head;

        for(int i = 0; i < n - 2; i++)
        {
            tail = tail.Next;
            preDelete = preDelete.Next;
        }

        tail.Next = tail.Next.Next;
    }

    public void RemoveNthFromEnd(int n)
    {
        var tail = head;
        var preDelete = head;

        for(int i = 0; i < n; i++)
        {
            tail = tail.Next;
        }

        while(tail.Next != null)
        {
            tail = tail.Next;
            preDelete = preDelete.Next;
        }

        preDelete.Next = preDelete.Next.Next;
    }

    public void PrintAllNodes()
    {
        Node<T> tail = head;

        while(tail.Next != null)
        {
            Console.Write("{0} ", tail.Value);
            tail = tail.Next;
        }
        Console.Write("{0} ", tail.Value);
    }

    public void ReverseAllNodes()
    {
        Node<T> previous = null;
        Node<T> current = head; 
        while(current != null) {
            Node<T> nextTemp = current.Next;
            current.Next = previous;
            previous = current;
            current = nextTemp;
        }
        head = previous;
    }

    public Node<T> FindMidNode()
    {
        Node<T> slow = head.Next;
        Node<T> fast = head.Next.Next;

        while(fast.Next != null && fast.Next.Next != null)
        {
            slow = slow.Next;
            fast = fast.Next.Next;
        }

        return slow;
    }

    public int FindMedian()
    {
        Node<T> slow = head.Next;
        Node<T> fast = head.Next.Next;

        while(fast.Next != null && fast.Next.Next != null)
        {
            slow = slow.Next;
            fast = fast.Next.Next;
        }

        if(count % 2 == 0)
        {
            //even no of elements
            return ((int)Convert.ChangeType(slow.Value, typeof(T)) + (int)Convert.ChangeType(slow.Next.Value, typeof(T)))/2;
        }
        else
        {
            //odd no of elements
            return (int)Convert.ChangeType(slow.Value, typeof(T));
        }
    }

    public void ReverseNodesFromMid()
    {
        
    }

    public void ReverseNNodesFromStart(int n)
    {
        
    }

    public void ReverseNNodesFromEnd(int n)
    {
        
    }
}