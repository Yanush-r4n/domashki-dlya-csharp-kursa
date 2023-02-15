// Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.

Console.Clear();

Console.WriteLine("Напиши три числа, а я скажу, какое из них самое большое");

int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    if (number1 > number3)
    {
        Console.WriteLine(number1 + " самое большое");
    }
    else
    {
        Console.WriteLine(number3 + " самое большое");
    }
}
else if (number2 > number3)
{
    Console.WriteLine(number2 + " самое большое");
}
else
{
    Console.WriteLine(number3 + " самое большое");
}