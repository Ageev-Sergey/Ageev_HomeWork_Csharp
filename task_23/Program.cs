// Console.WriteLine("Выыдите число N:");
// int N = Convert.ToInt32(Console.ReadLine());
// funCube(N);
// void funCube(int N)
// {
//     if (N > 0)
//     {
//         while (N > 0)
//         {
//             double cube = Math.Pow(N, 3);
//             N--;
//             Console.WriteLine(cube);

//         }
//     }
//     else if (N < 0)
//     {
//         while (N < 0)
//         {
//             double Cube = Math.Pow(N, 3);
//             N++;
//             Console.WriteLine(Cube);

//         }
//     }
//     else
//     {
//         Console.WriteLine("Error");
//     }
// }



// сперва сделал как на сминаре, только вывожу от N^3 до 1, от -N^3 до -1
// а внизу сохраняю кубы в массив то arrayCubeN[0] = 1 до arrayCubeN[N] = N^3,
// а отрицательные от -1 до - N^3

Console.WriteLine("Выыдите число N:");
int N = Convert.ToInt32(Console.ReadLine());
int[] arrayCubeN = funCube(N);
Console.WriteLine(String.Join(", ", arrayCubeN));


int[] funCube(int N)
{
    int i = (Math.Abs(N))-1;
    int[] numbersArrayN = new int [Math.Abs(N)];
    if (N > 0)
    {
        while (N > 0)
        {
            int cube = Convert.ToInt32(Math.Pow(N, 3));
            numbersArrayN[i] = cube;
            i--;
            N--;
        }
    }
    else if (N < 0)
    {
        while (N < 0)
        {
            int cube = Convert.ToInt32(Math.Pow(N, 3));
            numbersArrayN[i] = cube;
            i--;
            N++;
        }
    }
    else
    {
        Console.WriteLine("Error");
    }
    return numbersArrayN;
}
