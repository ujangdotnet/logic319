//Kuis 04

try
{
    SoalEmpat();

} catch (Exception e)
{
    Console.WriteLine("-----------------");
    Console.WriteLine(e.Message);
    Console.WriteLine("-----------------");
}



//Nomer 1
static void SoalSatu()
{
    Console.WriteLine("--Soal Nomer 1--");
    Console.WriteLine();

    //INPUT
    Console.Write("Golongan\t: ");
    int golongan = int.Parse(Console.ReadLine());
    Console.Write("Jam kerja\t: ");
    int jamKerja = int.Parse(Console.ReadLine());

    //PROSES
    int upah = 0;
    var upahLembur = 0;

        //Algorithm completion

        switch (golongan)
        {
        //Golongan 1
        case 1:
            if (jamKerja > 40)
            {
                upah = 2000 * 40;
                upahLembur = 2000 * 3 / 2;
            }
            else
            {
                upah = 2000 * jamKerja;
            }
            break;

        //Golongan 2
        case 2:
            if (jamKerja > 40)
            {
                upah = 3000 * 40;
                upahLembur = 3000 * 3 / 2;
            }
            else
            {
                upah = 3000 * jamKerja;
            }
            break;

        //Golongan 3
        case 3:
            if (jamKerja > 40)
            {
                upah = 4000 * 40;
                upahLembur = 4000 * 3 / 2;
            }
            else
            {
                upah = 4000 * jamKerja;
            }
            break;

        //Golongan 4
        case 4:
            if (jamKerja > 40)
            {
                upah = 5000 * 40;
                upahLembur = 5000 * 3 / 2;
            }
            else
            {
                upah = 5000 * jamKerja;
            }
            break;

        //Tidak termasuk golongan
        default:
            Console.WriteLine("Golonganmu tidak tersedia");
            break;
        }

        //rumus
        upahLembur *= (jamKerja %= 40);
        int totalUpah = upah + upahLembur;

    //OUTPUT
    Console.WriteLine("---------------");
    Console.WriteLine($"Upah \t: {upah}");
    Console.WriteLine($"Lembur \t: {upahLembur}");
    Console.WriteLine($"Total \t: {totalUpah}");

}

//Nomer 2
static void SoalDua()
{
    Console.WriteLine("--Soal Nomer 2--");
    Console.WriteLine();

    //INPUT
    Console.Write("Masukan kalimat\t: ");
    string kalimat = Console.ReadLine();

    //PROSES
    string[] subs = kalimat.Split(' ');

    for (var i = 0; i < subs.Length; i++)
    {
        Console.WriteLine($"Kata {i + 1}: {subs[i]}");
    }

    //OUTPUT
    Console.WriteLine();
    Console.WriteLine($"Total kata adalah {subs.Length}");

}

//Nomer 3
static void SoalTiga()
{
    Console.WriteLine("--Soal Nomer 3--");
    Console.WriteLine();

    //INPUT
    Console.Write("Masukan kalimat: ");
    string kalimat = Console.ReadLine();

    //PROSES (Cara 1)
    kalimat = kalimat.Replace("a", "*").Replace("k", "*").Replace("y", "*").Replace("n", "*").Replace("m", "*");

    //PROSES (Cara 2)

    //OUTPUT
    Console.WriteLine(kalimat);

}

//Nomer 4
static void SoalEmpat()
{
    Console.WriteLine("--Soal Nomer 4--");
    Console.WriteLine();
    //INPUT
    Console.Write("Masukan kalimat: ");
    string kalimat = Console.ReadLine();

    //PROSES (Cara 1)
    //kalimat = kalimat.Replace("a", "*").Replace("k", "*").Replace("y", "*").Replace("n", "*").Replace("m", "*");

    //PROSES (Cara 2)
    string[] array = kalimat.Split(" ");

    foreach (string x in array)
    {
        Console.Write($"{x} ");

    }

    //OUTPUT
    //Console.WriteLine(kalimat);
}


//Nomer 5
static void SoalLima()
{
    Console.WriteLine("--Soal Nomer 5--");
    Console.WriteLine();

}

//Nomer 6
static void SoalEnam()
{
    Console.WriteLine("--Soal Nomer 6--");
    Console.WriteLine();
    Console.Write("Masukan angka: ");
    int angka = int.Parse(Console.ReadLine());

    int x = 1;

    for (int i = 0; i < angka; i++)
    {
        x *= 3;
        if (i % 2 == 1)
        {
            Console.Write($"* ");
        }
        else
        {
            Console.Write($"{x} ");
        }
    }

}

//Nomer 7
static void SoalTujuh()
{
    Console.WriteLine("--Soal Nomer 7--");
    Console.WriteLine();

    
    for (int i = 1; i < 10; i++)
    {
        if (i == 1 || i == 2)
        {
           Console.Write($"{i} ");
        }
        else
        {
            Console.Write($"{(i - 1) + (i - 2)} ");
        }
    }
}


//Nomer 8
static void SoalDelapan()
{
    Console.WriteLine("--Soal Nomer 8--");
    Console.WriteLine();
    Console.Write("Masukan angka: ");
    int angka = int.Parse(Console.ReadLine());

    for (int i = 0; i < angka; i++)
    {
        for (int j = angka; j > 0; j--)
        {
            if (i == 0 || i == angka - 1)
            {
                Console.Write($"{j} ");

            } else
            {
                Console.Write($"* ");
            }
        }
        Console.WriteLine();
        //belum selesai
    }

}
