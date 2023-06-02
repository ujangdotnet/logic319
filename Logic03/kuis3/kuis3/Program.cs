//KUIS LOGIC HARI KE 3

SoalEnam();

//Soal No 1
static void SoalSatu()
{
    Console.WriteLine("--Soal Nomor Satu--");
    Console.WriteLine();
    Console.Write("Masukan nilai (1 -100): ");
    int nilai = int.Parse(Console.ReadLine());

    //inisiasi variabel
    string ucapan = "";

    switch (nilai)
    {
        case int x when x >= 90 && x <= 100:
            ucapan = "Grade A";
            break;
        case int x when x >= 70 && x <= 89:
            ucapan = "Grade B";
            break;
        case int x when x >= 50 && x <= 69:
            ucapan = "Grade C";
            break;
        case int x when x > 1 && x < 50:
            ucapan = "Grade E";
            break;
        default:
            Console.WriteLine($"Maaf, nilai yang anda masukan salah.");
            break;
    }

    Console.WriteLine($"Selamat, kamu mendapatkan {ucapan}");
}
//

//Soal No 2
static void SoalDua()
{
    Console.WriteLine("--Soal Nomor Dua--");
    Console.WriteLine();
    Console.Write("Masukan Jumlah Pulsa: ");
    int pulsa = int.Parse(Console.ReadLine());

    //inisiasi variabel
    int point = 0;

    switch (pulsa)
    {
        case int x when x >= 10000 && x < 25000:
            point = 80;
            break;
        case int x when x >= 25000 && x < 50000:
            point = 200;
            break;
        case int x when x >= 50000 && x < 100000:
            point = 400;
            break;
        case >= 100000:
            point = 800;
            break;
        default:
            Console.WriteLine($"Maaf, anda tidak mendapatkan point.");
            break;
    }

    Console.WriteLine($"Pulsa \t: {pulsa}");
    Console.WriteLine($"Point \t: {point}");
}
//

//Soal No 3
//static void SoalTiga()
//{
//    Console.WriteLine("--Soal Nomor Tiga--");
//    Console.WriteLine();
//}
//

//Soal No 4
static void SoalEmpat()
{
    Console.WriteLine("--Soal Nomor Empat--");
    Console.WriteLine();
    Console.Write("Belanja \t:");
    int belanja = int.Parse(Console.ReadLine());
    Console.Write("Ongkos kirim \t:");
    int ongkir = int.Parse(Console.ReadLine());
    Console.Write("Pilihan Voucher\t:");
    int voucher = int.Parse(Console.ReadLine());

    //deklarasi voucher &diskon belanja
    int freeOngkir = 0;
    int diskonBelanja = 0;

    switch (belanja, voucher)
    {
        case ( >= 100000, 3):
            freeOngkir = 20000;
            diskonBelanja = 10000;
            break;
        case ( >= 50000, 2):
            freeOngkir = 10000;
            diskonBelanja = 10000;
            break;
        case ( >= 30000, 1):
            freeOngkir = 5000;
            diskonBelanja = 5000;
            break;
        default:
            Console.WriteLine($"Maaf, voucher tidak tersedia.");
            break;
    }

    int totalBelanja = (belanja + ongkir) - (freeOngkir + diskonBelanja);
    Console.WriteLine($"--------------------------");
    Console.WriteLine($"Total belanja anda: {totalBelanja}");

}
//

//Soal No 5
static void SoalLima()
{
    Console.WriteLine("--Soal Nomor Lima--");
    Console.WriteLine();
    Console.Write("Masukan nama\t: ");
    string nama = Console.ReadLine();
    Console.Write("Tahun lahir\t: ");
    int tahunLahir = int.Parse(Console.ReadLine());

    string generasi;

    switch (tahunLahir)
    {
        case int x when x >= 1944 && x <= 1964:
            generasi = "Baby boomer";
            break;
        case int x when x >= 1965 && x <= 1979:
            generasi = "Generasi X";
            break;
        case int x when x >= 1980 && x <= 1994:
            generasi = "Generasi Y (Millenials)";
            break;
        case int x when x >= 1995 && x <= 2015:
            generasi = "Generasi Z";
            break;
        default:
            generasi = "Tidak mempunyai generasi";
            break;
    }

    Console.WriteLine($"----------------");
    Console.WriteLine($"{nama}, berdasarkan tahun lahir anda  {generasi}");
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
    float pajakGatun = 0;

    switch (jumlahGatun)
    {
        case > 10000000:
            pajakGatun = 15 / 100;
            break;
        case int x when x > 5000000 && x <= 10000000:
            pajakGatun = 10 / 100;
            break;
        case <= 10000000:
            pajakGatun = 3 / 100;
            break;
    }

    //inisiasi

    float pajak = pajakGatun * jumlahGatun;
    float bpjs = (3/100) * jumlahGatun;
    float gaji = jumlahGatun - (pajak + bpjs);
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
    Console.Write("Berat badan anda (kg)\t: ");
    int berat = int.Parse(Console.ReadLine());
    Console.Write("Tinggi badan anda (cm)\t: ");
    double tinggi = double.Parse(Console.ReadLine())/100;

    //deklarasi rumus bmi
    double bmi = berat / (tinggi * tinggi);

    //inisiasi var kategori badan
    string kategori = "";

    switch (bmi)
    {
        case >= 25:
            kategori = "Berbadan Gemuk";
            break;
        case double x when x >= 18.5 && x < 25:
            kategori = "Berbadan Langsing/ Sehat";
            break;
        case < 18.5:
            kategori = "Terlalu Kurus";
            break;
    }

    Console.WriteLine($"Nilai BMI anda {bmi}\nAnda temasuk {kategori}");
}

//Soal No 8
static void SoalDelapan()
{
    Console.WriteLine("--Soal Nomor Delapan--");
    Console.WriteLine();
    Console.Write("Masukan nilai MTK\t: ");
    int nilaiMTK = int.Parse(Console.ReadLine());
    Console.Write("Masukan nilai Fisika\t: ");
    int nilaiFisika = int.Parse(Console.ReadLine());
    Console.Write("Masukan nilai Kimia\t: ");
    int nilaiKimia = int.Parse(Console.ReadLine());

    int jumlahNilai = nilaiMTK + nilaiFisika + nilaiKimia;
    double nilaiRata = jumlahNilai / 3;
    string ucapan = "";

    switch (nilaiRata)
    {
        case double x when x >= 50 && x <= 100:
            ucapan = "Selamat\nKamu Berhasil\nKamu Hebat";
            break;
        case < 50:
            ucapan = "Maaf\nKamu Gagal";
            break;
    }

    Console.WriteLine("----------------");
    Console.WriteLine($"Nilai rata-rata: {nilaiRata}");
    Console.WriteLine(ucapan);
}
