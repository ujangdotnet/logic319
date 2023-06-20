//latihan

//BilanganPrima();
CamelCaseLetter();
static void BilanganPrima()
{
    Console.Write("Masukan nilai n: ");
    int n = int.Parse(Console.ReadLine());

    string result = "";

    for (int i = 2; i <= n; i++)
    {
        if (i == 2 || i == 3 || i == 5 || i == 7)
        {
            Console.Write("{0},", i);

        }
        if (i % 2 == 0 || i % 3 == 0 || i % 5 == 0 || i % 7 == 0)
        {
            continue;
        }

        //Console.Write("{0},", i);
        result += result == "" ? i : ", " + i;
    }


    //for (int i = 2; i <= n;i++)
    //{
    //    int x = 0;
    //    for (int j = 2; j <= n; j++)
    //    {

    //        if (i % j == 0) {
    //            x++;
    //        }
    //    }

    //    if (x == 1)
    //    {

    //        Console.Write($"{i},");
    //    }

    //}
    //bool isPrima = false;

    //for (int i = 2; i <= n; i++)
    //{
    //    bool isPrima = false;
    //    for (int j = 2; j <= i; j++)
    //    {

    //        if (i % j == 0)
    //        {
    //            isPrima = true;
    //            //break;
    //        }
    //    }

    //    if(isPrima == true)
    //    {

    //    Console.Write($"{i},");
    //    }

    //}
}

//camel case

static void CamelCaseLetter()
{
    string kata = "oneTwoThree";

    char[] kataS = kata.ToCharArray();

    int hitung = 0;

    for(int i = 0; i < kataS.Length; i++)
    {
        if (i == 0 || Char.IsUpper(kataS[i]))
        {
            hitung++; 
        }
    }

    Console.WriteLine(hitung);

    //foreach (char c in kataS)
    //{
    //    Console.Write($"{c},");
    //}
}

//strong 


