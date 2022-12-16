/*Reza Ramadhani Putra 2207111389
*/
using System;

namespace Daspro
{
    class program
    {
        static int kesempatan = 2;
        static int level = 1;
        static bool bGameSelesai = true;
        //Main method
        static void Main(string[] args)
        {
            while (kesempatan > -1){
                Intro();

                Playgame();

                if(level >  5){
                    Console.WriteLine("Menang! Anda adalah Agen rahasia Terpilih!!!");
                    break;
                }
            }   if(kesempatan < 1){
                    Console.WriteLine("Kalah! Anda Bukan agen yang kami Cari!!!");
                }

            Console.WriteLine("Game Over");
                
            
        }
        static void Intro(){
            //Intro
            Console.WriteLine("Anda adalah agen rahasia yang bertugas mendapatkan data dari server...");
         
            Console.WriteLine("Akses ke server membutuhkan password yang tidak diketahui...");
        }

        static void Playgame(){
            //Deklarasi Variable
            int kodeA;
            int kodeB;
            int kodeC;
            int jumlahkode;
            string tebakanA;
            string tebakanB;
            string tebakanC;

            int hasiltambah;
            int hasilkali;

            //inisial Variable

            Random rng = new Random();

            kodeA = rng.Next(1,level + 1);
            kodeB = rng.Next(1,level + 1);
            kodeC = rng.Next(1,level + 1);

            jumlahkode = 3;

            //Operasi aritmatika
            hasiltambah = kodeA+kodeB+kodeC;
            hasilkali = kodeA*kodeB*kodeC;


            Console.WriteLine("Level " +level);
            Console.WriteLine("Pasword terdiri dari "+jumlahkode+" angka");
            Console.WriteLine("jika Ditambahkan hasilnya "+hasiltambah);
            Console.WriteLine("jika dikalikan hasilnya "+hasilkali);

            Console.Write("Masukkan Kode Pertama : ");
            tebakanA = Console.ReadLine();
            Console.Write("Masukkan Kode Kedua : ");
            tebakanB = Console.ReadLine();
            Console.Write("Masukkan Kode Ketiga : ");
            tebakanC = Console.ReadLine();
            Console.WriteLine("Tebakan anda "+tebakanA+" "+tebakanB+" "+tebakanC+"?");

            if(tebakanA == kodeA.ToString() && tebakanB == kodeB.ToString() && tebakanC == kodeC.ToString()){
                Console.WriteLine("Selamat, Tebakan anda benar...");

                //tambah level
                level += 1;
            }else{
                Console.WriteLine("Coba Lagi, Tebakan anda salah...");

                //kurang kesempatan
               Console.WriteLine("Kesempatan " +kesempatan);
                kesempatan = kesempatan - 1;
            }
         
        }

    }

}