﻿//// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел
// от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

System.Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
// int sqare = 1;
// while (sqare <= num)
// {
// System.Console.WriteLine(Math.Pow(sqare, 2));
// sqare++;
// }
for (int i = 1; i <= num; i++)
{
System.Console.Write(Math.Pow(i, 2) + " ");
} 