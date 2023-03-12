// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

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

int[,] Copy2DArray(int[,] array)
{
    int[,] arrayCopy = new int[array.GetLength(0), array.GetLength(1)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            arrayCopy[i, j] = array[i, j];
        }
    }

    return arrayCopy;
}

void ReverseFirstWithLastLine(int[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int temp = array[0,i];
        array[0,i] = array[array.GetLength(0) - 1,i];
        array[array.GetLength(0) - 1,i] = temp;
    }
}

int raws = 5,
    columns = 5,
    leftRange = 0,
    rightRange = 10;
int[,] myArray = Custom2DArray(raws, columns, leftRange, rightRange);
Print2DArray(myArray);

Console.WriteLine();
int[,] reversedArray = Copy2DArray(myArray);
ReverseFirstWithLastLine(reversedArray);
Print2DArray(reversedArray);