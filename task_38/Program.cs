﻿int[] CreatArray()
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

void DifferenceOfMinMaxArray(int[] a)
{
    int minValue = a[0];
    int maxValue = a[0];

    for (int i = 1; i < a.Length; i++)
    {
        if (minValue > a[i]) minValue = a[i];
        if (maxValue < a[i]) maxValue = a[i];
    }
    int result = maxValue - minValue;
    Console.WriteLine("Разница между максимальным и минимальным элементов массива = " + result);
}


int[] myArray = CreatArray();
Console.WriteLine(string.Join(", ", myArray));
DifferenceOfMinMaxArray(myArray);