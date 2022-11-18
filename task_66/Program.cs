// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int N = IsValue("Введите число N");
int M = IsValue("Введите число M");
int sum = SumAllValue(N, M);
Console.WriteLine(sum);

int IsValue(string massege)
{
    Console.WriteLine(massege);
    int a = int.Parse(Console.ReadLine());
    return a;
}

int SumAllValue(int one, int two, int sum = 0)
{
    if (N != M)
    {
        if (one > two)
        {
            sum += one;
            sum = SumAllValue(--one, two, sum);
        }
        else if (two > one)
        {
            sum += one;
            sum = SumAllValue(++one, two, sum);
        }
        else sum += one;
        return sum;
    }
    Console.WriteLine("числа равны");
    return sum;
}
