//LOGIC 07 PR

try
{
    SoalSepuluh();

    //Console.ReadKey();
}
catch (Exception e)
{
    Console.WriteLine("---------------");
    Console.WriteLine(e.Message);
    Console.WriteLine("---------------");
}

//Soal 1
static void SoalSatu()
{
    Console.WriteLine("Soal Satu");
    Console.WriteLine();

    //INPUT
    Console.Write("Input nilai x\t: ");
    int nilai = int.Parse(Console.ReadLine());

    //PROSES
    int x = 1;
    for (int i = nilai ; i >= 1 ; i--)
    {
        x *= i ;
    }
    Console.WriteLine($"Cara mereka duduk ada {x} cara.");
}

//Soal 2
static void SoalDua()
{
    Console.WriteLine("Soal Dua");
    Console.WriteLine();

    string kalimat = "SOSSPSSQSSOR";

    //string subs = kalimat.Substring();

    //Console.WriteLine(subs);

    //string[] strings = kalimat.Substring(0);
 
}

//Soal 3
static void SoalTiga()
{
    Console.WriteLine("Soal Tiga");
    Console.WriteLine();
    
    //Diketahui

        //DateTime meminjam = new DateTime(2019, 06, 09);
        DateTime mengembalikan = new DateTime(2019, 06, 12);
        DateTime dikembalikan = new DateTime(2019, 07, 10);
        //denda 500 per hari

    //Penyelasaian
    
    TimeSpan denda = dikembalikan - mengembalikan;

    int dendas = int.Parse(denda.ToString("dd"));
    dendas *= 500;

    Console.WriteLine($"Mono harus membayar denda sebesar Rp{dendas}");

}

//Soal 4
static void SoalEmpat()
{
    Console.WriteLine("Soal Empat");
    Console.WriteLine();

    Console.Write("Tanggal mulai (yyyy/mm/dd)\t: ");
    string tglMulai = Console.ReadLine();
    DateTime startDate = DateTime.Parse(tglMulai);
    Console.Write("Tanggal libur (pisahkan dengan koma): ");
    string tanggaLibur = Console.ReadLine();
    string[] tglLibur = tanggaLibur.Split(',');
    int[] hariLibur = Array.ConvertAll(tglLibur, int.Parse);
     
    DateTime date = startDate;

    for ( int i = 0; i < 10; i++)
    {
        if (date.DayOfWeek == DayOfWeek.Saturday)
        {
            date = date.AddDays(2);
        }
        for (int j = 0; j < hariLibur.Length; j++)
        {
            if (date.Day == hariLibur[j])
            {
                date = date.AddDays(1);
            }
        }
        date = date.AddDays(1);
    }

    Console.WriteLine($"Kelas akan ujian pada {date.ToString("D")}");
    
}

//Soal 5
static void SoalLima()
{
    Console.WriteLine("Soal Lima");
    Console.WriteLine();

    //INPUT
    Console.Write("Masukan kalimat\t: ");
    string nama = Console.ReadLine().ToLower( );

    //PROSES
    char[] namaS = nama.ToCharArray(); ;

    int hurufVokal = 0;
    int hurufKonsonan = 0;

    foreach (char s in namaS)
    {

        switch (s)
        {
            case char x when x == 'a' || x == 'i' || x == 'u' || x == 'e' || x == 'o':
                hurufVokal += 1;
                break;
            case char x when x >= 'a' && x <= 'z':
                hurufKonsonan += 1;
                break;
            default:
                hurufVokal += 0;
                hurufKonsonan += 0;
                break;
        }

    }

    //OUTPUT
    Console.WriteLine($"Huruf vokal\t= {hurufVokal}");
    Console.Write($"Huruf konsonan\t= {hurufKonsonan}");


}

//Soal 6
static void SoalEnam()
{
    Console.WriteLine("Soal Enam");
    Console.WriteLine();

    //INPUT
    Console.Write("Masukan nama\t: ");
    string nama = Console.ReadLine().ToLower();

    //PROSES
    char[] namaChar = nama.ToCharArray();

    //Cara 1
    foreach (char c in namaChar)
    {
       
        Console.WriteLine($"***{c}***");
    }

}

//Soal 7
static void SoalTujuh()
{
    Console.WriteLine("Soal Tujuh");
    Console.WriteLine();

    //INPUT
    Console.Write("Jumlah menu\t\t: ");
    int Menu = int.Parse(Console.ReadLine());
    Console.Write("Index makanan alergi\t: ");
    int index = int.Parse(Console.ReadLine());
    Console.Write("Harga menu\n(tulis tanpa titik\n& pisahkan dengan koma)\t: ");
    string harga = Console.ReadLine();
    string[] hargaS = harga.Split(',');
    int[] hargaArr = Array.ConvertAll(hargaS, int.Parse);
    Console.Write("Jumlah uang Elsa\t: ");
    int uang = int.Parse(Console.ReadLine());

    //PROSES

    int makananAlergi = hargaArr[index];
    int totalMakanan = 0;

    foreach(char c in hargaArr)
    {
        totalMakanan += c;
    }
        //iniasiasi ulang nilai variabel
        totalMakanan -= makananAlergi;

    int yangHarusDibayar = totalMakanan / 2;
    int sisaUang = uang - yangHarusDibayar;

    //OUTPUT
    if( sisaUang == 0)
    {
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("Uang pas");
    } else if (sisaUang < 0)
    {
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine($"Elsa harus membayar\t= Rp{yangHarusDibayar}");
        Console.WriteLine($"Uang kamu kurang {sisaUang}");
    } else
    {

        Console.WriteLine("--------------------------------------------");
        Console.WriteLine($"Elsa harus membayar\t= Rp{yangHarusDibayar}");
        Console.WriteLine($"Sisa uang elsa\t\t= Rp{sisaUang}");
    }


}

