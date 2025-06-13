using System;
public class Pesanan
{
    public string Nama;
    public LinkedListMenu Menu;

    public Pesanan(string nama)
    {
        Nama = nama;
        Menu = new LinkedListMenu();
    }

    public void TambahMenu(string item)
    {
        Menu.TambahMenu(item);
    }

    public void TampilkanPesanan()
    {
        Console.WriteLine($"Pesanan untuk {Nama}:");
        Menu.TampilkanMenu();
    }
}
