// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


// не знаю как сделать что бы из метода в случае ошибки не возвращать int, из-за этого... "сумма чисел равна: 0"(

int c = SumNumbers();


int SumNumbers()
{
    Console.WriteLine("введите число: ");
    string a = Console.ReadLine();
    int value;
    bool result = int.TryParse(a, out value);
    int i = 0;
    if (result)
    {
        if (value > 0)
        {
            while (value > 0)
            {
                i = i + (value % 10);
                value = value / 10;
            }
        }
        else
        {
            Console.WriteLine("Введите положительное число, больше 0 !!!");
            return 0;
        }

    }
    else
    {
        Console.WriteLine("Ошибка, введите корректные данные!!!");
        return 0;
    }
    return i;
}
Console.WriteLine("сумма чисел равна: "+c);