// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int[,] firstMatrix = CreatArray(2, 3, 1, 10);
int[,] secondMatrix = CreatArray(3, 2, 1, 10);

PrintArray(firstMatrix);
Console.WriteLine();
PrintArray(secondMatrix);
Console.WriteLine();
try
{
    int[,] newMatrix = IsMultMatrix(firstMatrix, secondMatrix);
    PrintArray(newMatrix);
}
catch
{
    Console.WriteLine("Ошибка! количество столбцов первой матрица не равно количеству строк во второй матрици");
    Console.WriteLine();
    throw;
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
            Console.Write($"{array[i, j]}    ");
        }
        Console.WriteLine("");
        Console.WriteLine("");
    }

}

int[,] IsMultMatrix(int[,] first, int[,] second)
{
    int[,] resultMatrix = new int[first.GetLength(0), second.GetLength(1)];

    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            resultMatrix[i, j] = ElementMultMatrix(i, j);
        }
    }
    return resultMatrix;
}

int ElementMultMatrix(int i, int j)
{
    int[] rowFirstMatrix = new int[firstMatrix.GetLength(1)];

    for (int k = 0; k < rowFirstMatrix.Length; k++)
    {
        rowFirstMatrix[k] = firstMatrix[i, k];
    }
    Console.WriteLine(string.Join(", ", rowFirstMatrix));


    int[] colSecondMatrix = new int[secondMatrix.GetLength(0)];

    for (int k = 0; k < rowFirstMatrix.Length; k++)
    {
        colSecondMatrix[k] = secondMatrix[k, j];
    }
    Console.WriteLine(string.Join(", ", colSecondMatrix));

    int elementMatrix = 0;
    for (int k = 0; k < rowFirstMatrix.Length; k++)
    {
        int mult = rowFirstMatrix[k] * colSecondMatrix[k];
        elementMatrix = elementMatrix + mult;
    }
    Console.WriteLine($"значение элемента матрици = {elementMatrix}");
    Console.WriteLine();
    return elementMatrix;
}
