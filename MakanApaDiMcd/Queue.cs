public class LinkedListQueue<T>
{
    private class Node
    {
        public T Data;
        public Node Next;

        public Node(T data)
        {
            this.Data = data;
            this.Next = null;
        }
    }

    private Node head;
    private Node tail;

    public LinkedListQueue()
    {
        head = null;
        tail = null;
    }

    public void Enqueue(T item)
    {
        Node newNode = new Node(item);
        if (tail != null)
        {
            tail.Next = newNode;
        }
        tail = newNode;
        if (head == null)
        {
            head = newNode;
        }
    }

    public T Dequeue()
    {
        if (head == null)
        {
            throw new InvalidOperationException("Queue is empty");
        }

        T item = head.Data;
        head = head.Next;
        if (head == null)
        {
            tail = null;
        }
        return item;
    }

    public T Peek()
    {
        if (head == null)
        {
            throw new InvalidOperationException("Queue is empty");
        }
        return head.Data;
    }

    public bool IsEmpty()
    {
        return head == null;
    }
}