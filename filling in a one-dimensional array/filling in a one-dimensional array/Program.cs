using System;

class Program
{
    static void Main()
    {
        int[] A = new int[5];
        double[,] B = new double[3, 4];
        Random random = new Random();

        Console.WriteLine("Введите 5 целых чисел для массива A:");
        for (int i = 0; i < A.Length; i++)
        {
            Console.Write($"A[{i}] = ");
            A[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nМассив B (3x4) со случайными числами:");
        for (int i = 0; i < B.GetLength(0); i++)
        {
            for (int j = 0; j < B.GetLength(1); j++)
            {
                B[i, j] = Math.Round(random.NextDouble() * 200 - 100, 2);
                Console.Write(B[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nМассив A:");
        foreach (int num in A)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        double maxElement = A[0];
        double minElement = A[0];

        foreach (int num in A)
        {
            if (num > maxElement) maxElement = num;
            if (num < minElement) minElement = num;
        }

        foreach (double num in B)
        {
            if (num > maxElement) maxElement = num;
            if (num < minElement) minElement = num;
        }

        double sumAll = 0;
        double productAll = 1;

        foreach (int num in A)
        {
            sumAll += num;
            productAll *= num;
        }

        foreach (double num in B)
        {
            sumAll += num;
            productAll *= num;
        }

        int evenSumA = 0;
        foreach (int num in A)
        {
            if (num % 2 == 0)
                evenSumA += num;
        }

        double oddColumnSumB = 0;
        for (int j = 1; j < B.GetLength(1); j += 2)
        {
            for (int i = 0; i < B.GetLength(0); i++)
            {
                oddColumnSumB += B[i, j];
            }
        }

        Console.WriteLine($"\nОбщий максимальный элемент: {maxElement}");
        Console.WriteLine($"Общий минимальный элемент: {minElement}");
        Console.WriteLine($"Общая сумма всех элементов: {sumAll}");
        Console.WriteLine($"Общее произведение всех элементов: {productAll}");
        Console.WriteLine($"Сумма четных элементов массива A: {evenSumA}");
        Console.WriteLine($"Сумма элементов нечетных столбцов массива B: {oddColumnSumB}");
    }
}