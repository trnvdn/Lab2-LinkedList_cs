namespace Lab2LinkedList;

public class LinkedList
{
    private Node head;
    public void Insert(int n)
    {
        if (head == null)
        {
            head = new Node(n);
        }
        else
        {
            Insert(new Node(n), head);
        }
    }

    private void Insert(Node node, Node current)
    {
        if (current.next == null)
        {
            current.next = node;
        }
        else
        {
            Insert(node, current.next);
        }
    }

    public void AddAfter(int i, int n)
    {
        if (head != null)
        {
            Node cur = head;
            int index = 1;
            while (cur.next != null && i > index)
            {
                cur = cur.next;
                index++;
            }

            if (cur.next == null && index < i)
            {
                Insert(n);
            }
            else
            {
                Node tmp = cur.next;
                cur.next = new Node(n);
                cur.next.next = tmp;
            }
        }
        else
        {
            Print(head);
        }
    }


    public void RemoveLast()
    {
        if (head != null)
        {
            Node cur = head;
            while (cur.next != null && cur.next.next != null)
            {
                cur = cur.next;
            }

            if (cur.next == null)
            {
                head = null;
                Print(head);
            }
            else
            {
                cur.next = null;
            }
        }
        else
        {
            Print(head);
        }
    }

    public void RemoveAllEvenNumbers()
    {
        if(head.info % 2 == 0 && head.next == null)
        {
            head = new Node(null);
            
        }
        else
        {
            while(head.info % 2 == 0 && head.next != null)
            {
                head = head.next;
            }

            if (head.info % 2 == 0)
            {
                head = null;
            }
            else
            {
                var cur = head;
                while (cur.next != null)
                {
                    if (cur.next.info % 2 == 0)
                    {
                        if (cur.next.next != null)
                        {
                            cur.next = cur.next.next;
                        }
                        else
                        {
                            RemoveLast();
                        }
                    }
                    else
                    {
                        cur = cur.next;
                    }
                }
            }
        }
        
    }

    public void Print()
    {
        Node current = head;
        Print(current);
        Console.WriteLine();
    }

    private void Print(Node n)
    {
        if (n != null)
        {
            Console.Write(n.info + " ");
            if (n.next != null)
            {
                Print(n.next);
            }
        }
        else
        {
            Console.WriteLine("List is empty");
        }
    }

    public void SumOfPositiveNums()
    {
        int sum = 0;
        var cur = new Node(head);
        while (cur.next != null)
        {
            if (cur.info > 0)
            {
                sum += cur.info;
            }
            cur = cur.next;
        }

        Console.WriteLine(sum == 0 ? 1 : sum);
    }
    public int Second
    {
        get
        {
            if (head == null || head.next == null)
            {
                return default;
            }

            return head.next.info;
        }
        set
        {
            if (head == null || head.next == null)
            {
                Insert(value);
            }
            else
            {
                head.next.info = value;
            }
        }
    }
    public static LinkedList operator /(LinkedList list, int index)
    {
        if (index <= 0)
        {
            Console.WriteLine(("Invalid index"));
        }
    
        if (list.head == null)
        {
            Console.WriteLine("List is empty");
        }
    
        if (index == 1)
        {
            list.head = list.head.next;
            return list;
        }
    
        Node prev = null;
        Node current = list.head;
        int currentIndex = 1;
    
        while (current != null && currentIndex < index)
        {
            prev = current;
            current = current.next;
            currentIndex++;
        }
    
        if (current == null)
        {
            Console.WriteLine("Index is out of range");
        }
        else
        {
            prev.next = current.next;
        }
    
    
        return list;
    }

    public static LinkedList operator +(LinkedList list, int increment)
    {
        if (increment <= 0)
        {
            Console.WriteLine("Error");
        }
        else
        {
            var node = list.head;
            while (true)
            {
                node.info += increment;
                if (node.next != null)
                {
                    node = node.next;
                }
                else
                {
                    break;
                }
            }
        }

        return list;
    }

    public Node ReturnHead() => head;

    public void GetHead(Node h)
    {
        head = h;
    }
}