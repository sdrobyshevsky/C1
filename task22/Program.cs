﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

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
System.Console.Write(Math.Pow(i, 3) + " ");
} 