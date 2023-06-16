//Review Logic
using System;

try
{
    //Satu();
    Dua();

    Console.ReadKey();
} catch (Exception e)
{
    Console.WriteLine(e.Message);
}


//Soal nomer 1
static void Satu()
{
    //input
    Console.Write("Start: ");
    int start = int.Parse(Console.ReadLine());
    Console.Write("End: ");
    int end = int.Parse(Console.ReadLine());

    string kode = "XA";
    var tgls = DateTime.Now.ToString("ddMMyyyy");
    int batas = end - start;

    Console.WriteLine("----------------");
    for (int i = 0; i <= batas; i++)
    {
        string x = start.ToString();
        Console.WriteLine($"{kode}-{tgls}-{x.PadLeft(5,'0')}");
        start++;
    }

}


//Soal nomer 2
static void Dua()
{
    Console.WriteLine("Masukan bilangan bulat (Pisahkan dengan koma dan spasi)\ncontoh: '153, 3'");
    Console.WriteLine("-------------------------");
    string input = Console.ReadLine();

    int[] newArray = Array.ConvertAll(input.Split(", "), int.Parse);

    //int[] angkaLeft = new int[];
    //ganti type data
    //char[] chars = Array.ConvertAll(newArray, s => char.Parse(s.ToString()));

    //foreach (int i in chars)
    //{
    //    Console.Write($"{i},");
    //}
    //char[] chars = inputSS.ToCharArray();
    //int[] ints = Array.ConvertAll(chars, s => int.Parse(s.ToString()));

    //proses algorithma
    //int batas = newArray[newArray.Length - 1];
    //int x = 0;

    //for (int i = 0; i < batas; i++)
    //{
    //    x += newArray[i]*batas;
    //}

    //Console.WriteLine(x);


    //ganti type data utk proses ke 2
    //string y = x.ToString();
    //char[] z = y.ToCharArray();
    //int[] angka = Array.ConvertAll(z, s => int.Parse(s.ToString()));

    //int hasil = 0;

    //foreach (int inputItem in angka)
    //{
    //    hasil += inputItem;
    //}

    //Console.WriteLine("------------------------");
    //Console.Write($"Angka output {hasil}");

}