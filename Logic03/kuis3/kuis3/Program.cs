//KUIS LOGIC HARI KE 3

SoalEmpat();

//Soal No 1
static void SoalSatu()
{
    Console.WriteLine("--Soal Nomor Satu--");
    Console.WriteLine();
    Console.Write("Masukan nilai (1 -100): ");
    int nilai = int.Parse(Console.ReadLine());

    if (nilai >= 90 && nilai <= 100)
    {
        Console.WriteLine("Grade A");

    }else if (nilai >= 70 && nilai <= 89)
    {
        Console.WriteLine("Grade B");

    }else if (nilai >= 50 && nilai <= 69)
    {
        Console.WriteLine("Grade C");

    }else
    {
        Console.WriteLine("Grade E");
    }
}

//Soal No 2
static void SoalDua()
{
    Console.WriteLine("--Soal Nomor Dua--");
    Console.WriteLine();
    Console.Write("Masukan Jumlah Pulsa: ");
    int pulsa = int.Parse(Console.ReadLine());

    if (pulsa >= 10000 && pulsa < 25000)
    {
        Console.WriteLine($"Pulsa \t: {pulsa}");
        Console.WriteLine($"Point \t: 80");
    } else if (pulsa >= 25000 && pulsa < 50000)
    {
        Console.WriteLine($"Pulsa \t: {pulsa}");
        Console.WriteLine($"Point \t: 200");
    }else if (pulsa >= 50000 && pulsa < 100000)
    {
        Console.WriteLine($"Pulsa \t: {pulsa}");
        Console.WriteLine($"Point \t: 400");
    }else if (pulsa >= 100000)
    {
        Console.WriteLine($"Pulsa \t: {pulsa}");
        Console.WriteLine($"Point \t: 800");
    }else
    {
        Console.WriteLine($"Pulsa \t: {pulsa}");
        Console.WriteLine($"Point \t: 0");
    }

}

//Soal No 3

static void SoalTiga()
{
    Console.WriteLine("--Soal Nomor Tiga--");
    Console.WriteLine();
}

//Soal No 4

static void SoalEmpat()
{
    Console.WriteLine("--Soal Nomor Empat--");
    Console.WriteLine();
    Console.Write("Belanja \t:");
    int belanja = int.Parse(Console.ReadLine());
    Console.Write("Ongkos kirim \t:");
    int ongkir = int.Parse(Console.ReadLine());
    Console.Write("Pilihan Voucher \t:");
    int voucher = int.Parse(Console.ReadLine());

    int diskonOngkir;
    int diskonBelanja;

    if (belanja >= 100000 && voucher == 1)
    {
        diskonOngkir = 2000;
        diskonBelanja = 10000;

    }else if (belanja >= 50000 && voucher == 2)
    {
        diskonOngkir = 10000;
        diskonBelanja = 10000;

    }else if (belanja >= 30000 && voucher == 3)
    {
        diskonOngkir = 5000;
        diskonBelanja = 5000;
    }else
    {
        diskonBelanja = 0;
        diskonOngkir = 0;
    }

    int totalBelanja = (belanja + ongkir) - (diskonOngkir + diskonBelanja);

    Console.WriteLine($"Total belanja anda: {totalBelanja}");

}

//Soal No 5
static void SoalLima()
{
    Console.WriteLine("--Soal Nomor Lima--");
    Console.WriteLine();
    Console.Write("Masukan nama: ");
    string nama = Console.ReadLine();
    Console.Write("Tahun lahir: ");
    int tahunLahir = int.Parse(Console.ReadLine());

    if (tahunLahir >= 1944 && tahunLahir <= 1964)
    {
        Console.WriteLine($"{nama}, berdasarkan tahun lahir anda tergolong Baby Groomer");

    }else if (tahunLahir >= 1965 && tahunLahir <= 1979)
    {
        Console.WriteLine($"{nama}, berdasarkan tahun lahir anda tergolong Generasi X");

    }else if (tahunLahir >= 1980 && tahunLahir <= 1994)
    {
        Console.WriteLine($"{nama}, berdasarkan tahun lahir anda tergolong Generasi Y (Millenials)");

    }else if (tahunLahir >= 1995 && tahunLahir <= 2015)
    {
        Console.WriteLine($"{nama}, berdasarkan tahun lahir anda tergolong Generasi Z");
    }else
    {
        Console.WriteLine($"{nama}, berdasarkan tahun lahir anda tidak punya golongan :(");
    }
}

