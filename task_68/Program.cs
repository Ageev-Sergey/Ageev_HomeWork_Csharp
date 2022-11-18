// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int N = IsValue("Введите число N");
int M = IsValue("Введите число M");
decimal result = IsValueAckermannFun(M, N);
Console.WriteLine(result);

int IsValue(string massege)
{
    Console.WriteLine(massege);
    int a =int.Parse(Console.ReadLine());
    return a;
}

int IsValueAckermannFun(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return IsValueAckermannFun(m - 1, 1);
    else return IsValueAckermannFun(m - 1, IsValueAckermannFun(m, n - 1));
}
