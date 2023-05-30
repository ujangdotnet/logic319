//Logic Kuis

// Soal No 1

    //soalNoSatu();

    //static void soalNoSatu()
    //{
    //    double keliling, luas;
    //    //double phi = 3.14;
    //    Console.WriteLine("--Luas dan keliling Lingkaran");
    //    Console.WriteLine();
    //    Console.Write("Masukan nilai jari-jari (r) : ");
    //    int r = int.Parse(Console.ReadLine());

    //    keliling = 2 * Math.PI * r;
    //    luas = Math.PI * r * r;

    //    Console.WriteLine($"Jumlah keliling: {keliling}");
    //    Console.WriteLine($"Jumlah luas: {luas}");
    //}


//Soal No 2

//soalNoDua();

//static void soalNoDua()
//{
//    double luas, keliling;

//    Console.WriteLine("--Luas dan Keliling Persegi");
//    Console.WriteLine();
//    Console.Write("Masukan nilai sisi (s): ");
//    int s = int.Parse(Console.ReadLine());

//    luas = s * s;
//    keliling = 4 * s;

//    Console.WriteLine($"Jadi, luas persegi adalah {luas}");
//    Console.WriteLine($"Jadi, keliling persegi adalah {keliling}");
//}


// Soal No 3

//soalNoTiga();

//static void soalNoTiga()
//{
//    Console.WriteLine("--Hasil Modulo--");
//    Console.WriteLine();
//    Console.Write("Masukan angka: ");
//    int x = int.Parse(Console.ReadLine());
//    Console.Write("Masukan pembagi: ");
//    int y = int.Parse(Console.ReadLine());

//    int hasilModulo = x % y;

//    if (hasilModulo == 0)
//    {
//        Console.WriteLine($"Angka {x} & Pembagi {y} adalah {hasilModulo}");
//    }
//    else
//    {
//        Console.WriteLine($"Angka {x} & Pembagi {y} bukan 0. Melainkan hasil mod = {hasilModulo}.");
//    }
//}


// Soal No 4

soalNoEmpat();

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

//soalNoLima();

//static void soalNoLima()
//{
//    Console.WriteLine("--Grade Nilai--");
//    Console.WriteLine();
//    Console.Write("Silahkan input nilai: ");
//    int nilai = int.Parse(Console.ReadLine());

//    if (nilai >= 80)
//    {
//        Console.WriteLine("Kamu mendapatkan nilai A");
//    }
//    else if (nilai >= 60 && nilai < 80)
//    {
//        Console.WriteLine("Kamu mendapatkan nilai B");
//    }
//    else
//    {
//        Console.WriteLine("Kamu mendapatkan nilai C");
//    }
//}


// Soal No 6

//soalNoEnam();

//static void soalNoEnam()
//{
//    Console.WriteLine("--Ganjil Genap--");
//    Console.WriteLine();
//    Console.Write("Silahkan masukan nilai: ");
//    int nilai = int.Parse(Console.ReadLine());

//    if ( nilai % 2 == 0)
//    {
//        Console.WriteLine($"Angka {nilai} adalah genap");
//    }else
//    {
//        Console.WriteLine($"Angka {nilai} adalah ganjil"); 
//    }
//}