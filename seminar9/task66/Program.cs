// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();

int numOne = 1,
    numTwo = 15;

int SumFromMToN(int m, int n)
{
    if (m == n) return m;
    int sum = m;
    sum += SumFromMToN(m + 1, n);
    return sum;
}

Console.Write(SumFromMToN(numOne, numTwo));