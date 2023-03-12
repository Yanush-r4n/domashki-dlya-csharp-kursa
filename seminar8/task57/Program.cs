// Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных. Элементы внутри массива лежат в интервале [0, 9]

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

int CountOfUniqueDigits(int[,] array) 
{
    int uniqueElement = 0;
    int totalCount = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int m = i; m < array.GetLength(0); m++)
            {
                for (int n = 0; n < array.GetLength(1); n++)
                {
                    if (m == i && n < j)
                    {
                        n = j;
                    }

                    if (array[i,j] == array[m,n])
                    {
                        uniqueElement++;
                        if (uniqueElement > 1)
                        {
                            break;
                        }
                    }
                }

                if (uniqueElement > 1) 
                {
                    uniqueElement = 0;
                    break;
                }
            }

            totalCount = totalCount + uniqueElement;
        }
    }

    return totalCount;
}
// Этот метод по сути дела должен подсчитывать количество цифр, которые встречаются в матрице,
// т.е. в матрице
// 5 4 4
// 4 0 1 
// 5 9 2
// метод должен был насчитать тут 6 цифр, ибо тут встречаются 5, 4, 0, 1, 9, 2..
// но оно не работает, и у меня закончились идеи. Я всё, я признаю поражение перед этой задачей,
// её усложнённый вариант мне пока не по зубам, а иначе было бы неинтересно ┐(￣～￣)┌ 

int raws = 3,
    columns = 3,
    leftRange = 0,
    rightRange = 9;
int[,] myArray = Custom2DArray(raws, columns, leftRange, rightRange);
Print2DArray(myArray);

Console.WriteLine();
Console.Write(CountOfUniqueDigits(myArray));