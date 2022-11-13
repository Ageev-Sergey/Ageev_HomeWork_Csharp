// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)




// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();

int x = Value("введите количество строк x:");
int y = Value("введите количество столбцов y:");
int z = Value("введите глубину z:");
int[,,] myArray = CreatArray(x, y, z, 1, 10);
PrintArray(myArray);


int Value(string message)
{
    Console.WriteLine(message);
    int a = int.Parse(Console.ReadLine());
    if (a > 0) return a;
    else
    {
        Console.WriteLine("ошибка. число должны быть больше 0, присвоено значение 1");
        return a = 10;

    }
}

int[,,] CreatArray(int n, int m, int y, int min, int max)
{
    int[,,] outArray = new int[n, m, y];
    int value = 1;
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            for (int k = 0; k < y; k++)
            {
                outArray[i, j, k] = value;
                value++;
            }
        }

    }
    return outArray;
}




void PrintArray(int[,,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int y = 0; y < array.GetLength(2); y++)
            {
                Console.Write($"{array[i, j, y]} ({i},{j},{y})  ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("");
    }

}
