using System;
using System.Linq;

public class ArraySorterAndMerger
{
    public static void Main(string[] args)
    {
        int[] arr1 = { 5, 2, 8, 1, 9, 4 };
        int[] arr2 = { 7, 3, 6 };

        Console.WriteLine("Исходный массив arr1:");
        PrintArray(arr1);

        Console.WriteLine("\nОтсортированный по возрастанию массив arr1:");
        SortAscending(arr1);
        PrintArray(arr1);


        Console.WriteLine("\nИсходный массив arr2:");
        PrintArray(arr2);

        Console.WriteLine("\nОтсортированный по убыванию массив arr2:");
        SortDescending(arr2);
        PrintArray(arr2);


        Console.WriteLine("\nОбъединенный массив:");
        int[] mergedArray = MergeArrays(arr1, arr2);
        PrintArray(mergedArray);

        Console.ReadKey();
    }

    // Метод сортировки массива по возрастанию
    public static void SortAscending(int[] arr)
    {
        Array.Sort(arr); // Используем встроенный метод Array.Sort() для повышения эффективности
    }


    // Метод сортировки массива по убыванию
    public static void SortDescending(int[] arr)
    {
        Array.Sort(arr, (x, y) => y.CompareTo(x)); //лямбда-выражение для сортировки по убыванию
    }


    // Метод объединения двух массивов в один
    public static int[] MergeArrays(int[] arr1, int[] arr2)
    {
        return arr1.Concat(arr2).ToArray(); // Используем LINQ для эффективного объединения
    }


    // Метод для вывода массива на консоль
    public static void PrintArray(int[] arr)
    {
        Console.WriteLine(string.Join(", ", arr));
    }
}
