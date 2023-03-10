// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();

double[,] Custom2DArrayOfDoubles(int raws, int columns, double leftRange, double rightRange)
{
    double[,] array = new double[raws, columns];

    for (int i = 0; i < raws; i++)
    {
        for (int j = 0; j < columns; j++) 
        {
            double element = Random.Shared.NextDouble() * (rightRange + (-1) * leftRange) + leftRange;
            array[i,j] = element;
        }
    }

    return array;
}

void Print2DArrayOfDoubles(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) {Console.Write($"{array[i, j]:f1} ");}
        Console.WriteLine();
    }
}

int raws = 4,
    columns = 4;

double  leftRange = -5,
        rightRange = 5;

double[,] myArray = Custom2DArrayOfDoubles(raws, columns, leftRange, rightRange);
Print2DArrayOfDoubles(myArray);