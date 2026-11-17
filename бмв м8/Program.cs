using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Введите строку: ");
        string input = Console.ReadLine();

        string result = "";
        for (int i = 0; i < input.Length; i++)
        {
            if (i % 2 != 0)
            {
                result += char.ToUpper(input[i]);
            }
            else
            {
                result += input[i];
            }
        }

        Console.Write("Результат: " + result);
    }
}