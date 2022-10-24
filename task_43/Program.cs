// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.


double[] firstLine = NewLine();
double[] secondLine = NewLine();
double[] intersectionPoint = IsIntersectionPoint(firstLine, secondLine);

Console.WriteLine($"первая линия: y = {firstLine[0]}x + {firstLine[1]} ");
Console.WriteLine($"вторя линия: y = {secondLine[0]}x + {secondLine[1]}");
Console.WriteLine("точка пересечения "+string.Join(", ", intersectionPoint));



double[] NewLine()
{
    double a;
    double c;
    bool check = false;
    do
    {
        Console.WriteLine("Введите коэффициент: ");
        check = Double.TryParse(Console.ReadLine(), out a);
        if (check == false) Console.WriteLine("некорректное значение коэффициента!");

    }
    while (check == false);

    do
    {
        Console.WriteLine("Введите С: ");
        check = Double.TryParse(Console.ReadLine(), out c);
        if (check == false) Console.WriteLine("некорректное значение С!");
    }
    while (check == false);

    double[] newLine = new double[2];
    newLine[0] = a;
    newLine[1] = c;
    return newLine;
}

double[] IsIntersectionPoint(double[] first,double[] second)
{
    double x = (first[0]-second[0])/(second[1]-first[1]);
    double y = first[0]*x + first[1];
    double[] point = new double [2]{x, y};
    return point;
}