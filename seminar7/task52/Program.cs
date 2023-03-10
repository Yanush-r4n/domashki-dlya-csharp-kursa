// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();

int[,] Custom2DArray(int raws, int columns, int leftRange, int rightRange)
{
    int[,] array = new int[raws, columns];

    for (int i = 0; i < raws; i++)
    {
        for (int j = 0; j < columns; j++) {array[i,j] = Random.Shared.Next(leftRange, rightRange + 1);}
    }

    return array;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) {Console.Write($"{array[i, j]} ");}
        Console.WriteLine();
    }
}

double[] ArithmeticalMeansOfColumns(int[,] array)
{
    double[] meanArray = new double[array.GetLength(1)];

    for (int i = 0; i < array.GetLength(1); i++)
    {
        double sum = 0;
        int raws = 0;

        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum = sum + array[j,i];
            raws++;
        }

        meanArray[i] = sum / raws;
    }

    return meanArray;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++) {Console.Write($"{array[i]:f2}  ");}
}

int raws = 4,
    columns = 4,
    leftRange = 0,
    rightRange = 10;
int[,] myArray = Custom2DArray(raws, columns, leftRange, rightRange);
Print2DArray(myArray);

Console.WriteLine();
PrintArray(ArithmeticalMeansOfColumns(myArray));