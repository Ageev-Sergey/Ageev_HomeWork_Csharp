Console.WriteLine("Введите первое число");
int Number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите Второе число");
int Number2 = int.Parse(Console.ReadLine());

if (Number1 > Number2)
{
    Console.WriteLine("{0} больше {1}", Number1, Number2);
}
else if (Number1 == Number2)
{
    Console.WriteLine("числа равны");
    }
else
    {
        Console.WriteLine("{1} больше {0} ", Number1, Number2);
    }
