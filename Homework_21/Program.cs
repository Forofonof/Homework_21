using System;

    internal class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();

        int[] array = new int[30];

        Console.WriteLine("Массив:\n");

        for (int i = 0; i < array.Length; i++) 
        {
            int arrayFull = random.Next(0,50);
            array[i] = arrayFull;
            Console.Write($"{array[i]} ");
        }
        Console.WriteLine("\n\nЛокальные максимумы:\n ");

        if (array[0] > array[1])
        {
            Console.Write($"{array[0]} ");
        }
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > array[i - 1] &&  array[i] > array[i + 1])
            {
                Console.Write($"{array[i]} ");
            }
        }
        if (array[array.Length - 1] > array[array.Length - 2])
        {
            Console.Write($"{array[array.Length - 1]} ");
        }
    }
}