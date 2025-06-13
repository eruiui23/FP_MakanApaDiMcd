using System;

namespace MakanApaDiMcd;

class Program
{
    static void Main()
    {
        bool isRunning = true;
        while (isRunning)
        {

            Queue<string> Antrian = new Queue<string>();

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
                    Antrian.Enqueue(Console.ReadLine());



                }
                else if (input == "2")
                {

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
            }

        }



    }
}