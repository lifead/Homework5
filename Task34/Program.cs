﻿// Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет 
// количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] createArray(int length)
{
    var random = new Random();

    int[] array = new int[length];

    for (int i = 0; i < array.Length; i++)
        array[i] = random.Next(100, 1000);

    return array;
}
int numbersEven(int[] array)
{
    var result = 0;

    for (long i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0)
            result++;
    return result;
}
void printArray(int[] array)
{
    Console.Write("[");

    for (var i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);

        if (i != array.Length - 1)
            Console.Write(", ");
    }

    Console.Write("]");
    Console.WriteLine();
}

Console.Write("Введите размер массива: ");
int length = int.Parse(Console.ReadLine()!);

var array = createArray(length);

printArray(array);

Console.WriteLine();
Console.WriteLine("Количество чётных чисел в массиве:");
Console.WriteLine(numbersEven(array));
Console.WriteLine();