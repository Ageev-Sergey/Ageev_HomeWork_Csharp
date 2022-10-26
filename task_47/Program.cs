// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.Clear();

int n = Value("введите количество строк n:");
int m = Value("введите количество столбцов m:");
double[,] myArray = CreatArray(n, m, 50, 100);
PrintArray(myArray);



int Value(string message)
{
    Console.WriteLine(message);
    int a = int.Parse(Console.ReadLine());
    return a;
}

double[,] CreatArray(int n, int b, double min, double max)
{
    double[,] outArray = new double[n, m];
    Random rnd = new Random();
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            outArray[i, j] = min + rnd.NextDouble() * (max-min);
            outArray[i, j] = Math.Round(outArray[i, j], 2);
        }
    }
    return outArray;
}

void PrintArray(double[,] array)
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