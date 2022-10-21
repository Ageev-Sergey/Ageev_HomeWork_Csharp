int[] CreatArray()
{
    Console.WriteLine("Ведите размер массива: ");
    int N = int.Parse(Console.ReadLine());
    Console.WriteLine("Ведите минимальное значение числа массива: ");
    int min = int.Parse(Console.ReadLine());
    Console.WriteLine("Ведите максимальное значение числа массива: ");
    int max = int.Parse(Console.ReadLine());
    Random rnd = new Random();
    // int[] array = new int[N];
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

void evenNambers(int[] a)
{
    int sum = 0;
    for (int i = 0; i < a.Length; i++)
    {
        if (a[i] % 2 == 0 && a[i] != 0) sum++;

    }
    Console.WriteLine("колличество четных чисел = " + sum);
}


int[] myArray = CreatArray();
evenNambers(myArray);
Console.WriteLine(string.Join(", ", myArray));