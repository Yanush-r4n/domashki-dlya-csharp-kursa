﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();

Console.Write("Введи число, а я покажу кубы от единицы до твоего числа: ");
int num = Convert.ToInt32(Console.ReadLine());

double cube = 1;
int i = 1;

while (i <= num)
{
    cube = Math.Pow(i, 3);
    i++;

    Console.Write($"{cube} ");
}