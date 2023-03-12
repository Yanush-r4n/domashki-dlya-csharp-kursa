// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// и

// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7

// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

Console.Clear();

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) {Console.Write($"{array[i, j]} ");}
        Console.WriteLine();
    }
}
 
int[,] ProductOfMatrices(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] productOfMatrices = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];

    for (int i = 0; i < productOfMatrices.GetLength(0); i++)
    {
        for (int j = 0; j < productOfMatrices.GetLength(1); j++)
        {
            for (int k = 0; k < firstMatrix.GetLength(1); k++)
            {
                productOfMatrices[i,j] += firstMatrix[i,k] * secondMatrix[k,j];
            }
        }
    }

    return productOfMatrices;
}

int[,] arrayOne = new int[4,4] { {1, 4, 7, 2},
                                 {5, 9, 2, 3},
                                 {8, 4, 2, 4},
                                 {5, 2, 6, 7} };

int[,] arrayTwo = new int[4,4] { {1, 5, 8, 5},
                                 {4, 9, 4, 2},
                                 {7, 2, 2, 6},
                                 {2, 3, 4, 7} };

Print2DArray(ProductOfMatrices(arrayOne, arrayTwo));

// Ответ не похож на произведение матриц, которое я в унике получала