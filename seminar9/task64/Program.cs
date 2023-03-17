// адайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();

int number = 4;

int FromNumTo1(int number)
{
    Console.Write($"{number}, ");
    if (number == 2) return number;
    FromNumTo1(number - 1);

    return 1;
}

Console.WriteLine(FromNumTo1(number));