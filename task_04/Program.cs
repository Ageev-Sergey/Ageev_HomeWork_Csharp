Console.WriteLine("Введите первое число: ");
int Number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите Второе число: ");
int Number2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int Number3 = int.Parse(Console.ReadLine());
int MaxNumber = Number1;

if (Number2 > MaxNumber)
    MaxNumber = Number2;

if (Number3 > Number2)
    MaxNumber = Number3;

Console.WriteLine("найбольшее число {0}", MaxNumber);