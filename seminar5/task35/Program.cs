// Задайте массив из 123 случайных чисел. Найдите количество элементов массива, ктороые лежат в отрезке [10, 99]

Console.Clear();

int[] CustomArray(int length, int leftRange, int rightRange)
{
    int[] array = new int[length];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(leftRange, rightRange + 1);
    }

    return array;
}

int Detector(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {   
        if (array[i] >= 10 && array[i] <= 99)
        {
            count++;
        }
    }

    return count;
}

int length = 123;
int leftRange = 0;
int rightRange = 200;
int[] array = CustomArray(length, leftRange, rightRange);

Console.Write($"[{string.Join(", ", array)}], {Detector(array)}");