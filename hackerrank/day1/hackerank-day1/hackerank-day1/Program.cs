
//PlusMinus();
//MinMaxSum();
//CakeCandles();
DiagonalDifference();

//Plus Minus
static void PlusMinus()
{
    List<int> arr = new List<int>() {-4,3,-9,0,4,1};
    decimal positifNum = 0;
    float nolNum = 0;
    float negatifNum = 0;

    for (int i = 0; i < arr.Count; i++)
    {
        if (arr[i] >= -100 && arr[i] < 0)
        {
            negatifNum++;
            
        }else if (arr[i] == 0)
        {
            nolNum++;
            
        } else if (arr[i] <= 100 && arr[i] > 0)
        {
            positifNum++;
            
        }
    }

    Console.WriteLine(Math.Round(positifNum/arr.Count, 6));
    Console.WriteLine(nolNum/arr.Count);
    Console.WriteLine(negatifNum/arr.Count);
}

//Mini-Max Sum
static void MinMaxSum()
{
    //List<int> arr = new List<int>() {7,69,2,221,8974};
    List<int> arr = new List<int>() {256741038, 623958417, 467905213, 714532089, 938071625};
    arr.Sort();

    long minSum = 0;
    long maxSum = 0;

    for(int i = 0; i < arr.Count; i++)
    {
        if (i < arr.Count - 1)
        {
            minSum += arr[i];
        }
        if (i > 0)
        {
            maxSum += arr[i];
        }
    }

    Console.WriteLine(minSum);
    Console.WriteLine(maxSum);
}

//Birthday Cake Candles
static void CakeCandles()
{
    List<int> arr = new List<int>() { 99, 99, 99, 99};

    int candles = 0;

    for (int i = 0; i < arr.Count; i++)
    {
        if(arr[i] == arr.Max())
        {
            candles++;
        }
    }

    Console.WriteLine(candles);
}

//Diagonal Difference
static void DiagonalDifference()
{
    //Array
    int[,] arr =
    {
        {1,2,3 },
        {4,5,6},
        {7,8,9 }
    };

    int diagonalSatu = 0;
    int diagonalDua = 0;

    for (int i = 0; i < arr.GetLength(0); i++)
    {

        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i == j)
            {
                diagonalSatu += arr[i,j];
            }

            if (i == arr.GetLength(1) - 1 - i)
            {
                diagonalDua += arr[i, arr.GetLength(1) - 1 - i];
            }

        }
    }

    Console.WriteLine(diagonalSatu);
    Console.WriteLine(diagonalDua);

    //List
    int[,] angka = { { 1, 2, 3 }, { 4,5, 6 }, { 7,8, 9 } };

}