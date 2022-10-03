Console.Clear();
int[] RandomNumArray(int length, int leftBound, int rightBound)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(leftBound, rightBound + 1);
    }
    return array;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "\t");
    }
    Console.WriteLine();
}
void PrintIndex(int length)
{
    for (int i = 0; i < length; i++)
    {
        Console.Write(i + "\t");
    }
    Console.WriteLine();
}


Console.WriteLine("Задача 34");
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
int[] array34 = RandomNumArray(10, 100, 999);
PrintArray(array34);
int countEven = 0;
for (int i = 0; i < array34.Length; i++)
{
    if (array34[i] % 2 == 0) countEven++;
}
Console.WriteLine("Количество четных чисел: " + countEven);
Console.WriteLine();


Console.WriteLine("Задача 36");
// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int[] array36 = RandomNumArray(5, -100, 100);
PrintIndex(array36.Length);
PrintArray(array36);
int sumUnvenPos = 0;
for (int i = 0; i < array36.Length; i += 2)
{
    sumUnvenPos += array36[i];
}
Console.WriteLine("Сумма элементов на нечетных позициях: " + sumUnvenPos);
Console.WriteLine();


Console.WriteLine("Задача 38");
// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
int[] array38 = RandomNumArray(5, -100, 100);
PrintArray(array38);
int max = array38[0];
int min = array38[0];
for (int i = 1; i < array38.Length; i++)
{
    if (array38[i] > max) max = array38[i];
    else if (array38[i] < min) min = array38[i];
}
Console.WriteLine("Разность max и min: " + (max - min));
Console.WriteLine();
