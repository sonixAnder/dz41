using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TextCensor
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> forbiddenWords = new List<string>()
            {
                "Bruh",
                "Bruh",
                "Bruh"
            };

            Console.WriteLine("Введите текст:");
            string text = Console.ReadLine();

            int replacementCount = 0;

            string[] words = text.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (forbiddenWords.Contains(words[i]))
                {
                    words[i] = new string('*', words[i].Length);
                    replacementCount++;
                }
            }

            string censoredText = string.Join(" ", words);

            Console.WriteLine("-----------------------");
            Console.WriteLine("Исходный текст:");
            Console.WriteLine(text);
            Console.WriteLine("-----------------------");
            Console.WriteLine("Проверенный текст:");
            Console.WriteLine(censoredText);
            Console.WriteLine("-----------------------");
            Console.WriteLine($"Заменено {replacementCount} недопустимых слов.");

            SaveToFile(censoredText, "censored_text.txt");

            Console.ReadKey();
        }

        static void SaveToFile(string text, string fileName)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    writer.WriteLine(text);
                }
                Console.WriteLine($"Текст сохранен в файл {fileName}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка сохранения файла: {ex.Message}");
            }
        }
    }
}
