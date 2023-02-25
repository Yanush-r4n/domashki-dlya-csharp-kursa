// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

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

void ArrayOutput(int[] array)
{
    Console.WriteLine($"[{string.Join(", ", array)}]");
}

(int max, int min) MaxAndMinOfArray(int[] array)
{
    int max = array[1];
    int min = array[1];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        else if (array[i] < min)
        {
            min = array[i];
        }
    }

    return (max, min);
}

int length = 5;
int leftRange = -20;
int rightRange = 20;
int[] array = CustomArray(length, leftRange, rightRange);
ArrayOutput(array);

(int max, int min) = MaxAndMinOfArray(array);
Console.WriteLine(max - min);