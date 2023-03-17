// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.Clear();

int number = 6,
    pow = 8;

int NumInPow(int number, int power)
{
    if (power == 1) {return number;}

    int result = number;
    result *= NumInPow(number, power - 1);

    return result;
}

Console.Write(NumInPow(number, pow));