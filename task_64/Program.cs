
// // Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// // N = 5 -> "5, 4, 3, 2, 1"
// // N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


int N = IsValue("Введите число N");
AllValue(N);

int IsValue(string massege)
{
    Console.WriteLine(massege);
    int a = int.Parse(Console.ReadLine());
    return a;
}

void AllValue(int N)
{
    if (N > 1)
    {
        Console.Write($"{N}, ");
        AllValue(N - 1);
    }
    else if (N == 1) Console.Write(N);
    else Console.WriteLine("недопустимое значение, число должной быть больше 0");
}