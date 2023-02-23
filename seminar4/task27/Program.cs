// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();

int NumberInput(string MessageToUser)
{
    Console.Write(MessageToUser);
    return Convert.ToInt32(Console.ReadLine());
}

int NumbersLength(int number)
{
    int i = 0;
    for ( ; number > 0; i++)
    {
        number /= 10;
    }

    return i;
}

int[] ArrayOfDigits(int number)
{
    int[] array = new int[NumbersLength(number)];

    int PercentDevider = 10;
    int SlashDevider = 1;
    
    for (int i = 0; i < NumbersLength(number); i++)
    {
        array[i] = number % PercentDevider / SlashDevider;

        PercentDevider *= 10;
        SlashDevider *= 10;
    }

    return array;
}

int SumOfArrayOfDigits (int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        sum = sum + array[i];
    }

    return sum;
}

int number = NumberInput("Введи число, а я выведу сумму его цифр: ");

Console.Write($"А вот и твоя сумма цифр: {SumOfArrayOfDigits(ArrayOfDigits(number))}");