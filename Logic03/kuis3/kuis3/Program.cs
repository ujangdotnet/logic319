//KUIS LOGIC HARI KE 3

//Run & Handle Eror

try
{
    SoalDelapan();

}
catch (Exception e)
{
    Console.WriteLine("-----------");
    Console.WriteLine(e.Message);
    Console.WriteLine("-----------");
}

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
static void SoalTiga()
{
    Console.WriteLine("--Soal Nomor Tiga--");
    Console.WriteLine();
    Console.Write("Belanja \t:");
    int belanja = int.Parse(Console.ReadLine());
    Console.Write("Jarak \t:");
    int jarak = int.Parse(Console.ReadLine());
    Console.Write("Kode Promo \t:");
    string promo = Console.ReadLine();

    var diskon = 0;

    if (belanja >= 30000 || promo == "JKTOVO")
    {
        diskon = 4/100 * belanja;
        if (diskon > 30000)
        {
            diskon = 30000;
        }
    }


    //Output
    Console.WriteLine($"Belanja \t: {belanja}");
    Console.WriteLine($"Diskon 40% \t: {diskon}");
    Console.WriteLine($"Ongkir \t: ");
    Console.WriteLine($"Total Belanja \t: ");
}
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
    Console.Write("Tunjangan\t: ");
    int tunjangan = int.Parse(Console.ReadLine());
    Console.Write("Gapok\t\t: ");
    int gapok = int.Parse(Console.ReadLine());
    Console.Write("Banyak bulan\t: ");
    int bulan = int.Parse(Console.ReadLine());

    int jumlahGatun = gapok + tunjangan;
    double pajakGatun = 0;

    switch (jumlahGatun)
    {
        case > 10000000:
            pajakGatun = 0.15;
            break;
        case int x when x > 5000000 && x <= 10000000:
            pajakGatun = 0.10;
            break;
        case <= 5000000:
            pajakGatun = 0.05;
            break;
    }

    //inisiasi
    double pajak = 0;
    double bpjs = 0;
    double gaji = 0;
    double totalGaji = 0;

    pajak = pajakGatun * jumlahGatun;
    bpjs = 0.03 * jumlahGatun;
    gaji = jumlahGatun - (pajak + bpjs);
    totalGaji = (jumlahGatun - (pajak + bpjs)) * bulan;

    Console.WriteLine("--------------");
    Console.WriteLine($"Karyawan atas nama {nama},\nslip gaji anda sebagai berikut: ");
    Console.WriteLine();
    Console.WriteLine($"Pajak \t\t\t: {pajak}");
    Console.WriteLine($"BPJS \t\t\t: {bpjs}");
    Console.WriteLine($"Gaji/bulan \t\t: {gaji}");
    Console.WriteLine($"Total gaji/banyak bulan : {totalGaji}");

}

//Soal No 7

static void SoalTujuh()
{
    Console.WriteLine("--Soal Nomor Tujuh--");
    Console.WriteLine();

    //INPUT
    Console.Write("Berat badan anda (kg)\t: ");
    int berat = int.Parse(Console.ReadLine());
    Console.Write("Tinggi badan anda (cm)\t: ");
    double tinggi = double.Parse(Console.ReadLine())/100;
    


    //PROSES
    double bmi = berat / (tinggi * tinggi);
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

    float sortBmi = (float) bmi;

    //OUTPUT
    Console.WriteLine("----------------------");
    Console.WriteLine("Nilai BMI anda : {0:0.0000}", sortBmi);
    Console.WriteLine("Anda termasuk {0}", kategori);

}

//Soal No 8
static void SoalDelapan()
{
    Console.WriteLine("--Soal Nomor Delapan--");
    Console.WriteLine();

    //INPUT
    Console.Write("Masukan nilai MTK\t: ");
    int nilaiMTK = int.Parse(Console.ReadLine());
    Console.Write("Masukan nilai Fisika\t: ");
    int nilaiFisika = int.Parse(Console.ReadLine());
    Console.Write("Masukan nilai Kimia\t: ");
    int nilaiKimia = int.Parse(Console.ReadLine());

    //PROSES
    int jumlahNilai = nilaiMTK + nilaiFisika + nilaiKimia;
    float nilaiRata = jumlahNilai / 3f;
    string ucapan = "";

    switch (nilaiRata)
    {
        case float x when x >= 50 && x <= 100:
            ucapan = "Selamat\nKamu Berhasil\nKamu Hebat";
            break;
        case < 50:
            ucapan = "Maaf\nKamu Gagal";
            break;
    }

    //OUTPUT
    Console.WriteLine("----------------");
    Console.WriteLine($"Nilai rata-rata: {nilaiRata}");
    Console.WriteLine(ucapan);
}

