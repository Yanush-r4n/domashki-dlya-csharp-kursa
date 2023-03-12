// Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

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

void BubbleSortInRaws(int[,] array)
{
    for (int r = 0; r < array.GetLength(0); r++)
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
            for (int j = 0; j < array.GetLength(1) - i - 1; j++)
            {
                if (array[r,j] > array[r,j+1])
                {
                    int temp = array[r,j];
                    array[r,j] = array[r,j+1];
                    array[r,j+1] = temp;
                }   
            }
        }
    }
}

int raws = 4,
    columns = 6,
    leftRange = 0,
    rightRange = 9;
int[,] myArray = Custom2DArray(raws, columns, leftRange, rightRange);
Print2DArray(myArray);

Console.WriteLine();

int[,] myArrayCopy = Copy2DArray(myArray);
BubbleSortInRaws(myArrayCopy);
Print2DArray(myArrayCopy);

// int[] CustomArray(int length, int leftRange, int rightRange)
// {
//     int[] array = new int[length];

//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = Random.Shared.Next(leftRange, rightRange + 1);
//     }

//     return array;
// }

// int[] CopyArray(int[] array)
// {
//     int[] copyArray = new int[array.Length];

//     for(int i = 0; i < array.Length; i++)
//     {
//         copyArray[i] = array[i];
//     }

//     return copyArray;
// }

// void PrintArray(int[] array)
// {
//     Console.WriteLine($"[{string.Join(", ", array)}]");
// }

// void BubbleSort(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         for (int j = 0; j < array.Length - i - 1; j++)
//         {
//             if (array[j] > array[j+1])
//             {
//                 int temp = array[j];
//                 array[j] = array[j+1];
//                 array[j+1] = temp;
//             }
//         }
//     }
// }

// int length = 8,
//     leftRange = 0,
//     rightRange = 9;
// int[] myArray = CustomArray(length, leftRange, rightRange);
// PrintArray(myArray);

// Console.WriteLine();
// int[] copyArray = CopyArray(myArray);
// BubbleSort(copyArray);
// PrintArray(copyArray);

// Пришлось пузырьки для одномерного массива вспоминать (⇀‸↼‶)