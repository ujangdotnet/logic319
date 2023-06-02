//Hari ke 4

using logic04;

PanggilClassStudent();

//Initialize Array
static void InitializeArray()
{
    //Cara 1
    int[] array = new int[5];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Masukan nilai ke {i +1}:");
        array[i] = int.Parse(Console.ReadLine());
    }

    //Cara 2
    int[] array2 = new int[5] { 1, 2, 3, 4, 5 };

    //Cara 3
    int[] array3 = new int[] { 1, 2 };

    //Cara 4
    int[] array4 = {1,2,3,};

    //Cara 5
    int[] array5;
    array5 = new int[3] { 1, 2, 3 };

    Console.WriteLine(string.Join(" , ", array));
    Console.WriteLine(string.Join(" , ",array2));
    Console.WriteLine(string.Join(" , ",array3));
    Console.WriteLine(string.Join(" , ",array4));
    Console.WriteLine(string.Join(" , ",array5));

}

//Arrays 2D
static void Array2Dimensi()
{
    int[,] array = new int[3, 3]
    {
        {1,2,3 },
        {4,5,6 },
        {7,8,9 }
    };

    for (int i = 0; i < array.GetLength(0);i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.WriteLine(array[i,j]);
        }
        Console.WriteLine();
    }
}

//List Collection
static void ListCollection()
{
    List<string> list = new List<string>()
    {
        "John Doe",
        "John Ree",
        "John Mie"
    };
    list.Add("John Fae");

    Console.WriteLine(string.Join(", ", list));
}

//List Collection - Call Class

static void PanggilClassStudent()
{
    List<Student> students = new List<Student>()
    {
        new Student(){Id = 1, Name = "John Doe"},
        new Student(){Id = 2, Name = "John Ree"},
        new Student(){Id = 3, Name = "John Mie"},
    };

    Console.WriteLine($"Panjang data list student = {students.Count}");
    foreach (Student student in students)
    {
        Console.WriteLine($"Id: {student.Id}");
        Console.WriteLine($"Nama: {student.Name}");
    }
}

//Datetime

static void BelajarWaktu()
{
    Console.WriteLine("--Datetime--");
}