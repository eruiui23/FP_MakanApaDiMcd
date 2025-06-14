using System;
using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace MakanApaDiMcd;

class Program
{
    static void Main()
    {
        Queue Antrian = new Queue();

        bool isRunning = true;
        while (isRunning) // Menu Awal
        {
            SelamatDatang();

            string? input = Console.ReadLine();


            if (input == "1") // Menu Pelanggan
            {
                bool isMenuPelanggan = true;
                while (isMenuPelanggan)
                {

                    Console.Clear();
                    Console.WriteLine("--Menu Pelanggan--\n");
                    Console.WriteLine("1. Pesanan baru\n2. Pesanan terdaftar\n3. Kembali\n");

                    input = Console.ReadLine();
                    if (input == "1")// Menu Pesanan Baru
                    {
                        bool isMemesan = true;
                        Console.Clear();
                        Console.Write("*Masukan 0 untuk membatalkan Pesanan\n\nAtas nama : ");
                        input = Console.ReadLine();
                        if (input != "0")
                        {
                            Antrian.Enqueue(new Pesanan(input));

                            while (isMemesan)
                            {

                                Console.Clear();
                                Console.WriteLine("Menu :\n1. Ayam Krispy\n2. Ayam Spicy\n3. Nasi\n4. Big Mac\n5. Cheese Burger\n6. Mineral Water\n7. Milo\n8. Coca Cola\n9. Chocolate Sundae\n10. McFlurry\n");
                                Console.Write($"Pesanan atas nama \"{Antrian.PeekLast().Nama}\" :\n");
                                Antrian.PeekLast().TampilkanPesanan();
                                Console.WriteLine("\nMasukan 1-10 untuk memilih menu. Masukan \"p\" untuk memproses pesanan");

                                void Pesan(string namaMenu)
                                {
                                    Console.Clear();

                                    Console.WriteLine($"{namaMenu} sebanyak :");
                                    Antrian.PeekLast().TambahMenu(namaMenu, int.Parse(Console.ReadLine()));
                                }

                                switch (Console.ReadLine())
                                {
                                    case "1":
                                        Pesan("Ayam Krispy");
                                        break;
                                    case "2":
                                        Pesan("Ayam Spicy");
                                        break;
                                    case "3":
                                        Pesan("Nasi");
                                        break;
                                    case "4":
                                        Pesan("Big Mac");
                                        break;
                                    case "5":
                                        Pesan("Cheese Burger");
                                        break;
                                    case "6":
                                        Pesan("Mineral Water");
                                        break;
                                    case "7":
                                        Pesan("Milo");
                                        break;
                                    case "8":
                                        Pesan("Coca Cola");
                                        break;
                                    case "9":
                                        Pesan("Chocolate Sundae");
                                        break;
                                    case "10":
                                        Pesan("McFlurry");
                                        break;
                                    case "p":
                                        Console.Clear();
                                        Console.Write("Pesanan akan diproses");
                                        AnimasiLoading();
                                        Console.WriteLine("\n\nMohon ditunggu :D");
                                        Thread.Sleep(1200);

                                        isMemesan = false;
                                        isMenuPelanggan = false;
                                        break;
                                    case null:
                                        break;

                                }
                            }
                        }

                    }
                    else if (input == "2")
                    {
                        Console.Clear();
                        Console.WriteLine(Antrian.Peek());
                        Console.ReadLine();
                    }
                    else if (input == "3")
                    {
                        Console.Clear();
                        isMenuPelanggan = false;
                    }
                }

            }
            else if (input == "2") // Menu Karyawan
            {
                bool isMenuKaryawan = true;
                while (isMenuKaryawan)
                {
                    Console.Clear();
                    Console.WriteLine("--Menu Karyawan--\n");

                    Console.WriteLine("1. Selesaikan pesanan teratas\n2. Lihat daftar pesanan\n3. Kembali");
                    input = Console.ReadLine();
                    if (input == "1")
                    {
                        if (Antrian.IsEmpty())
                        {
                            Console.Clear();
                            Console.Write("Tidak ada pesanan untuk diselesaikan");
                            Console.WriteLine("\n\nTekan tombol apa saja untuk kembali");
                            Console.ReadLine();
                        }
                        else
                        {
                            Pesanan item = Antrian.Dequeue();
                            Console.Clear();
                            Console.WriteLine($"Menyelesaikan pesanan atas nama \"{item.Nama}\" : ");

                            Thread.Sleep(500);

                            item.listMenu.TampilkanMenu();

                            Thread.Sleep(500);

                            Console.Write("\nMenyelesaikan");

                            AnimasiLoading();
                            Console.Clear();
                            Console.WriteLine("Pesanan Selesai");
                            Thread.Sleep(1200);
                            Console.WriteLine("\nTekan tombol apa saja untuk kembali");

                            Console.ReadLine();

                        }
                    }
                    else if (input == "2")
                    {
                        Console.Clear();
                        Console.WriteLine($"Total Pesanan : {Antrian.totalAntrian} ");
                        Antrian.TampilkanAntrian();

                        Console.WriteLine("\nTekan tombol apa saja untuk kembali");
                        Console.ReadLine();
                    }
                    else if (input == "3")
                    {
                        isMenuKaryawan = false;
                    }

                }
            }
            else //if (0 == string.Compare(input, "exit"))
            {
                isRunning = false;
                Console.Clear();
                break;
            }

        }



    }
    static void SelamatDatang()
    {
        Console.Clear();

        Console.WriteLine("Selamat Datang di McD ^-^\n");
        Console.WriteLine("Masuk sebagai : ");
        Console.WriteLine("1. Pelanggan\n2. Karyawan\n");
        Console.WriteLine("Masukan angka sesuai pengguna, ketik \"exit\" untuk mengakhiri program");
    }
    static void AnimasiLoading()
    {
        Thread.Sleep(500);
        Console.Write(" .");
        Thread.Sleep(500);
        Console.Write(" .");
        Thread.Sleep(500);
        Console.Write(" .");
        Thread.Sleep(500);
    }

}