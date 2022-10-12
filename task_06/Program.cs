Console.WriteLine("Введите любое число: ");
int value = int.Parse(Console.ReadLine());
if ((value % 2) != 0) {
    Console.WriteLine("число не четное");
}
else {
    Console.WriteLine("число четное");
}