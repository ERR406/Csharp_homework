Console.Clear();


// // Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// // 3, 5 -> 243 (3⁵)
// // 2, 4 -> 16
// Console.WriteLine("A ^ B");
// Console.Write("Введите А: ");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите B: ");
// int B = Convert.ToInt32(Console.ReadLine());
// int result = 1;
// for (int i = 1; i <= B; i++)
// {
//     result = result * A;
// }
// Console.WriteLine($"{A} ^ {B} = {result}");


// // Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// // 452 -> 11
// // 82 -> 10
// // 9012 -> 12
// Console.Write("Введите число: ");
// string strNumber = Console.ReadLine();
// int sum = 0;
// for (int i = 0; i < strNumber.Length; i++)
// {
//     sum += Convert.ToInt32($"{strNumber[i]}"); // Конструкция некрасивая, но позволяет получить цифру, а не номер символа (от 48 до 57)
// }
// Console.WriteLine($"Сумма цифр {strNumber} равна {sum}");


// // Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// // 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// // 6, 1, 33 -> [6, 1, 33]
// int[] array = new int[8];
// string stringArray = "[";
// int i;
// for (i = 0; i < array.Length - 1; i++)
// {
//     array[i] = new Random().Next(0, 100);
//     stringArray = stringArray + array[i] + ", ";
// }
// array[i] = new Random().Next(0, 100); // Последнее число генерируется вне цикла, чтобы включить его в строку без ", "
// stringArray = stringArray + array[i] + "]";
// Console.WriteLine(stringArray);


//  Доп. задача семинара: У нас есть график, где даны отрезок 1 -  (х1; x2) и отрезок 2 (х3, x4)
// 	​Необходимо составить код, который находит их пересечение.
// 	Пересечением двух отрезка 1 и 2 могут быть  - отрезок, точка или ничего
// 	С клавиатуры вводим х1, x2, х3, x4 и выводим ответ - границы пересечений отрезков, общую точку или «не пересекаются».
Console.WriteLine("Отрезки (х1, х2) и (х3, х4)");
Console.Write("x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("x3: ");
int x3 = Convert.ToInt32(Console.ReadLine());
Console.Write("x4: ");
int x4 = Convert.ToInt32(Console.ReadLine());
int temp = 0;
if (x1 > x2)
{
    temp = x1;
    x1 = x2;
    x2 = temp;
}
if (x3 > x4)
{
    temp = x3;
    x3 = x4;
    x4 = temp;
}
if (x2 == x3)
{
    Console.WriteLine("Пересекаются в точке " + x2);
}
else if (x1 == x4)
{
    Console.WriteLine("Пересекаются в точке " + x1);
}
else if (x2 > x3 & x1 <= x3)
{
    if (x2 >= x4)
    {
        Console.WriteLine("Пересекаются в границах " + x3 + ":" + x4);
    }
    else
    {
        Console.WriteLine("Пересекаются в границах " + x3 + ":" + x2);
    }
}
else if (x4 > x1 & x3 <= x1)
{
    if (x4 >= x2)
    {
        Console.WriteLine("Пересекаются в границах " + x1 + ":" + x2);
    }
    else
    {
        Console.WriteLine("Пересекаются в границах " + x1 + ":" + x4);
    }
}
else Console.WriteLine("Не пересекаются");
// Визуализация для проверки корректности алгоритма
int min = x1;
int max = x2;
if (x3 < x1) min = x3;
if (x4 > x2) max = x4;
Console.WriteLine();
for (int i = min; i <= max; i++)
{
    if (i == x1 || i == x2 || i == x3 || i == x4) Console.Write(i + " ");
    else Console.Write("." + " ");
}
Console.WriteLine();
Console.WriteLine();