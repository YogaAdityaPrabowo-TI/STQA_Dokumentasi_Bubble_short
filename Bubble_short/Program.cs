using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble_short
{
    /// <summary>
    /// Bubble Sort adalah metode pengurutan algoritma dengan cara melakukan penukaran data secara terus menerus sampai bisa dipastikan dalam suatu iterasi tertentu tidak ada lagi perubahan/penukaran.
    /// </summary>
    class Program
    {
        /// <summary>
        /// deklarasi array int dengan ukuran 20
        /// </summary>
        private int[] a = new int[20];

        /// <summary>
        /// deklarasi variabel int untuk menyimpan banyaknya data pada array
        /// </summary>
        private int n;

        /// <summary>
        /// fungsi / method untuk meneriman masukan
        /// </summary>
        public void read()
        {
            // menerima angka untuk menentkan banyaknya data yang disimpan pada array
            while (true)
            {
                Console.Write("Masukan banyaknya elemen pada array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 20 elemen.\n");
            }
            Console.WriteLine("");
            Console.WriteLine("-----------------------");
            Console.WriteLine(" Masukan elemen array ");
            Console.WriteLine("-----------------------");

            // pengguna memasukan elemen pada array
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + "> ");
                string s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);
            }
        }
        /// <summary>
        /// fungsi / method untuk menampilkan
        /// </summary>
        public void display()
        {
            // menampilkan array yang tersusun
            Console.WriteLine("");
            Console.WriteLine("-----------------------");
            Console.WriteLine(" Masukan elemen array ");
            Console.WriteLine("-----------------------");
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine(a[j]);
            }
            Console.WriteLine("");
        }
        /// <summary>
        /// untuk mensortir elemen array
        /// </summary>
        public void BubbleSortArray()
        {
            for (int i = 1; i < n; i++) // for n -1 passes
            {
                // padaa pass i,bandingkan n - i elemen pertama dengan elemen selanjutnya
                for (int j = 0; j < n - i; j++)
                {
                    if (a[j] > a[j + 1])// jika elemen tidak dalam urutan yang benar
                    {
                        // tukar elemen
                        int temp;
                        temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                }
            }
        }
    }
        /// <summary>
        /// menarima,mengurutkan,menampilkan dan mengakhiri program.
        /// </summary>
        /// <param name="args">Parameter tersebut menerima argumen dari tipe string.</param>
        static void Main(string[] args)
        {
            // creating the object of the bubbleshort class
            Program myList = new Program();

            // pemanggilan fungsi untuk menerima elemen array
            myList.read();
            // pemanggilan fungsi untuk mengurutkan array
            myList.BubbleSortArray();
            // pemanggilan fungsi untuk menampilkan array yang tersusun
            myList.display();
            // exit
            Console.WriteLine("\n\nTekan Tombol Apa Saja Untuk Keluar.");
            Console.ReadKey();
        }
    }
}
