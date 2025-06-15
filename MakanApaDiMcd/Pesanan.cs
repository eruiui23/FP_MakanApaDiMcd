using System;
public class Pesanan
{
    static public int nomorPesanan = 0;
    public string Nama;
    public int idPesanan;
    public ListMenu listMenu;


    public Pesanan(string nama)
    {
        Nama = nama;
        listMenu = new ListMenu();
        idPesanan = ++nomorPesanan;
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
    public void TampilkanPesananNomor()
    {
        // Console.WriteLine($"Pesanan untuk {Nama}:");
        listMenu.TampilkanMenuNomor();
    }
    public void HapusMenuPadaIndex(int index)
    {
        listMenu.HapusMenuPadaIndex(index);
    }

}
