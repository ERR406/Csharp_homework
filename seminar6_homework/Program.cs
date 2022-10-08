Console.Clear();

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.WriteLine("Задача 41. Вариант 1");
Console.WriteLine("Сколько чисел будет введено (М): ");
int m = Convert.ToInt32(Console.ReadLine());
int countPosNum = 0;
Console.WriteLine("Вводите через Enter");
for (int i = 0; i < m; i++)
{
    if (Convert.ToInt32(Console.ReadLine()) > 0) countPosNum++;
}
Console.WriteLine("Введено чисел больше нуля: " + countPosNum);
Console.WriteLine();

Console.WriteLine("Задача 41. Вариант 2");
int countPosNum2 = 0;
string input2 = string.Empty;
string strNumber = string.Empty;
Console.WriteLine("Введите через пробелы все необходимые числа");
input2 = Console.ReadLine() ?? "0";
int index = 0;
while (index < input2.Length)
{
    if (input2[index] != Convert.ToChar(" "))
    {
        strNumber += input2[index];
    }
    else
    {
        if (Convert.ToInt32(strNumber) > 0) countPosNum2++;
        strNumber = string.Empty;
    }
    index++;
}
if (Convert.ToInt32(strNumber) > 0) countPosNum2++;
Console.WriteLine("Введено чисел больше нуля: " + countPosNum2);
Console.WriteLine();


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.WriteLine("Задача 43");
Console.WriteLine("Прямые заданы уравнениями (y = k1 * x + b1) и (y = k2 * x + b2)");
Console.Write("Введите k1: "); double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1: "); double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: "); double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: "); double b2 = Convert.ToDouble(Console.ReadLine());
if (k1 == k2)
{
    if (b1 == b2) Console.WriteLine("Прямые совпадают");
    else Console.WriteLine("Прямые не пересекаются");
}
else
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"Точка пересечения прямых: ({Math.Round(x, 2)}; {Math.Round(y, 2)})");
}