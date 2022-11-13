// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();

int n = Value("введите количество строк n:");
int m = Value("введите количество столбцов m:");
int min = Value("введите минимально значение:");
int max = Value("введите максимальное значение:");
int[,] myArray = CreatArray(n, m, min, max);
PrintArray(myArray);
FindMinSumRow(myArray);


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

void FindMinSumRow(int[,] array)
{
    int minSum = max * array.GetLength(0);
    int row = 0;
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
        Console.WriteLine($"Строка {i}, со значение {sum}");
        Console.WriteLine();
        if (minSum > sum)
        {
            minSum = sum;
            row = i;
        }
        sum = 0;
    }
    Console.WriteLine($"Строка с минимальной суммой элементов {row}, со значение {minSum}");
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
        Console.WriteLine("");
    }

}
