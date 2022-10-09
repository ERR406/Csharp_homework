string PromptAndInput(string text)
{
    Console.Write("Введите " + text + ": ");
    string result = Console.ReadLine() ?? string.Empty;
    return result;
}

int[,] RandomIntArray2D(int arrayLength0, int arrayLength1, int leftBoundRandom, int rightBoundRandom)
{
    int[,] array = new int[arrayLength0, arrayLength1];
    for (int i = 0; i < arrayLength0; i++)
    {
        for (int j = 0; j < arrayLength1; j++)
        {
            array[i, j] = new Random().Next(leftBoundRandom, rightBoundRandom + 1);
        }
    }
    return array;
}

double[,] RandomDoubleArray2D(int arrayLength0, int arrayLength1, double leftBoundRandom, double rightBoundRandom, int decimalPlacesNumber)
{
    double[,] array = new double[arrayLength0, arrayLength1];
    for (int i = 0; i < arrayLength0; i++)
    {
        for (int j = 0; j < arrayLength1; j++)
        {
            array[i, j] = Math.Round(new Random().NextDouble() * (rightBoundRandom - leftBoundRandom) + leftBoundRandom, decimalPlacesNumber);
        }
    }
    return array;
}

void PrintArray2D<T>(T[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
Console.WriteLine("Задача 47");
double[,] array47 = RandomDoubleArray2D(3, 4, -10, 10, 1);
PrintArray2D(array47);

Console.WriteLine();

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
Console.WriteLine("Задача 50");
int[,] array50 = RandomIntArray2D(3, 4, 0, 10);
PrintArray2D(array50);
int arrayRow = Convert.ToInt32(PromptAndInput("индекс строки"));
int arrayColumn = Convert.ToInt32(PromptAndInput("индекс столбца"));
if (arrayRow <= array50.GetLength(0) && arrayColumn <= array50.GetLength(0))
    Console.WriteLine($"Элемент с индексом [{arrayRow},{arrayColumn}]: {array50[arrayRow, arrayColumn]}");
else Console.WriteLine($"Нет элемента с индексом [{arrayRow},{arrayColumn}]");

Console.WriteLine();

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
Console.WriteLine("Задача 52");
int[,] array52 = RandomIntArray2D(3, 4, 0, 10);
PrintArray2D(array52);
Console.WriteLine("Среднее арифметическое:");
double sum = 0;
for (int j = 0; j < array52.GetLength(1); j++)
{
    for (int i = 0; i < array52.GetLength(0); i++)
    {
        sum += array52[i, j];
    }
    Console.Write(Math.Round(sum / array52.GetLength(0), 1) + "\t");
    sum = 0;
}
Console.WriteLine();