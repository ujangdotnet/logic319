// Logic Hari ke 3

//PerulanganWhile();
//PerulanganWhileDua();
//PerulanganDoWhile();
//PerulanganFor();
//PerulanganForDua();
//PerulanganBersarang();
//PerulanganBersarangDua();
//BelajarStrings();
//StringsInsert();
ConvertAll();



// While

static void PerulanganWhile()
{
    Console.WriteLine("--Perulangan While--");
    Console.WriteLine();
    Console.Write("Masukan nilai: ");
    int nilai = int.Parse(Console.ReadLine());

    while (nilai < 6)
    {
        Console.WriteLine(nilai);
        nilai++;
    }
}

static void PerulanganWhileDua()
{
    bool ulangi = true;

    Console.WriteLine("--Perulangan While--");
    Console.WriteLine();
    Console.Write("Masukan nilai: ");
    int nilai = int.Parse(Console.ReadLine());

    while (ulangi)
    {
        Console.WriteLine($"Proses ke {nilai}");
        nilai++;

        Console.Write("Ulangi proses ? (y / n): ");
        string input = Console.ReadLine();

        if (input.ToLower() == "n")
        {
            ulangi = false;
            Console.WriteLine();
            Console.WriteLine("Proses Berakhir!");
        }
    }

}

// Do While

static void PerulanganDoWhile()
{
    Console.WriteLine("--Perulangan Do While--");
    Console.WriteLine();
    Console.Write("Masukan nilai: ");
    int nilai = int.Parse(Console.ReadLine());

    do
    {
        Console.WriteLine(nilai);
        nilai++;
    } while (nilai < 6);
}

// For

static void PerulanganFor()
{   
    Console.WriteLine("--Perulangan For--");
    Console.WriteLine();
    //Console.Write("Masukan nilai: ");
    //int nilai = int.Parse(Console.ReadLine());

    for (int i = 0; i < 6; i++)
    {
        Console.WriteLine(i);
    }
    
    Console.WriteLine();

    for (int i = 6; i > 0; i--)
    {
        Console.WriteLine(i);
    }
}

static void PerulanganForDua()
{
    for (int i = 0; i < 10; i++)
    {
        if (i == 7)
        {
            continue;
        }
        Console.WriteLine(i);
    }
}

// Nested Loops

static void PerulanganBersarang()
{
    for (int i = 0; i < 3; i++) //iterasi baris
    {
        for (int j = 0; j < 3; j++) //iterasi kolom
        {
            Console.Write($"({i},{j})");
        }
        Console.Write("\n");
    }
}

static void PerulanganBersarangDua()
{
    for (int i = 0;i < 3;i++)
    {
        for (int j = 0; j < 3; j++)
        {
            Console.Write($"{i},{j} ");
        }
        Console.Write("\n");
    }
}

// Foreach

static void Foreach()
{
    int[] array = { 1, 2, 3, 4, 5, 6, };

    foreach (int i in array)
    {
        Console.WriteLine(i);
    }

    Console.WriteLine();

    for (int i =0; i<array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}

// Strings

static void BelajarStrings() 
{
    Console.WriteLine("--Strings Length--"); // length
    Console.WriteLine();
    Console.Write("Masukan kata-kata: ");
    string kata = Console.ReadLine();
    
    Console.WriteLine($"Kata '{kata}' memiliki panjang karakter = {kata.Length}.");
}

static void BelajarStringsDua()
{
    Console.WriteLine("--Strings Remove--"); 
    Console.WriteLine();
    Console.Write("Masukan kata-kata: ");
    string kata = Console.ReadLine();
    Console.Write("Masukan index remove: ");
    int index = int.Parse(Console.ReadLine());

    Console.WriteLine($"{kata.Remove(index)}"); // Remove
}

static void BelajarStringsTiga()
{
    Console.WriteLine("--Strings Insert--");
    Console.WriteLine();
    Console.Write("Masukan kata-kata: ");
    string kata = Console.ReadLine();
    Console.Write("Masukan index insert: ");
    int index = int.Parse(Console.ReadLine());
    Console.Write("Masukan nilai insert: ");
    string insertKata = Console.ReadLine();

    Console.WriteLine($"{kata.Insert(index, insertKata)}"); // Insert
}

static void StringsInsert()
{
    Console.WriteLine("--Strings Insert--");
    Console.WriteLine();
    Console.Write("Masukan kata-kata: ");
    string kata = Console.ReadLine();
    Console.Write("Masukan kata yang akan di ubah: ");
    string kataLama = Console.ReadLine();
    Console.Write("Masukan kata yang baru: ");
    string kataBaru = Console.ReadLine();

    Console.WriteLine($"{kata.Replace(kataLama, kataBaru)}");
}

// Contain String

static void ContainString()
{
    Console.WriteLine("--Contain Strings--");
    Console.WriteLine();
    Console.Write("Masukan kata: ");
    string kata = Console.ReadLine();
    Console.Write("Masukan contain: ");
    string contain = Console.ReadLine();

    if (kata.Contains(contain))
    {
        Console.WriteLine($"Kata {kata} mengandung {contain}");
    }else
    {
        Console.WriteLine($"Kata {kata} tidak mengandung {contain}");
    }
}

// Split and Join

static void SplitAndJoin()
{
    Console.WriteLine("--Split & Join--");
    Console.WriteLine();
    Console.Write("Masukan kalimat: ");
    string kalimat = Console.ReadLine();
    Console.Write("Masukan split: ");
    string split = Console.ReadLine();

    string[] kataKata = kalimat.Split(split);

    foreach (String kata in kataKata)
    {
        Console.WriteLine(kata);
    }

    Console.WriteLine(string.Join("+", kataKata));
}

// Substring


// Convert String

static void ConvString()
{
    Console.WriteLine("--String ToCharArray--");
    Console.WriteLine();
    Console.Write("Masukan kalimat: ");
    string kalimat = Console.ReadLine();

    char[] array = kalimat.ToCharArray();

    foreach(char x in array)
    {
        Console.WriteLine(x);
    }

    Console.WriteLine();

    for(int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
    
}

// Convert All

static void ConvertAll()
{
    Console.WriteLine("--Convert All--");
    Console.Write("Masukan input angka pakai spasi: ");
    string[] input = Console.ReadLine().Split(" ");

    int sum = 0;

    int[] array = Array.ConvertAll(input, Convert.ToInt32);

    foreach (int x in array)
    {
        sum += x;
    }

    Console.WriteLine($"Jumlah = {sum}");
}