// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int OddElementsSum(int[] array)
{
    int sum = 0;

    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }

    return sum;
}

int length = 5;
int leftRange = -20;
int rightRange = 20;
int[] array = CustomArray(length, leftRange, rightRange);
ArrayOutput(array);

Console.WriteLine(OddElementsSum(array));