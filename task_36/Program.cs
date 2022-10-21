int[] CreatArray()
{
    Console.WriteLine("Ведите размер массива: ");
    int N = int.Parse(Console.ReadLine());
    Console.WriteLine("Ведите минимальное значение числа массива: ");
    int min = int.Parse(Console.ReadLine());
    Console.WriteLine("Ведите максимальное значение числа массива: ");
    int max = int.Parse(Console.ReadLine());
    Random rnd = new Random();
    if (N > 0)
    {
        int[] array = new int[N];
        for (int i = 0; i < N; i++)
        {
            array[i] = rnd.Next(min, max);

        }
        return array;
    }
    else
    {
        int[] array = new int[1];
        Console.WriteLine("Ошибка");
        return array;
    }
}

void OddNambersPosition(int[] a)
{
    int sum = 0;
    for (int i = 1; i < a.Length; i += 2)
    {
        sum = sum + a[i];
    }
    Console.WriteLine("сумма элементов стоящих на нечетных позициях равна: " + sum);
}
int[] myArray = CreatArray();
Console.WriteLine(string.Join(", ", myArray));
OddNambersPosition(myArray);