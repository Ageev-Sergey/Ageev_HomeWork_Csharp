Console.WriteLine("введите координаты первой точки: ");
int[] pointOne = pointXYZ();

Console.WriteLine("введите координаты второй точки: ");
int[] pointTwo = pointXYZ();


int[] pointXYZ()
{
    Console.WriteLine("введите x");
    Int32 x = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("введите y");
    Int32 y = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("введите z");
    Int32 z = Convert.ToInt32(Console.ReadLine());
    Int32[] point = new Int32[3] { x, y, z };

    return point;
}

double distance = Math.Sqrt
(
    Math.Pow((pointTwo[0] - pointOne[0]), 2) +
    Math.Pow((pointTwo[1] - pointOne[1]), 2) +
    Math.Pow((pointTwo[2] - pointOne[2]), 2)
);

Console.WriteLine("длинна отрезка равна: " + distance);
