namespace Lab2LinkedList;

public class Node
{
    public int info;
    public Node next;
    //Конструктор класу
    public Node(int info)
    {
        this.info = info;
    }
    //Конструктор копіювання
    public Node(Node value)
    {
        info = value.info;
        next = value.next;
    }
    
}