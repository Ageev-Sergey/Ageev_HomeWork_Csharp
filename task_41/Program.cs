/*
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

string myString = NumberString();
int sumValuyРigherZero = AboveZero(myString);
Console.WriteLine(myString);
Console.WriteLine(sumValuyРigherZero);


string NumberString()
{
    string a = "";
    string newString = "";
    do
    {
        Console.WriteLine("Введите число, или нажмите Enter  для выхода: ");
        a = Console.ReadLine();
        newString = newString + a + " ";
    }
    while (a != "");
    return newString;
}

int AboveZero(string thisString)
{
    int a;
    int sum = 0;
    string[] myStringArray = myString.Split(" ");
    for (int i = 0; i < myStringArray.Length; i++)
    {
        if (
            int.TryParse(myStringArray[i], out a)
            && a > 0
            )
            sum++;
    }
    return sum;
}

 */


string myString = NumberString();
int sumValuyРigherZero = AboveZero(myString);
Console.WriteLine(myString);
Console.WriteLine(sumValuyРigherZero);


string NumberString()
{
    Console.WriteLine("Введите числа через запятую: ");
    string newString = Console.ReadLine();
    return newString;
}

int AboveZero(string thisString)
{
    int a;
    int sum = 0;
    string[] myStringArray = myString.Split(",");
    for (int i = 0; i < myStringArray.Length; i++)
    {
        if (
            int.TryParse(myStringArray[i], out a)
            && a > 0
            )
            sum++;
    }
    return sum;
}
