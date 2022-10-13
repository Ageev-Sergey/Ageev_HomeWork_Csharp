/*
Задача 29: Напишите программу, которая задаёт массив
из N элементов и выводит их на экран.
(на входе N- длина массива, min и max- ограничения
для значений элементов массива, которые лежат в [min, max])
 */

// решение если вводить значение через параметры функции
// без проверки

/*
int[] dsa = randomArray(5, 1, 9);
int[] randomArray(int N, int min, int max)
{
    Random rnd = new Random();

    int[] a = new int[N];
    int i = 0;
    while (i < N)
    {
        a[i] = rnd.Next(min, max);
        i++;
    }
    return a;
}

for (int i = 0; i < dsa.Length; i++)
    Console.WriteLine(dsa[i]);
 */



// решение если вводить значение через консоль
// с проверкой


int[] myArray = randomArray();

int[] randomArray()
{

    Console.WriteLine("Ведите размер массива: ");
    string N = Console.ReadLine();
    Console.WriteLine("Ведите минимальное значение числа массива: ");
    string min = Console.ReadLine();
    Console.WriteLine("Ведите максимальное значение числа массива: ");
    string max = Console.ReadLine();

    if (checkRandomArray(N, min, max))
    {
        int xN = int.Parse(N);
        int xmin = int.Parse(min);
        int xmax = int.Parse(max);
        Random rnd = new Random();
        int[] a = new int[xN];
        int i = 0;
        while (i < xN)
        {
            a[i] = rnd.Next(xmin, xmax);
            i++;
        }
        return a;
    }

    Console.WriteLine("Ошибочка");
    int[] error = new int[0];
    return error;
}

bool checkRandomArray(string N, string min, string max)
{
    int xN;
    bool checkN = int.TryParse(N, out xN);
    if (checkN)
    {
        if (xN > 0)
        {
            int xmin;
            bool checkMin = int.TryParse(min, out xmin);
            if (checkMin)
            {
                int xmax;
                bool checkMax = int.TryParse(max, out xmax);
                if (checkMax && xmax > xmin)
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Некорректное значение max!!!");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Некорректное значение min!!!");
                return false;
            }
        }
        else
        {
            Console.WriteLine("N должно быть больше 0");
            return false;
        }
    }
    else
    {
        Console.WriteLine("некорректное значение N!!!");
        return false;
    }
}

Console.WriteLine(String.Join(", ", myArray));


// И по прежнему не знаю как из метода который должен что-то возвращать, вернуть просто ошибку)))
// В данном случае возвращаю пустой массив (