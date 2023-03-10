// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

Console.Clear();

int NumberInput(string MessageToUser)
{
    Console.Write(MessageToUser);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] Custom2DArray(int raws, int columns, int leftRange, int rightRange)
{
    int[,] array = new int[raws, columns];

    for (int i = 0; i < raws; i++)
    {
        for (int j = 0; j < columns; j++) { array[i, j] = Random.Shared.Next(leftRange, rightRange + 1); }
    }

    return array;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) { Console.Write($"{array[i, j]} "); }
        Console.WriteLine();
    }
}

string ElementDetector(int[,] array, int rawIndex, int columnIndex)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == rawIndex
            && j == columnIndex)
            {
                Console.Write("Элемент твой это ");
                return $"{array[i,j]}";
            }
        }
    }

    return "Нет такого элемента";
}

int raws = 6,
    columns = 9,
    leftRange = -5,
    rightRange = 5;
int[,] myArray = Custom2DArray(raws, columns, leftRange, rightRange);
Print2DArray(myArray);

int rawIndex = NumberInput("Введите индекс строки: ");
int columnIndex = NumberInput("Введите индекс столбца: ");
Console.WriteLine(ElementDetector(myArray, rawIndex, columnIndex));