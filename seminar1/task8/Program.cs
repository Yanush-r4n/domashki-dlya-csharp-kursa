// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Clear();

Console.WriteLine("Введи число, а я покажу ряд чётных чисел от 1 до твоего числа");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    for (int i = 1; i <= number; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(i + " ");
    }
}
}
else
{
    Console.WriteLine("Минусы и нули в сделку не входили");
}