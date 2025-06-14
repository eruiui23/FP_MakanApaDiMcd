using System.Security.Cryptography;

public class Queue
{
    public int totalAntrian = 0;
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
        totalAntrian++;
    }

    public Pesanan Dequeue()
    {
        // if (head == null)
        // {
        //     Console.WriteLine("Antrian kosong");
        // }

        Pesanan item = head.Data;
        head = head.Next;
        if (head == null)
        {
            tail = null;
        }

        totalAntrian--;

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
    public Pesanan PeekLast()
    {
        if (head == null)
        {
            // Console.WriteLine("Queue is empty");
            return tail.Data;
        }
        else
        {
            return tail.Data;
        }
    }

    public bool IsEmpty()
    {
        return head == null;
    }

    public void TampilkanAntrian()
    {
        Node current = head;
        if (head == null)
        {
            return;
        }
        while (current != null)
        {
            Console.WriteLine($"- [{current.Data.idPesanan}] {current.Data.Nama}");
            current = current.Next;
        }
    }
    public int CekAntrian(int idPesanan)
    {
        if (head == null)
        {
            return -1;
        }
        Node current = head;
        int count = 0;
        while (current != null)
        {
            if (current.Data.idPesanan == idPesanan)
            {
                return count;
            }
            count++;
            current = current.Next;
        }
        return -1;
    }

    public void CekDetailAntrian(int idPesanan)
    {
        Node current = head;
        while (current !=null)
        {
            if (current.Data.idPesanan == idPesanan)
            {
                current.Data.TampilkanPesanan();
                return;
            }
            current = current.Next;
        }
    }

}