//Soal No 6

static void SoalEnam()
{
    Console.WriteLine("--Soal Nomor Enam--");
    Console.WriteLine();
    Console.Write("Nama: ");
    string nama = Console.ReadLine();
    Console.Write("Tunjangan: ");
    int tunjangan = int.Parse(Console.ReadLine());
    Console.Write("Gapok: ");
    int gapok = int.Parse(Console.ReadLine());
    Console.Write("Banyak bulan: ");
    int bulan = int.Parse(Console.ReadLine());

    int jumlahGatun = gapok + tunjangan;
    var pajakGatun = 0;

    if (jumlahGatun <= 5000000)
    {
        pajakGatun = 3 / 100;

    }else if (jumlahGatun >= 5000000 && jumlahGatun <= 10000000)
    {
        pajakGatun = 10 / 100;

    }else if (jumlahGatun > 10000000)
    {
        pajakGatun = 15 / 100;
    }else
    {
        pajakGatun = 0;
    }

    //inisiasi

    var pajak = pajakGatun * jumlahGatun;
    var bpjs = (3/100) * jumlahGatun;
    var gaji = jumlahGatun - (pajak + bpjs);
    var totalGaji = jumlahGatun - ((pajak + bpjs) * bulan);

    Console.WriteLine($"Karyawan atas nama {nama} slip gaji sebagai berikut: ");
    Console.WriteLine($"Pajak \t {pajak}");
    Console.WriteLine($"BPJS \t {bpjs}");
    Console.WriteLine($"Gaji/bulan \t {gaji}");
    Console.WriteLine($"Total gaji/banyak bulan \t {totalGaji}");

    //kendala di type casting
}

//Soal No 7

static void SoalTujuh()
{
    Console.WriteLine("--Soal Nomor Tujuh--");
    Console.WriteLine();
    Console.Write("Berat badan anda (kg): ");
    int berat = int.Parse(Console.ReadLine());
    Console.Write("Tinggi badan anda (cm): ");
    double tinggi = double.Parse(Console.ReadLine())/100;

    double bmi = berat / (tinggi * tinggi);

    if (bmi >= 25)
    {
        Console.WriteLine($"Nilai BMI anda {bmi}\n Anda temasuk berbadan gemuk!");
    } else if (bmi >= 18.5 && bmi < 25)
    {
        Console.WriteLine($"Nilai BMI anda {bmi}\n Anda temasuk berbadan langsing/sehat!");
    }else
    {
        Console.WriteLine($"Nilai BMI anda {bmi}\n Anda terlalu kurus!");
    }
}

//Soal No 8

static void SoalDelapan()
{
    Console.WriteLine("--Soal Nomor Delapan--");
    Console.WriteLine();
    Console.Write("Masukan nilai MTK: ");
    int nilaiMTK = int.Parse(Console.ReadLine());
    Console.Write("Masukan nilai Fisika: ");
    int nilaiFisika = int.Parse(Console.ReadLine());
    Console.Write("Masukan nilai Kimia: ");
    int nilaiKimia = int.Parse(Console.ReadLine());

    int jumlahNilai = nilaiMTK + nilaiFisika + nilaiKimia;
    int nilaiRata = jumlahNilai / 3;

    if (nilaiRata >= 75 && nilaiRata <= 100)
    {
        Console.WriteLine($"Nilai rata-rata: {nilaiRata}");
        Console.WriteLine("Selamat\nKamu Berhasil\nKamu Hebat");
    }else
    {
        Console.WriteLine($"Nilai rata-rata: {nilaiRata}");
        Console.WriteLine("Maaf\nKamu Gagal");
    }
}