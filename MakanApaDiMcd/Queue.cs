public class Queue
{
    private class Node
    {
        public Pesanan Data;
        public Node Next;

        public Node(Pesanan data)
        {
            this.Data = data;
            this.Next = null;
        }
    }

    private Node head;
    private Node tail;

    public Queue()
    {
        head = null;
        tail = null;
    }

    public void Enqueue(Pesanan item)
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

    public  Pesanan Dequeue()
    {
        if (head == null)
        {
            Console.WriteLine("Antrian kosong");
        }

        Pesanan item = head.Data;
        head = head.Next;
        if (head == null)
        {
            tail = null;
        }
        return item;
    }

    public string Peek()
    {
        if (head == null)
        {
            // Console.WriteLine("Queue is empty");
            return "queue is empty";
        }
        return head.Data.Nama;
    }

    public bool IsEmpty()
    {
        return head == null;
    }
    
}