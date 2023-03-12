// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

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

int[,] TranspositionedMatrix(int[,] array)
{
    int k = array.GetLength(0);

    if (array.GetLength(0) == array.GetLength(1))
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            int j = (-1) * (k - array.GetLength(0));

            for (; j < array.GetLength(0); j++)
            {
                int temp = array[i,j];
                array[i,j] = array[j,i];
                array[j,i] = temp;
            }

            k--;
        }

        return array;
    }
    else
    {
        int[,] newArray = new int[array.GetLength(1), array.GetLength(0)];

        for (int i = 0; i < newArray.GetLength(0); i++)
        {
            for (int j = 0; j < newArray.GetLength(1); j++)
            {
                newArray[i,j] = array[j,i];
            }
        }

        return newArray;
    }
}

int raws = 2,
    columns = 6,
    leftRange = 0,
    rightRange = 9;
int[,] myArray = Custom2DArray(raws, columns, leftRange, rightRange);
Print2DArray(myArray);

Console.WriteLine();
int[,] copiedArray = Copy2DArray(myArray);
Print2DArray(TranspositionedMatrix(copiedArray));