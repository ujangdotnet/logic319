//Soal 1
//Satu();
//static void Satu()
//{
//    Console.Write("Masukan nilai n: ");
//    string nomer = Console.ReadLine();

//    string[] nomers = nomer.Split(',');
//    int[] n = Array.ConvertAll(nomers, s => int.Parse(s));
//    //int[] n = { 4, 1, 3 };
//    var result = "";
//    //var x = 0;
//    for (int i = 0; i < n.Length; i++)
//    {
//        for (int j = 0; j < n.Length; j++)
//        {
//            //cara-hard-core
//            //if (i == 0)
//            //{
//            //    Console.Write(n[i]);
//            //    break;
//            //}
//            //else if (i == 1)
//            //{
//            //    Console.Write($"{n[j]} + {n[j + 1]} = {n[j] + n[j + 1]}");
//            //    break;
//            //}
//            //else if (i == 2)
//            //{
//            //    Console.Write($"{n[j]} + {n[j + 1]} + {n[j + 2]} = {n[j] + n[j + 1] + n[j + 2]}");
//            //    break;
//            //}


//            //var x = n[i];
//            //var y = n[i + j];

//            //result = (i == 0) ? x : "+" + y;

//            //Console.Write(result);


//        }
//        Console.WriteLine();

//    }
//}




//}

//Dua();
//static void Dua()
//{
//    Console.Write("Masukan username: ");
//    string username = Console.ReadLine();
//    //5-10
//    //alfanumeric dan underscore
//    //string username = "aB12_";

//    string validasi = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ123456789_";

//    switch (username.Length)
//    {
//        case int x when x >= 5 && x <= 10:

//            if (username.Contains(validasi))
//            {
//                Console.Write("Username sudah sesuai");
//            }
//            else
//            {
//                Console.Write("Character belum pas");
//            }

//            break;

//        default:
//            Console.Write("Username dan character belum sesuai");
//            break;
//    }



//}


//tiga
//Tiga();

//static void Tiga()
//{
//    //INPUT
//    Console.Write("Masukan kalimat: ");
//    string kalimat = Console.ReadLine();
//    //Console.Write("Masukan nilai n: ");
//    //int n = int.Parse(Console.ReadLine());

//    //PROSES
//    string text = kalimat.Replace(" ","");
//    char[] textS = text.ToCharArray();

//    string[] kata = new string[textS.Length];

//    for (int i = 0; i < textS.Length; i++)
//    {
//        for (int j = 0; j < textS.Length; j++)
//        {
//        kata[i] = textS[i] + textS[i+j];
//        }
//    }

//    foreach (string c in kata) { 
//        Console.Write(c);
//    }

//    //var subsA = kalimat.Substring(0, n);
//    //var subsB = kalimat.Substring(kalimat.Length - n);

//    //OUTPUT
//    //Console.WriteLine(subsA);
//    //Console.Write(subsB);

//}

//Empat
//Empat();

//static void Empat()
//{
//    /*
//    dikethaui: n halaman, cover depan belakang, ganjil ada di kanan buku x lembar

//    Sebuah buku terdiri dari n halaman, terdapat masing" 1 lembar cover pada bagian depan dan belakang.
//    tiap halaman ganjil, selalu ada pada bagian kanan buku. tentukan pada ke berapa halaman x ke tersebut.
//    example n =10, x=5, output lembar ke 3
//    */

//    //INPUT
//    Console.Write("Masukan nilai n: ");
//    int n = int.Parse(Console.ReadLine());
//    Console.Write("Masukan nilai x: ");
//    int x = int.Parse(Console.ReadLine());


//    //PROSES

//    int lembar = 0;

//    for (int i = 0; i <= n-2; i++)
//    {
//        if (i % 2 == 0 && i < x)
//        {
//            lembar += 1;
//        }
//    }

//    //OUTPUT
//    Console.Write($"lembar ke {lembar}");
//}

//Lima

//using System.Runtime.Serialization;

//Lima();

//static void Lima()
//{
//    //INPUT

//    Console.Write("Masukan nilai n: ");
//    int n = int.Parse(Console.ReadLine());
//    Console.Write("Masukan nilai m: ");
//    int m = int.Parse(Console.ReadLine());

