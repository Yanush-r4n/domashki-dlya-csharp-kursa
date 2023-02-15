// Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.

Console.Clear();

Console.WriteLine("Напиши три числа, а я скажу, какое из них самое большое");

int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());

int max = 0;

if (number1 > max)
{
    max = number1;
}
if (number2 > max)
{
    max = number2;
}
if (number3 > max)
{
    max = number3;
}

Console.WriteLine(max + " это самое большое число");