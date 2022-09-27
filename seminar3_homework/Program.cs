// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
// 
// РВК: Общее решение.
Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int numbertemp = number;
int rebmun = 0;
while (numbertemp > 0)
{
    rebmun = rebmun * 10 + numbertemp % 10;
    numbertemp = numbertemp / 10;
}
if (number == rebmun) Console.WriteLine($"Число {number} - палиндром");
else Console.WriteLine($"Число {number} - не палиндром");



// // Задача 21
// // Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// // A (3,6,8); B (2,1,-7), -> 15.84
// // A (7,-5, 0); B (1,-1,9) -> 11.53
// // 
// // РВК: Для упрощения запроса на ввод написана функция.
// double PromptAndInput(string text)
// {
//     Console.Write("Введите " + text + ": ");
//     double result = Convert.ToDouble(Console.ReadLine());
//     return result;
// }
// Console.Clear();
// double[] point1 = {PromptAndInput("X1"), PromptAndInput("Y1"), PromptAndInput("Z1")};
// double[] point2 = {PromptAndInput("X2"), PromptAndInput("Y2"), PromptAndInput("Z2")};
// Console.WriteLine("Расстояние: " +
//     Math.Round(
//         Math.Sqrt(
//             Math.Pow(point1[0]-point2[0],2)+
//             Math.Pow(point1[1]-point2[1],2)+
//             Math.Pow(point1[2]-point2[2],2)
//         )
//     , 2)
// );



// // Задача 23
// // Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// // 3 -> 1, 8, 27
// // 5 -> 1, 8, 27, 64, 125
// //
// Console.Clear();
// Console.Write("Введите число: ");
// double num = Convert.ToDouble(Console.ReadLine());
// Console.Write(num + " -> " + 1);
// for (int i = 2; i<=num; i++)
//     Console.Write(", " + Math.Pow(i,3));
