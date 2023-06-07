//KUIS DAY 07

try
{
    SoalEmpat();

    Console.ReadKey();

}catch(Exception e)
{
    Console.WriteLine("--------------");
    Console.WriteLine(e.Message);
    Console.WriteLine("--------------");
}

//Soal Satu
//static void SoalSatu()
//{
//    Console.WriteLine("--Soal No 1--");
//    Console.WriteLine();

//    //INPUT
//    Console.Write("Masukan nilai n\t: ");
//    int nilai = int.Parse(Console.ReadLine());

//    var x = -5;
//    var y = 10;

//    for (int i = 0; i < nilai; i++)
//    {
//        if(i % 2 == 0)
//        {

//            Console.Write($"{x} ");
//            x -= 10;
//        } else
//        {
//            Console.Write($"{y} ");
//            y += 10;
//        }
//    }
//}

//Soal Dua
//static void SoalDua()
//{
//    Console.WriteLine("--Soal No 2--");
//    Console.WriteLine();

//    Console.WriteLine("Time Conversion");
//    Console.WriteLine();

//    //INPUT
//    Console.Write("Jam\t: ");
//    string jam = Console.ReadLine();
//    Console.Write("Menit\t: ");
//    string menit = Console.ReadLine();
//    Console.Write("Detik\t: ");
//    string detik =Console.ReadLine();
//    Console.Write("AM/ PM\t: ");
//    string tipe = Console.ReadLine();

//    //PROSES
//    Console.WriteLine("-----------------");

//    Console.WriteLine("Ubah dan cetak waktu menjadi format 24 jam:");
//    Console.WriteLine();

//    Console.WriteLine("Sample Input");
//    var waktuInput = $"{jam}:{menit}:{detik} {tipe.ToUpper()}";
//    Console.WriteLine(waktuInput);
//    Console.WriteLine();

//    Console.WriteLine("Sample Output");
//    DateTime waktuOutput = DateTime.Parse(waktuInput);
//    Console.Write(waktuOutput.ToString("HH:mm:ss"));

 

//}

//Soal Tiga
//static void SoalTiga()
//{
//    Console.WriteLine("--Soal No 3--");
//    Console.WriteLine();

//    //INPUT
//    Console.Write("Masukan kode baju\t: ");
//    int kodeBaju = int.Parse(Console.ReadLine());
//    Console.Write("Ukuran\t\t\t: ");
//    string ukuran = Console.ReadLine();

//    //PROSES
//    string merkBaju = "";
//    int hargaBaju = 0;

//    switch (kodeBaju)
//    {
//        case 1:
//            merkBaju = "IMP";

//            if (ukuran.ToUpper() == "S")
//            {
//                hargaBaju = 200000;

//            }else if (ukuran.ToUpper() == "M")
//            {
//                hargaBaju = 220000;
//            }else
//            {
//                hargaBaju = 250000;
//            }
//        break;

//        case 2:
//            merkBaju = "Prada";

//            if (ukuran.ToUpper() == "S")
//            {
//                hargaBaju = 150000;
//            }
//            else if (ukuran.ToUpper() == "M")
//            {
//                hargaBaju = 160000;
//            }
//            else
//            {
//                hargaBaju = 170000;
//            }
//            break;

//        case 3:
//            merkBaju = "Gucci";

//            if (ukuran.ToUpper() == "S")
//            {
//                hargaBaju = 200000;
//            }
//            else if (ukuran.ToUpper() == "M")
//            {
//                hargaBaju = 200000;
//            }
//            else
//            {
//                hargaBaju = 200000;
//            }
//            break;
//    }

//    //OUTPUT
//    Console.WriteLine("----------------------------");
//    Console.WriteLine($"Merk Baju\t= {merkBaju}");
//    Console.WriteLine($"Harga\t\t= {hargaBaju}");

//}

//Soal Empat
static void SoalEmpat()
{
    Console.WriteLine("--Soal No 4--");
    Console.WriteLine();

    //INPUT
    //Console.Write("Uang Andi\t: ");
    //int uangAndi = int.Parse(Console.ReadLine());
    //Console.Write("Harga Baju\t: ");
    //string hargaBaju = Console.ReadLine().Split(',');
    //string hargaBaju = Console.ReadLine();

    string angka = "30,40,50";
    //Console.WriteLine(hargaBaju);

    int[] x = Convert.ToInt32(angka.Split(','));

    foreach (int i in x)
    {

        Console.WriteLine($"{i} ");
    }
}

//Soal Lima
static void SoalLima()
{
    Console.WriteLine("--Soal No 5--");
    Console.WriteLine();


}

//Soal Enam
//static void SoalEnam()
//{
//    Console.WriteLine("--Soal No 6--");
//    Console.WriteLine();

//    //CARA 1

//        //INPUT
//    Console.WriteLine("Masukan 5 angka berbeda, dan pisahkan dengan koma: ");
//    string angka = Console.ReadLine();

//        //PROSES
//    string[] numbers = angka.Split(",");
//    Array.Sort(numbers);

//    foreach (string i in numbers)
//    {
//        Console.Write($"{i}, ");

//    }

//    //
//}