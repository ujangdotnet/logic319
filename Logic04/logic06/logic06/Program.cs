//LOGIC Hari ke 6

using logic06;

try
{
    ClassMobil();

} catch (Exception e)
{
    Console.WriteLine("---------------");
    Console.WriteLine(e.Message);
    Console.WriteLine("---------------");
}



//Mobil
static void ClassMobil()
{
    Mobil mobil = new Mobil() { nama = "Chevrolet", kecepatan = 0, bensin = 10, posisi = 0 };
    mobil.platno = "B 2345 XSIS";
    mobil.Utama();

    mobil.Percepat();
    mobil.Maju();
    mobil.IsiBensin(mobil.bensin); 

}

static void AbstractClass()
{
    Console.WriteLine("--Abstract Class--");
    Console.WriteLine();
    Console.Write("Masukan nilai x\t:");
    int x = int.Parse(Console.ReadLine());
    Console.Write("Masukan nilai y\t:");
    int y = int.Parse(Console.ReadLine());

    TestTurunan calc = new TestTurunan();
    int jumlah = calc.jumlah(x, y);
    int kurang = calc.kurang(x, y);

    Console.WriteLine($"Hasil dari {x} + {y} adalah {jumlah}");
    Console.WriteLine($"Hasil dari {x} - {y} adalah {kurang}");


}