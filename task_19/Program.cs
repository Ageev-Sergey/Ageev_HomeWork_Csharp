Console.WriteLine("введите пятизначное число");
String value = Console.ReadLine();
int valueCheck = Math.Abs(int.Parse(value));

if ((valueCheck / 10000) > 0 && (valueCheck / 10000) < 10)
{
    IsPalindrom(value);
}
else
{
    Console.WriteLine("ошибка");
}

void IsPalindrom(string valuePalindrim)
{
    string a = "-";
    if (value[0] != a[0])
    {
        if (value[0] == value[4] && value[1] == value[3])
        {
            Console.WriteLine(value + " является палидромом");
        }
        else
        {
            Console.WriteLine(value + " не палидромом");
        }
    }
    if (value[0] == a[0])
    {
        if (value[1] == value[5] && value[2] == value[4])
        {
            Console.WriteLine(value + " является палидромом");
        }
        else
        {
            Console.WriteLine(value + " не палидромом");
        }
    }
}


// с минусом тоже работает, но вообще, если читать отрицательное число
// c конца, то оно будет читаться как положительное а потом минус что-то (чего нет)
// внизу пример того, если все отрицательные считать не палидромом

/* Console.WriteLine("введите пятизначное число");
String value = Console.ReadLine();
int valueInt = int.Parse(value);
int valueCheck = Math.Abs(valueInt);

if ((valueCheck / 10000) > 0 && (valueCheck / 10000) < 10)
{
    IsPalindrom(value);
}
else
{
    Console.WriteLine("ошибка");
}

void IsPalindrom(string valuePalindrim)
{
    if (valueInt > 0)
    {
        if (value[0] == value[4] && value[1] == value[3])
        {
            Console.WriteLine(value + " является палидромом");
        }
        else
        {
            Console.WriteLine(value + " не палидромом");
        }
    }
    else
    {
        Console.WriteLine(value + " не палидромом");
    }
}
 */