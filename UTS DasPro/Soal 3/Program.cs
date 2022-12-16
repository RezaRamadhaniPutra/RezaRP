using System;

namespace TiketBioskop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            string Harga;
            Console.WriteLine("Nama : ");
            string Nama = Console.ReadLine();
            Console.WriteLine("Tahun Lahir : ");
            int TahunLahir = Convert.ToInt32(Console.ReadLine());
            
            int Usia = 2022 - TahunLahir;
            
            if(Usia < 10 || Usia > 60)
            {
                Harga = "Rp. 10.000";
            }
            else
            {
                Harga = "Rp. 25.000";
            }
            Console.WriteLine("|****************************|");
            Console.WriteLine("|       -- STUDIO 1 --       |");
            Console.WriteLine(String.Format("|{0,-14}{1,-14}|", "Nama  :    " ,Nama ));
            Console.WriteLine(String.Format("|{0,-14}{1,-14}|", "Harga :    ", Harga));
            Console.WriteLine("|----------------------------|");     
        }  
    }
}
