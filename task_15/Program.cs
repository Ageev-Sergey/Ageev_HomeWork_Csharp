Console.WriteLine("Введите цифру обозначающую день недли (от 1 до 7): ");
int day = int.Parse(Console.ReadLine());        // так же подчеркивает волнистой чертой желтого цвета
if (day > 0 && day < 8)                         // "(Console.ReadLine())", но при этом работает)
{
    if (day == 6 || day == 7)
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }
}
else
{
    Console.WriteLine("Вы не справильсь с задачей ввести цифру от 1 до 7");
}