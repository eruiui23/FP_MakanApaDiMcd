using System;
public class Node
{
    public string Data;
    public Node? Next;

    public Node(string data)
    {
        Data = data;
        Next = null;
    }
}


public class LinkedListMenu
{
    private Node? head;

    public void TambahMenu(string menu)
    {
        Node newNode = new Node(menu);
        if (head == null)
        {
            head = newNode;
        }
        else
        {
            Node current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
    }

    public void TampilkanMenu()
    {
        if (head == null)
        {
            Console.WriteLine("Belum ada menu yang dipesan.");
            return;
        }

        Node current = head;
        while (current != null)
        {
            Console.WriteLine($"- {current.Data}");
            current = current.Next;
        }
    }
}
