﻿// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите размеры массива");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];

for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
matrix[i, j] = Convert.ToInt32(new Random().Next(0, 100));
}

for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
Console.Write(matrix[i, j] + "\t  ");
Console.WriteLine();
}

for (int j = 0; j < matrix.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum += matrix[i, j];
    }
    Console.Write($"Cреднее арифметическое значение элементов в стобце №{j+1} -> { sum / matrix.GetLength(1)} ");
}

if (m <= 0 || n <= 0) 
{
   Console.Write($"Такого массива не существует");
}

Console.ReadLine();  