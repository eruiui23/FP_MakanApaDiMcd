using System;

namespace MakanApaDiMcd;

class Program
{
    static void Main()
    {
        Queue Antrian = new Queue();

        bool isRunning = true;
        while (isRunning)
        {
            Console.Clear();
            int mode;
            Console.WriteLine("\nSelamat Datang di McD ^-^\n");
            Console.WriteLine("Masuk sebagai : ");
            Console.WriteLine("1. Pelanggan\n2. Karyawan\n");
            Console.WriteLine("Masukan angka sesuai pengguna, ketik \"exit\" untuk mengakhiri program");

            string? input = Console.ReadLine();

            if (0 == string.Compare(input, "exit"))
            {
                isRunning = false;
                Console.Clear();
                break;
            }

            // mode = int.Parse(input);
            if (input == "1")
            {
                Console.Clear();
                Console.WriteLine("\n1. Pesanan baru\n2. Pesanan terdaftar\n3. kembali");

                input = Console.ReadLine();
                if (input == "1")
                {


                    Console.Clear();
                    Console.WriteLine("Masukan nama :");
                    Antrian.Enqueue(new Pesanan(Console.ReadLine()));


                }
                else if (input == "2")
                {
                    Console.Clear();
                    Console.WriteLine(Antrian.Peek());
                    Console.ReadLine();
                }
                else
                {
                    Console.Clear();
                }

            }
            else if (input == "2")
            {
                Console.Clear();
                // display queue dan total pesanan
                Console.WriteLine("\n1. Selesaikan pesanan teratas\n2. Kembali");
                if (Console.ReadLine() == "1")
                {
                    Antrian.Dequeue();
                }
            }

        }



    }
}