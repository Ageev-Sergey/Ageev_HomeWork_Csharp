// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


Console.Clear();

int n = Value("введите количество строк n:");
int m = Value("введите количество столбцов m:");

int[,] myArray = CreatArray(n, m, 10, 100);
PrintArray(myArray);
Console.WriteLine();
IsSortedArray(myArray);
PrintArray(myArray);


int Value(string message)
{
    Console.WriteLine(message);
    int a = int.Parse(Console.ReadLine());
    if (a > 0) return a;
    else
    {
        Console.WriteLine("ошибка. число должны быть больше 0, присвоено значение 1");
        return a = 1;

    }
}

int[,] CreatArray(int n, int b, int min, int max)
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

int[,] IsSortedArray(int[,] array)
{
    int[] rowArray = new int[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            rowArray[j] = array[i, j];
        }
        Array.Sort(rowArray);
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rowArray[j];
        }
    }
    return array;
}

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}    ");
        }
        Console.WriteLine("");
    }

}
