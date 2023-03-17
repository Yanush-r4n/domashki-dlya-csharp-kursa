Console.Clear();

int number = 6;

int Sequence(int n)
{
    if (n == 1) {return 1;}
    Console.Write($"{Sequence(n - 1)}, ");
    return n;
}

Console.Write(Sequence(number));