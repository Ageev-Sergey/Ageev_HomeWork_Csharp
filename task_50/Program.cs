// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1 7 -> такого числа в массиве нет
// (row ,colum - входные данные)



int n = Value();
int m = Value();
Console.WriteLine($"число строк = {n}, число стобцов = {m}");
int[,] myArray = CreatArray(n, m, -9, 10);
PrintArray(myArray);
int[] position = CreatPosition("Введите номер строки и столбца:");
SearchePosition(myArray, position);

// Лишнее, ищет число в массиве
// int checkValue = IsValue();
// SearchValue(myArray, checkValue);


int Value()
{
    Random rndm = new Random();
    int a = rndm.Next(3, 10);
    return a;
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

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 0)
                Console.Write($"{array[i, j]}    ");       // что бы не плыли столбци добавил
            else Console.Write($" {array[i, j]}    "); //  пробел для положительных числе
        }
        Console.WriteLine("");
        Console.WriteLine("");
    }

}


/*
int IsValue()
{
    Console.WriteLine("Введите число которой хотите найти:");
    int outNumbar = int.Parse(Console.ReadLine());
    return outNumbar;
}

void SearchValue(int[,] arr, int check)
{
    int sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (check == arr[i, j])
            {
                Console.Write($"Число найдено на {i} сторе, {j} столбце");
                sum++;
            }
        }
    }
    if (sum == 0) Console.WriteLine("число не найдено");
}
 */

int[] CreatPosition(string message)
{
    Console.WriteLine(message);
    string checkStr = Console.ReadLine();
    char[] separators = new char[] { ' ', ',' };
    string[] checkMass = checkStr.Split(separators, StringSplitOptions.RemoveEmptyEntries);
    int[] checkInt = new int[2];
    checkInt[0] = int.Parse(checkMass[0]);
    checkInt[1] = int.Parse(checkMass[1]);
    return checkInt;
}

void SearchePosition(int[,] allPositions, int[] thisPosition)
{
    if (thisPosition[0] < allPositions.GetLength(0)
        && thisPosition[1] < allPositions.GetLength(1)
    )
    {
        Console.Write($"на строке {thisPosition[0]}, столбце {thisPosition[1]} ");
        Console.Write($"находится число {myArray[thisPosition[0], thisPosition[1]]}");
    }
    else Console.WriteLine("такого числа в массиве нет");
}
