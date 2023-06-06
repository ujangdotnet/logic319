//Kuis 04

try
{
    SoalDelapan();

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
    up:
    Console.Write("Masukan kalimat\t: ");
    string kalimat = Console.ReadLine();

    if (kalimat == string.Empty)
    {
        Console.Write("Kalimat tidak boleh kosong!");
        goto up;
    }

    //PROSES
    string[] subs = kalimat.Split(' ');

    for (int i = 0; i < subs.Length; i++)
    {
        //Ouput
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
    //kalimat = kalimat.Replace("a", "*").Replace("k", "*").Replace("y", "*").Replace("n", "*").Replace("m", "*");
    //Console.WriteLine(kalimat);

    //PROSES (Cara 2)
    string[] array = kalimat.Split();

    foreach (string x in array)
    {
        for (int i = 0; i < x.Length; i++)
        {
            if (i == 0 || i == x.Length - 1)
            {
                Console.Write(x[i]);
            }
            else
            {
                Console.Write("*");
            }
        }
        Console.Write(" ");
    }

    

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
    string[] array = kalimat.Split();

    foreach (string x in array)
    {
        for (int i = 0; i < x.Length; i++)
        {
            if (i == 0 || i == x.Length - 1)
            {
                Console.Write("*");
            }
            else
            {
                Console.Write(x[i]);
            }
        }
        Console.Write(" ");
    }

}


//Nomer 5
static void SoalLima()
{
    Console.WriteLine("--Soal Nomer 5--");
    Console.WriteLine();

    //INPUT
    Console.Write("Masukan kalimat: ");
    string kalimat = Console.ReadLine();

    //Cara 1
    // kalimat = kalimat.ToLower();
    // kalimat = kalimat.Remove(0,1).Remove(4,1).Remove(9,1);

    // Console.WriteLine(kalimat);

    //Cara 2 
    string[] array = kalimat.Split();

    foreach (string x in array)
    {
        for (int i = 0; i < x.Length; i++)
        {
            if (i == 0)
            {
                Console.Write("");
            }
            else
            {
                Console.Write(x[i]);
            }
        }
        Console.Write(" ");
    }

}

//Nomer 6
static void SoalEnam()
{
    Console.WriteLine("--Soal Nomer 6--");
    Console.WriteLine();

    //INPUT
    Console.Write("Masukan angka: ");
    int angka = int.Parse(Console.ReadLine());

    //PROSES
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

    Console.Write("Masukan angka: ");
    int angka = int.Parse(Console.ReadLine());

    //inisiasi variabel
    int x = 0; //nilai output
    int x1 = 0; //nilai sebelumnya
    int x2 = 1; //nilai sekarang

    for (int i = 0; i < angka; i++)
    {
        x = x1 + x2;
        x2 = x1;
        x1 = x;
        Console.Write($"{x}, ");
    }
    //coba debug
}


//Nomer 8
static void SoalDelapan()
{
    Console.WriteLine("--Soal Nomer 8--");
    Console.WriteLine();

    //INPUT
    Console.Write("Masukan angka: ");
    int angka = int.Parse(Console.ReadLine());

    //PROSES
    var x = angka;
    for (int i = 0; i < angka; i++)
    {
        for (int j = 0; j < angka; j++)
        {
            if (i == 0)
            {
                //OUTPUT
                Console.Write($"{j + 1} ");

            }
            else if (i == angka - 1)
            {
                //OUTPUT
                Console.Write($"{x} ");
                x -= 1;
            }
            else if (j == 0 || j == angka - 1)
            {
                //OUTPUT
                Console.Write($"* ");

            }
            else
            {
                //OUTPUT
                Console.Write($"  ");
            }
        }
        Console.WriteLine();

    }

}
