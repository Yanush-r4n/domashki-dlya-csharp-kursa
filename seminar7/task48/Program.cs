// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

Console.Clear();

int[,] Get2DArray(int raws, int columns)
{
    int[,] array = new int[raws, columns];

    for (int i = 0; i < raws; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = i + j;
        }
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


int raws = 10;
int columns = 10;

Print2DArray(Get2DArray(raws, columns));