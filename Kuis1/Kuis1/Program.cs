//Logic Kuis

//Run
//soalNoSatu();
//soalNoDua();
//soalNoTiga();
//soalNoEmpat();
//soalNoLima();
soalNoEnam();


// Soal No 1

static void soalNoSatu()
{
    double keliling, luas;
    //double phi = 3.14;
    Console.WriteLine("--Luas dan keliling Lingkaran");
    Console.WriteLine();
    Console.Write("Masukan nilai jari-jari (r) : ");
    int r = int.Parse(Console.ReadLine());

    keliling = 2 * Math.PI * r;
    luas = Math.PI * r * r;

    Console.WriteLine($"Jumlah keliling: {keliling} cm");
    Console.WriteLine($"Jumlah luas: {luas} cm^3");
}


//Soal No 2

static void soalNoDua()
{
    double luas, keliling;

    Console.WriteLine("--Luas dan Keliling Persegi");
    Console.WriteLine();
    Console.Write("Masukan nilai sisi (s): ");
    int s = int.Parse(Console.ReadLine());

    luas = s * s;
    keliling = 4 * s;

    Console.WriteLine($"Jadi, luas persegi adalah {luas}");
    Console.WriteLine($"Jadi, keliling persegi adalah {keliling}");
}


// Soal No 3

static void soalNoTiga()
{
    Console.WriteLine("--Hasil Modulo--");
    Console.WriteLine();
    Console.Write("Masukan angka: ");
    int x = int.Parse(Console.ReadLine()); //input angka
    Console.Write("Masukan pembagi: ");
    int y = int.Parse(Console.ReadLine()); //input pembagi

    int hasilModulo = x % y;

    if (hasilModulo == 0)
    {
        Console.WriteLine($"Angka {x} & Pembagi {y} adalah {hasilModulo}");
    }
    else
    {
        Console.WriteLine($"Angka {x} & Pembagi {y} bukan 0. Melainkan hasil mod = {hasilModulo}.");
    }
}


// Soal No 4

static void soalNoEmpat()
{
    int batangRokok = 0;
    int hargaRokok = 0;
    int sisaPuntung = 0;
    Console.WriteLine("--Hitung Rokok--");
    Console.WriteLine();
    Console.Write("Masukan jumlah rokok yang dipungut: ");
    int rokok = int.Parse(Console.ReadLine());

    batangRokok = rokok / 8;
    hargaRokok = batangRokok * 500;
    sisaPuntung = batangRokok % 8;

    Console.WriteLine($"Pemulung mendapatkan {batangRokok}");
    Console.WriteLine($"Pemulung Menghasilkan {hargaRokok}");
    Console.WriteLine($"Sisa puntung rokok adalah {sisaPuntung}");

}


// Soal No 5

static void soalNoLima()
{
    Console.WriteLine("--Grade Nilai--");
    Console.WriteLine();
    Console.Write("Silahkan input nilai: ");
    int nilai = int.Parse(Console.ReadLine());

    if (nilai >= 80 && nilai <= 100)
    {
        Console.WriteLine("Kamu mendapatkan nilai A");
    }
    else if (nilai >= 60 && nilai < 80)
    {
        Console.WriteLine("Kamu mendapatkan nilai B");
    }
    else if(nilai >= 1 && nilai <60)
    {
        Console.WriteLine("Kamu mendapatkan nilai C");
    }
    else
    {
        Console.WriteLine("Nilai tidak sesuai, silahkan masukan angka sesuai range (1 - 100)");
    }
}


// Soal No 6

static void soalNoEnam()
{
    Console.WriteLine("--Ganjil Genap--");
    Console.WriteLine();
    Console.Write("Silahkan masukan nilai: ");
    int nilai = int.Parse(Console.ReadLine());

    if (nilai % 2 == 0)
    {
        Console.WriteLine($"Angka {nilai} adalah genap");
    }
    else
    {
        Console.WriteLine($"Angka {nilai} adalah ganjil");
    }
}