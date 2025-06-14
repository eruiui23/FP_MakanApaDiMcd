using System;
public class Pesanan
{
    public string Nama;
    public ListMenu listMenu;

    public Pesanan(string nama)
    {
        Nama = nama;
        listMenu = new ListMenu();
    }

    public void TambahMenu(string item, int kuantitas)
    {
        listMenu.TambahMenu(item, kuantitas);
    }

    public void TampilkanPesanan()
    {
        // Console.WriteLine($"Pesanan untuk {Nama}:");
        listMenu.TampilkanMenu();
    }
}
