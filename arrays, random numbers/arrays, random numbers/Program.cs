using System;

class Program
{
    static void Main()
    {
        int[,] array = new int[5, 5];
        Random random = new Random();

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                array[i, j] = random.Next(-100, 101);
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }

        int min = array[0, 0];
        int max = array[0, 0];
        int minIndex = 0;
        int maxIndex = 0;

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (array[i, j] < min)
                {
                    min = array[i, j];
                    minIndex = i * 5 + j;
                }
                if (array[i, j] > max)
                {
                    max = array[i, j];
                    maxIndex = i * 5 + j;
                }
            }
        }

        int start = Math.Min(minIndex, maxIndex);
        int end = Math.Max(minIndex, maxIndex);

        int sum = 0;
        for (int k = start + 1; k < end; k++)
        {
            int row = k / 5;
            int col = k % 5;
            sum += array[row, col];
        }

        Console.WriteLine("\nМинимальный элемент: " + min);
        Console.WriteLine("Максимальный элемент: " + max);
        Console.WriteLine("Сумма элементов между минимальным и максимальным: " + sum);
    }
}
