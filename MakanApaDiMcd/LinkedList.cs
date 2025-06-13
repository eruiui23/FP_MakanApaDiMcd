using System;

public class LinkedList
{
    private Node head;

    public class Node
    {
        public int data;
        public Node next;

        public Node(int d)
        {
            data = d;
            next = null;
        }
    }

    public LinkedList()
    {
        head = null;
    }

    // Menambahkan item di depan (menjadi head baru)
    public void AddFirst(int data)
    {
        Node newNode = new Node(data);
        newNode.next = head;
        head = newNode;
    }

    // Menambahkan item di tengah list setelah node dengan data tertentu
    public void AddAfter(int after, int data)
    {
        Node current = head;
        while (current != null && current.data != after)
        {
            current = current.next;
        }

        if (current != null)
        {
            Node newNode = new Node(data);
            newNode.next = current.next;
            current.next = newNode;
        }
        else
        {
            Console.WriteLine($"Node dengan data {after} tidak ditemukan.");
        }
    }

    // Menambahkan item di akhir list
    public void AddLast(int data)
    {
        Node newNode = new Node(data);
        if (head == null)
        {
            head = newNode;
            return;
        }

        Node last = GetLastNode();
        last.next = newNode;
    }

    private Node GetLastNode()
    {
        Node temp = head;
        while (temp.next != null)
        {
            temp = temp.next;
        }
        return temp;
    }
}

class Program
{
    static void Main(string[] args)
    {
        LinkedList linkedList = new LinkedList();

        linkedList.AddLast(3); // Menambahkan 3 di akhir list
        linkedList.AddFirst(1); // Menambahkan 1 di awal list
        linkedList.AddAfter(1, 2); // Menambahkan 2 setelah 1, di tengah list
    }
}