using System;
using System.Data;

class SimpleCalculator
{
    public static double EvaluateExpression(string expression)
    {
        double result = 0;
        string currentNumber = string.Empty;
        char currentOperation = '+';

        for (int i = 0; i < expression.Length; i++)
        {
            char ch = expression[i];

            if (char.IsDigit(ch) || ch == '.')
            {
                currentNumber += ch;
            }

            if (!char.IsDigit(ch) && ch != '.' || i == expression.Length - 1)
            {
                double number = double.Parse(currentNumber);

                if (currentOperation == '+')
                {
                    result += number;
                }
                else if (currentOperation == '-')
                {
                    result -= number;
                }

                currentOperation = ch;
                currentNumber = string.Empty;
            }
        }

        return result;
    }

    static void Main()
    {
        Console.Write("Введите арифметическое выражение (+ или -): ");
        string input = Console.ReadLine();

        try
        {
            double result = EvaluateExpression(input);
            Console.WriteLine($"Результат: {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}