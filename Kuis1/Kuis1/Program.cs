//Logic Kuis

luasKeliling();

static void luasKeliling()
{
    double keliling, luas;
    //double phi = 3.14;
    Console.WriteLine("--Luas dan keliling Lingkaran");
    Console.WriteLine();
    Console.Write("Masukan nilai jari-jari (r) : ");
    int r = int.Parse(Console.ReadLine());

    keliling = 2 * Math.PI * r;
    luas = Math.PI * r * r;

    Console.WriteLine($"Jumlah keliling: {keliling}");
    Console.WriteLine($"Jumlah luas: {luas}");
}