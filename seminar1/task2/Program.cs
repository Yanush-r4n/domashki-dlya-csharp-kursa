// Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.

Console.Clear();

Console.WriteLine("Напиши два числа, а я скажу которое побольше а которое поменьше.");

int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine(number1 + " это число побольше, а " + number2 + " - поменьше.");
}
else
{
    Console.WriteLine(number2 + " это число побольше, а " + number1 + " - поменьше.");
}