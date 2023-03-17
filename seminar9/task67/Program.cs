Console.Clear();

int number = 937;

int SumOfDigits(int number)
{
    int sum = number % 10;
    if (number > 10) {sum += SumOfDigits(number / 10);}
    return sum;
}

Console.Write(SumOfDigits(number));