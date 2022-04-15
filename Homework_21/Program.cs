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

        for (int i = 1; i < array.Length; i++)
        {
            if (i == array.Length - 1 && array[i] > array[i - 1])
            {
                Console.Write(array[i]);
            }
            else if (i == 1 && array[0] > array[1])
            {
                Console.Write($"{array[0]} ");
            }
            else if (array[i] > array[i - 1] &&  array[i] > array[i + 1])
            {
                Console.Write($"{array[i]} ");
            }
        }
    }
}