using System;
class MyClass
{
    public static void Main()
    {
        int[] ints = { 1, 17, 3, 5, 8, 13, 23, 15 };
        ShowArray(ints);
        Array.Reverse(ints);
        ShowArray(ints);
    }
    static void ShowArray(int[] ints)
    {
        Console.WriteLine("Массив:");
        for (int i = 0; i < ints.Length; i++)
        {
            Console.Write(ints[i] + " ");
        }
        Console.WriteLine();
    }
}