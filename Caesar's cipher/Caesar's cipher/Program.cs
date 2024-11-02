using System;

class CaesarCipher
{
    public static string Encrypt(string text, int shift)
    {
        string result = string.Empty;
        foreach (char c in text)
        {
            if (char.IsLetter(c))
            {
                char offset = char.IsUpper(c) ? 'A' : 'a';
                result += (char)(((c + shift - offset) % 26) + offset);
            }
            else
            {
                result += c;
            }
        }
        return result;
    }

    public static string Decrypt(string text, int shift)
    {
        return Encrypt(text, 26 - shift);
    }

    static void Main()
    {
        Console.Write("Введите текст для шифрования: ");
        string input = Console.ReadLine();

        Console.Write("Введите сдвиг: ");
        int shift = int.Parse(Console.ReadLine());

        string encrypted = Encrypt(input, shift);
        Console.WriteLine($"Зашифрованный текст: {encrypted}");

        string decrypted = Decrypt(encrypted, shift);
        Console.WriteLine($"Расшифрованный текст: {decrypted}");
    }
}