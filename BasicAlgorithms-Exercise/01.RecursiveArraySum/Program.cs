﻿int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

Console.WriteLine(Sum(arr, 0));
static int Sum(int[] array, int index)
    {
    if (index >= array.Length)
        {
        return 0;
        }
    return array[index] + Sum(array, index + 1);
    }
