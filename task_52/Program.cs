using System.Collections.ObjectModel;
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
// (Округление до 2х знаков - Math.Round(value, 2))


int n = IsCreatValue("Введите число строк: ");
int m = IsCreatValue("Введите число столбцов: ");
int[,] myArray = CreatArray(n, m, 1, 10);
double[] otvet = CalculatArithmeticMean(myArray);
PrintArray(myArray);
Console.WriteLine($"Среднее арифметическое каждого столбца: {string.Join("; ", otvet)}");


int IsCreatValue(string message)
{
    Console.WriteLine(message);
    int value = int.Parse(Console.ReadLine());
    return value;
}

int[,] CreatArray(int n, int m, int min, int max)
{
    int[,] outArray = new int[n, m];
    Random rnd = new Random();
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            outArray[i, j] = rnd.Next(min, max);
        }
    }
    return outArray;
}

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine("");
    }

}

double[] CalculatArithmeticMean(int[,] array)
{

    double[] outArray = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int sum = array[0, j];
        for (int i = 1; i < array.GetLength(0); i++)
        {
            sum = sum + array[i, j];
        }
        outArray[j] = Math.Round((double)sum / array.GetLength(0), 2);
    }
    return outArray;
}