//    //int n = 1000;
//    //int m = 3;

//    //PROSES
//    Random random = new Random();

//    int x = random.Next(m, n);
//    //int xs = 0;

//    for (int i = 0; i <= m; i++)
//    {
//        if (i < m)
//        {
//            Console.WriteLine($"Calon no. urut {i + 1}: {x} suara ({x / 100d}%).");
//        }
//        else
//        {
//            Console.WriteLine($"Golput: {x} suara ({x / 100d}%).");

//        }
//        x = random.Next(m - i, n - x);
//    }

//    //int golput = n - xs;
//    //Console.WriteLine($"Golput: {xs} suara.");


//}

//enam

//Enam();

//static void Enam()
//{
//    //INPUT
//    Console.Write("Pilihan player A/B: ");
//    char player = char.Parse(Console.ReadLine().ToUpper());

//    int[] angka = { 3, 5, 4, 5, 8, 5, 3, 5, 3 };

//    //PROSES
//    //Random angkaRd = new Random();

//    //var angkaA = angkaRd.Next(1, 10);
//    //var angkaB = angkaRd.Next(1, 10);

//    int nilaiA = 0;
//    int nilaiB = 0;

//    int hitungA = 0;
//    int hitungB = 0;
//    string kalimat = "";

//    for (int i = 0; i < 3; i++)
//    {
//        Random angkaRd = new Random();

//        var angkaA = angkaRd.Next(1, 10);
//        var angkaB = angkaRd.Next(1, 10);

//        nilaiA = angka[angkaA];
//        nilaiB = angka[angkaB];

//        if (nilaiA > nilaiB)
//        {
//            hitungA++;

//        } if (nilaiA < nilaiB)
//        {
//            hitungB++;
//        }
//        nilaiA += nilaiA;
//        nilaiB += nilaiB;

//        Console.WriteLine($"Rounde ke {i+1}: A = {nilaiA}, B = {nilaiB}");
//    }

//    switch (player)
//    {
//        case 'A':
//            if (hitungA > hitungB)
//            {
//                kalimat = "Anda menang, B kalah.";
//            }
//            else
//            {
//                kalimat = "Anda kalah, B menang.";
//            }
//            break;
//        case 'B':
//            if (hitungA > hitungB)
//            {
//                kalimat = "Anda menang, A kalah.";
//            }
//            else
//            {
//                kalimat = "Anda kalah, A menang.";
//            }
//            break;
//    }


//    //OUTPUT
//    Console.WriteLine(kalimat);
//}

//Tujuh();

//static void Tujuh()
//{
//    //Console.Write("Masukan kata/ kalimat: ");
//    //string kalimat = Console.ReadLine();

//    string kalimat = "He is a very very good boy, isn't he?";

//    string[] karakter = { ",", "'" };

//    for (int i = 0; i < karakter.Length; i++)
//    {
//        if (kalimat.Contains(karakter[i]))
//        {
//            kalimat.Replace(karakter[i], "");
//        }

//        Console.WriteLine(kalimat);
//    }
//}

//Delapan();

//static void Delapan()
//{
//    //INPUT
//    //Console.Write("Masukan 3 angka (deret 1): ");
//    //int angka1 = int.Parse(Console.ReadLine());
//    //Console.Write("Masukan 3 angka (deret 2): ");
//    //int angka2 = int.Parse(Console.ReadLine());
//    //Console.Write("Masukan 3 angka (deret 3): ");
//    //int angka3 = int.Parse(Console.ReadLine());

//    Console.Write("Pola (x,+,-): ");
//    string pola = Console.ReadLine();
//    Console.Write("Action tambah(+)/kurang(-)/kali(x): ");
//    string action = Console.ReadLine();

//    int[,] angka = { { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 } };
//    //string pola = "x";
//    //string action = "+";

//    //var polaX = (angka[0,0]+ angka[1,1] + angka[2,2])+(angka[2,0]+ angka[1,1]+ angka[0,2]);
//    //var polaPlus = (angka[1, 0] + angka[1, 1] + angka[1, 2]) + (angka[0, 1] + angka[1, 1] + angka[2, 1]);
//    //var polaDatar = angka[1, 0] + angka[1, 1] + angka[1, 2];

