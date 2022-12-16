using System;

namespace KonversiUang
{        
    class program
    {
        static void Main(string []args)
        {
            Console.Clear();
            Console.WriteLine("Rate USD ke RP");
            double RateUSD = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Jumlah USD");
            double JumlahUang = Convert.ToDouble(Console.ReadLine());

            double Hasil = RateUSD * JumlahUang;
            Console.WriteLine("Hasil Konversi : "+Hasil);
            Console.ReadLine();
        }
    }
}