﻿// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Clear();

Console.Write("Введи трёхзначное число, а я выведу тебе его вторую цифру - ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 99 && num < 1000 || num < -99 && num > -1000)
{
    num = Math.Abs(num%100/10);
    Console.Write($"{num} твоя вторая цифра");
}
else
{
    Console.Write("Перечитай условие внимательнее");
}