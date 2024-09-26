using System;
class MyClass
{
    public static int[] RandomArray(int length)
    {
        Random rnd = new Random();
        int[] arr = new int[length];

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rnd.Next(100, 999);
        }
        return arr;
    }
    public static void Main()
    {

        int[] nums = RandomArray(6);
        int count = 0;
        Console.WriteLine("Массив:");
        foreach (int num in nums)
        {
            if (num % 2 == 0) count++;
            Console.Write(num + " ");
        }
        Console.WriteLine($"\nКоличество четных чисел в массиве: {count}");

    }
}