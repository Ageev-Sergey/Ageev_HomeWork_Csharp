Console.WriteLine("введите трехзначное число");
int value = int.Parse(Console.ReadLine());
value = Math.Abs(value);        // если не надо брать отрицательные числа, то эта строка лишняя
if (value > 99 && value < 1000)
{
    int a = (value / 10) % 10;
    Console.WriteLine("вторая цифра " + a);
}
else
{
    Console.WriteLine(value +" не трехзначное число");
}