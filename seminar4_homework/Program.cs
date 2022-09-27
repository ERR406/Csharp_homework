Console.Clear();


// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.WriteLine("A ^ B");
Console.Write("Введите А: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите B: ");
int B = Convert.ToInt32(Console.ReadLine());
int result = 1;
for (int i = 1; i <= B; i++)
{
    result = result * A;
}
Console.WriteLine($"{A} ^ {B} = {result}");


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