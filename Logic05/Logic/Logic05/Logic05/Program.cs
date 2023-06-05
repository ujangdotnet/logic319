//LOGIC 5

try
{
    Rekursif();

} catch(Exception e)
{   
    Console.WriteLine("----------");
    Console.WriteLine(e.Message);
    Console.WriteLine("----------");
}

static void PadLeft()
{
    Console.WriteLine("-- Padleft --");
    Console.WriteLine();
    Console.Write("Masukan input: ");
    int input = int.Parse(Console.ReadLine());
    Console.Write("Masukan panjang karakter: ");
    int panjang = int.Parse(Console.ReadLine());
    Console.Write("Masukan char: ");
    char chars = char.Parse(Console.ReadLine());

    DateTime date = DateTime.Now;

    string code = "";

    code = date.ToString("yy") + date.ToString("MM") + input.ToString().PadLeft(panjang, chars);

    Console.WriteLine($"Hasil padleft: {code}");
}

static void Rekursif()
{
    Console.WriteLine("-- Rekursif Function (DESC) --");
    Console.WriteLine();
    Console.Write("Masukan input: ");
    int input = int.Parse(Console.ReadLine());

    Perulangan(input);
}

static int Perulangan(int x)
{
    if (x == 1)
    {
        Console.WriteLine(x);
        return x;
    }

    Console.WriteLine(x);
    return Perulangan(x -1);
}