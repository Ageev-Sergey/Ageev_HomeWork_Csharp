// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07



internal class Program
{
    private static void Main(string[] args)
    {

        int[,] myArray = new int[5, 5];
        myArray = FillArray(myArray, 10);

        PrintArray(myArray);

        void PrintArray(int[,] array)
        {

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]}    ");
                }
                Console.WriteLine("");
            }

        }

        int[,] FillArray(int[,] incomingArray, int firstNamber)
        {
            int[,] outArray = new int[incomingArray.GetLength(0), incomingArray.GetLength(1)];
            int x = 0;
            int y = 0;
            outArray[x, y] = firstNamber;
            do
            {
                while (y + 1 < outArray.GetLength(1) && outArray[x, y + 1] == 0)
                {
                    y = y + 1;
                    outArray[x, y] = firstNamber;
                    firstNamber++;
                }
                while (x + 1 < outArray.GetLength(0) && outArray[x + 1, y] == 0)
                {
                    x = x + 1;
                    outArray[x, y] = firstNamber;
                    firstNamber++;
                }
                while (y - 1 >= 0 && outArray[x, y - 1] == 0)
                {
                    y = y - 1;
                    outArray[x, y] = firstNamber;
                    firstNamber++;
                }
                while (outArray[x - 1, y] == 0)
                {
                    x = x - 1;
                    outArray[x, y] = firstNamber;
                    firstNamber++;
                }
            } while (+1 < outArray.GetLength(1) && outArray[x, y + 1] == 0
                    || x + 1 < outArray.GetLength(0) && outArray[x + 1, y] == 0
                    || y - 1 >= 0 && outArray[x, y - 1] == 0
                    || outArray[x - 1, y] == 0);
            return outArray;
        }
    }
}
