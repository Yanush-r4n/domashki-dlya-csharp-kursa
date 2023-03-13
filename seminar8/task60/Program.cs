// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// массив размером 2 x 2 x 2

// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

Console.Clear();

int[,,] Custom3DAray(int layers, int raws, int elements, int firstElement)
{
    int[,,] array = new int[layers, raws, elements];

    for (int i = 0; i < layers; i++)
    {
        for (int j = 0; j < raws; j++)
        {
            for (int k = 0; k < elements; k++)
            {
                array[i,j,k] = firstElement;
                firstElement++;
            }
        }
    }

    return array;
}

void Print3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i,j,k]}({i},{j},{k}) ");
            }

            Console.WriteLine();
        }

        Console.WriteLine();
    }
}

int layers = 2,
    raws = 2,
    elements = 2,
    firstElement = 27;

int[,,] myCubik = Custom3DAray(layers, raws, elements, firstElement);
Print3DArray(myCubik);