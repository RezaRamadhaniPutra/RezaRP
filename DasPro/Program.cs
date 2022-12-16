namespace HelloWorld
{}
//Reza Ramadhani Putra
class Program
{
    static void Main(string[] args)
    {
        const int a = 1;
        const int b = 2;
        const int c = 3;
        int tambah = a + b + c;
        int kali = a * b * c;
        int kurang = a - b - c;
        int bagi = a / b / c;

        Console.WriteLine("Anda adalah agen rahasia yang bertugas mendapatkan data dari server");
        Console.WriteLine("Akses ke server membutuhkan password yang tidak diketahui...");
        Console.WriteLine("-password terdiri dari 4 angka");
        Console.WriteLine("-Jika ditambahkan hasilnya " + tambah);
        Console.WriteLine("-Jika dikalikan hasilnya " + kali);
        Console.WriteLine("-Jika dikurangi hasilnyan " + kurang);
        Console.WriteLine("-Jika dibagi hasilnya " + bagi);
        Console.WriteLine("");
        Console.Write("Enter Code : ");
    }
}