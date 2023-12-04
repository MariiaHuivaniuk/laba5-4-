// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        int[] array = { 3, 2, 9, 4, 10 };

        var result = FindMinMax(array);

        Console.WriteLine($"Найменший елемент: {result.Min}");
        Console.WriteLine($"Найбільший елемент: {result.Max}");
    }

    static (int Min, int Max) FindMinMax(int[] arr)
    {
        if (arr == null || arr.Length == 0)
        {
            throw new ArgumentException("Масив не може бути порожнім або null");
        }

        int min = arr[0];
        int max = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < min)
            {
                min = arr[i];
            }
            else if (arr[i] > max)
            {
                max = arr[i];
            }
        }

        return (min, max);
    }
}
