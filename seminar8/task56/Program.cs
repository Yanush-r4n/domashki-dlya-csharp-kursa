// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

void SmallestRawSum(int[,] array)
{
    int[] sumArray = new int[array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumArray[i] = sumArray[i] + array[i,j];
        }
    }

    int min = sumArray[0];

    for (int i = 1; i < sumArray.Length; i++)
    {
        if (sumArray[i] < min) {min = sumArray[i];}
    }

    for (int i = 0; i < sumArray.Length; i++)
    {
        if (sumArray[i] == min)
        {
            Console.WriteLine($"У строки {i + 1} маленькая сумма, она равна {min}");
        }
    }

}

int raws = 3,
    columns = 3,
    leftRange = 0,
    rightRange = 9;
int[,] myArray = Custom2DArray(raws, columns, leftRange, rightRange);
Print2DArray(myArray);

Console.WriteLine();
SmallestRawSum(myArray);