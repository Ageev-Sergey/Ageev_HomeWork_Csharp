
Console.WriteLine("введите любое число: ");
int N = int.Parse(Console.ReadLine());
if (N > 0)
    for (int i = 1; i <= N; i += 1)
    {
        if ((i % 2) == 0)
            Console.Write("{0} ", i);
    }