// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// ​ (в примере подсчет индексов начинается с 1 , как в математике)
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

Console.Clear();

int[,] Get2DArray(int raws, int columns)
{
    int[,] array = new int[raws, columns];

    for (int i = 0; i < raws; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = Random.Shared.Next(0, 10);
        }
    }

    return array;
}

void SquareOddElements(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 != 0 && j % 2 != 0) {array[i, j] = array[i, j] * array[i, j];}
        }
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

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) {Console.Write($"{array[i, j]} ");}
        Console.WriteLine();
    }
}

int raws = 4;
int columns = 4;

int[,] matrix = Get2DArray(raws, columns);

Print2DArray(Copy2DArray(matrix));

Console.WriteLine();

SquareOddElements(matrix);
Print2DArray(matrix);