//Kuis 04

SoalEnam();


//Nomer 1
static void SoalSatu()
{
    Console.WriteLine("--Soal Nomer 1--");
    Console.WriteLine();

}

//Nomer 2
static void SoalDua()
{
    Console.WriteLine("--Soal Nomer 1--");
    Console.WriteLine();
    Console.Write("Masukan kalimat\t:");
    string kalimat = Console.ReadLine();

    string[] subs = kalimat.Split(' ');

    for ( var i = 0; i < subs.Length; i++)
    {
        Console.WriteLine($"Kata {i+1}: {subs[i]}");
    }

}

//Nomer 3
static void SoalTiga()
{
    Console.WriteLine("--Soal Nomer 1--");
    Console.WriteLine();

}

//Nomer 4
static void SoalEmpat()
{
    Console.WriteLine("--Soal Nomer 1--");
    Console.WriteLine();

}

//Nomer 5
static void SoalLima()
{
    Console.WriteLine("--Soal Nomer 1--");
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
