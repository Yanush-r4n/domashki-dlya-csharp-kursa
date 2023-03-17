// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9

Console.Clear();

int m = 3,
    n = 5;

int Akkermann(int m, int n)
{
    if (m == 0) {return n + 1;}
    if (m > 0 && n == 0) {return Akkermann(m - 1, 1);}
    if (m > 0 && n > 0) {return Akkermann(m - 1, Akkermann(m, n - 1));}

    return n;
}

Console.Write(Akkermann(m, n));