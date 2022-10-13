// Задача 25: Напишите цикл, который принимает
// на вход два числа (A и B) и возводит число A в натуральную степень B.


double c = MaP();
double MaP()
{
    Console.WriteLine("введите число: ");
    string a = Console.ReadLine();
    double A;
    bool resultA = Double.TryParse(a, out A);
    if (resultA)
    {
        Console.WriteLine("введите степень: ");
        string b = Console.ReadLine();
        int B;
        bool resultB = int.TryParse(b, out B);
        if (resultB)
        {
            if (B == 0) return 1;

            else if (B > 0)
            {
                double number = A;
                for (int i = 1; i < B; i++)
                {
                    A = A * number;
                }
                return A;
            }
            else
            {
                double number = A;
                int Bx = Math.Abs(B);
                for (int i = 1; i<Bx; i++)
                {
                    A = A * number;
                }
                return 1/A;
            }

        }
        else
        {
            Console.WriteLine("некорректное значение тепени");
            return 0;
        }
    }
    else
    {
        Console.WriteLine("некорректное значение числа");
        return 0;
    }

}

Console.WriteLine(c);