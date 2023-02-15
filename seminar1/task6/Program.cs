// Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка).

Console.Clear();

Console.WriteLine("Напиши число, а я скажу, чётное оно, или нет");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine("Оно чётное");
}
else
{
    Console.WriteLine("Оно нечётное");
}