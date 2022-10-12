Console.WriteLine("введите число: ");

String value = Console.ReadLine();
int b = int.Parse(value);
for (int i = 1; i < 3; i++)
{
    b = b / 10;
}
if (b > 0)
{
    Console.WriteLine( value[2] );
}
else if (b < 0)
{
    Console.WriteLine( value[3] );
}
else
{
    Console.WriteLine("третьей цифры нет");
}

/* почему он подчеркивает у меня на 3-й строке "Console.ReadLine();",
а на 4-й "(value)", желтой волнистой линией? */
