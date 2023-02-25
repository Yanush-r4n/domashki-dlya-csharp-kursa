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

int[] ArrayOppositeElementsMultiplier(int[] array)
{
    int size = array.Length / 2 + array.Length % 2;
    int[] multipliedArray = new int[size];

    for (int i = 0; i < multipliedArray.Length; i++)
    {
        multipliedArray[i] = array[i] * array[array.Length - i - 1];

        if (array.Length % 2 == 1)
        {
            multipliedArray[multipliedArray.Length - 1] = array[size - 1];
        }
    }

    return multipliedArray;
}

int length = 10;
int leftRange = 0;
int rightRange = 10;
int[] array = CustomArray(length, leftRange, rightRange);

ArrayOutput(array);
ArrayOutput(ArrayOppositeElementsMultiplier(array));