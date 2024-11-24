using System;

public class AbsoluteDifferenceCalculator
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите целое число n:");
        string input = Console.ReadLine();

        try
        {
            int n = int.Parse(input);
            int result = CalculateDifference(n);
            Console.WriteLine($"Абсолютная разность между {n} и 123: {result}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка! Неверный формат ввода. Введите целое число.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла неизвестная ошибка: {ex.Message}");
        }
    }

    public static int CalculateDifference(int n)
    {
        int absoluteDifference = Math.Abs(n - 123);
        return n > 123 ? absoluteDifference * 3 : absoluteDifference;
    }
}