//    var result = 0;
//    for (int i = 0; i < angka.GetLength(0); i++)
//    {
//        for (int j = 0; j < angka.GetLength(1); j++)
//        {
//            switch (pola)
//            {
//                case "-":
//                    if (action == "+")
//                    {
//                        result = angka[1, 0] + angka[1, 1] + angka[1, 2];
//                    }
//                    if (action == "-")
//                    {
//                        result = angka[1, 0] - angka[1, 1] - angka[1, 2];
//                    }
//                    if (action == "x")
//                    {
//                        result = angka[1, 0] * angka[1, 1] * angka[1, 2];
//                    }
//                    break;
//                case "+":
//                    if (action == "+")
//                    {
//                        result = (angka[1, 0] + angka[1, 1] + angka[1, 2]) + (angka[0, 1] + angka[1, 1] + angka[2, 1]);
//                    }
//                    if (action == "-")
//                    {
//                        result = (angka[1, 0] + angka[1, 1] + angka[1, 2]) - (angka[0, 1] + angka[1, 1] + angka[2, 1]);
//                    }
//                    if (action == "x")
//                    {
//                        result = (angka[1, 0] + angka[1, 1] + angka[1, 2]) * (angka[0, 1] + angka[1, 1] + angka[2, 1]);
//                    }
//                    break;
//                case "x":
//                    if (action == "+")
//                    {
//                        result = (angka[0, 0] + angka[1, 1] + angka[2, 2]) + (angka[2, 0] + angka[1, 1] + angka[0, 2]);
//                    }
//                    if (action == "-")
//                    {
//                        result = (angka[0, 0] + angka[1, 1] + angka[2, 2]) - (angka[2, 0] + angka[1, 1] + angka[0, 2]);
//                    }
//                    if (action == "x")
//                    {
//                        result = (angka[0, 0] + angka[1, 1] + angka[2, 2]) * (angka[2, 0] + angka[1, 1] + angka[0, 2]);
//                    }
//                    break;
//            }
//        }
//    }

//    Console.Write(result);
//}






//Sembilan();

//static void Sembilan()
//{
//    Console.Write("Kang (n): ");
//    int n = int.Parse(Console.ReadLine());
//    Console.Write("Uru (m): ");
//    int m = int.Parse(Console.ReadLine());
//    Console.Write("Jarak (x): ");
//    int x = int.Parse(Console.ReadLine());

//    //int n = 4, m = 2, x = 3;

//    int kang = 0;
//    int uru = 0;

//    for (int i = 0; i < x * n * m; i++)
//    {
//        kang += n;
//        uru += m;
//        //Console.Write($"{kang},");
//        //Console.Write($"{uru},");
//        if (kang == uru)
//        {
//            Console.WriteLine("Gooks");
//            break;
//        }
//        else
//        {
//            Console.Write($"{kang},");
//            Console.Write($"{uru},");
//        }

//        //uru += m;

//        //if (kang == uru)
//        //{
//        //    Console.Write($"Kedua Kanguru berhenti di titik {kang} meter");
//        //}
//        //else
//        //{
//        //    Console.Write($"Kedua Kanguru masuk kedalam lubang");
//        //}
//    }
//    //Console.WriteLine(kang);

//}

Sepuluh();

static void Sepuluh()
{
    Console.Write("Masukan kalimat: ");
    string kalimat = Console.ReadLine().ToLower();

    //string kalimat = "Apa Kabar Kalian Semua ?".ToLower();

    string[] kata = kalimat.Split(' ');
    char[] perKata = Array.ConvertAll(kata, s => char.Parse(s));

    //char[] perKata = kalimat.ToCharArray();

    int x = 0;
    int y = 0;

    for (int i = 0; i < kata.Length; i++)
    {

        for (int j = 0; j < kata[i].Length; j++)
        {
            switch (kata[i][j])
            {
                case 'a':
                case 'i':
                case 'u':
                case 'e':
                case 'o':
                    x += 1;
                    break;
                    //default:
                    //    y += 1;
                    //    break;
            }
            //Console.Write($"{kata[i][j]},");
        }
        //Console.Write($"{kata[0]}");
        //Console.WriteLine();
    }

    Console.WriteLine(x - y);
}