//Soal 8
static void SoalDelapan()
{
    Console.WriteLine("Soal Delapan");
    Console.WriteLine();

    //INPUT
    Console.Write("Masukan angka\t: ");
    int n = int.Parse(Console.ReadLine());

    for (int i = 1; i <= n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (j < n - i)
            {
                Console.Write(" ");
            }
            else
            {
                Console.Write("*");
            }
        }
        Console.WriteLine();
    }

}

//Soal 9
static void SoalSembilan()
{
    Console.WriteLine("Soal Sembilan");
    Console.WriteLine();
    
    //INPUT
    Console.Write("Masukan 9 angka bilangan bulat\n(pisahkan dengan koma)\t: ");
    string angka = Console.ReadLine();
    string[] angkaS = angka.Split(',');
    int[] angkaArr = Array.ConvertAll(angkaS, int.Parse);

    Console.WriteLine();
    Console.WriteLine("-----------------------------");
    for (int i = 0; i < 9; i++)
    {
        if ( i == 3 || i == 6)
        {
            Console.WriteLine();
        }

        Console.Write($" {angkaArr[i]}\t");
        
    }

    int diagonalPertama = angkaArr[0] + angkaArr[4] + angkaArr[8];
    int diagonalKedua = angkaArr[2] + angkaArr[4] + angkaArr[6];

    int perbedaan = diagonalPertama - diagonalKedua;

    Console.WriteLine();
    Console.WriteLine("-----------------------------");
    Console.WriteLine($"Perbedaan |{diagonalPertama} - {diagonalKedua}| = {perbedaan}");

}

static void SoalSembilan2()
{
    Console.WriteLine("--Soal Sembilan Cara 2--");
    int[,] angkaArr = { 
        { 11, 2, 4 },       // (0,0) (0,1) (0,2)
        { 4, 5, 6 },        // (1,0) (1,1) (1,2)
        { 10, 8, -12 } };   // (2,0) (2,1) (2,2)

    int diagonalPertama = 0;
    int diagonalKedua = 0;
    string dayaTampungDP = "";
    string dayaTampungDK = "";
    for (int i = 0; i < angkaArr.GetLength(0); i++)
    {
        for (int j = 0; j < angkaArr.GetLength(1); j++)
        {
            if (i == j)
            {
                diagonalPertama += angkaArr[i,j];
                //dayaTampungDP += String.Join("\t", angkaArr[i,j]);
                switch (dayaTampungDP)
                {
                    case "":
                        dayaTampungDP += angkaArr[i, j].ToString();
                        break;
                }
                dayaTampungDP += dayaTampungDP == "" ? angkaArr[i,j].ToString() : angkaArr[i,j] < 0 ? " + " + $"({angkaArr[i, j].ToString()})" : " + " + angkaArr[i, j].ToString(); //$"({angkaArr[i, j].ToString()})"

            }
            if (j == angkaArr.GetLength(1) - 1 - i)
            {
                diagonalKedua += angkaArr[i,j];
                dayaTampungDK += dayaTampungDK == "" ? angkaArr[i, j].ToString() : angkaArr[i, j] < 0 ? " + " + $"({angkaArr[i, j].ToString()})" : " + " + angkaArr[i, j].ToString();

            }
            Console.Write($"{angkaArr[i, j]}\t");
        }
        Console.WriteLine();
    }

    Console.WriteLine("--------------------");
    int perbedaan = diagonalPertama - diagonalKedua;

    Console.WriteLine();
    Console.WriteLine("------------------------");
    Console.WriteLine($"Diagonal pertama: {dayaTampungDP} = {diagonalPertama}");
    Console.WriteLine($"Diagonal kedua: {dayaTampungDK} = {diagonalKedua}");
    Console.WriteLine("------------------------");
    Console.WriteLine($"Perbedaan |{diagonalPertama} - {diagonalKedua}| = {perbedaan}");

}

//Soal 10
static void SoalSepuluh()
{
    Console.WriteLine("Soal Sepuluh");
    Console.WriteLine();

    Console.Write("Masukan 4 angka bilangan bulat\n(pisahkan dengan koma)\t: ");
    string angka = Console.ReadLine();
    string[] angkaS = angka.Split(',');
    int[] angkaArr = Array.ConvertAll(angkaS, int.Parse);


    string s = "";
    for(int i = 0; i < angkaArr.Length; i++)
    {
        if (angkaArr[i] == angkaArr.Max())
        {
            s += String.Join(",", angkaArr[i]);
        }
    }

    Console.WriteLine("---------------");
    Console.WriteLine($"Jumlah angka tertinggi ada {s.Length}\nyaitu angka {angkaArr.Max()}.");
    //Console.Write(s.Length);
     

}
