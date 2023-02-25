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
    double size = array.Length;
    double multipliedArraySize = Math.Ceiling(size / 2);
    int middleOfArray = Convert.ToInt32(multipliedArraySize);
    int[] multipliedArray = new int[middleOfArray];

    int j = 0;
    for (int i = 0; i < multipliedArray.Length; i++)
    {
        j++;
        multipliedArray[i] = array[i] * array[array.Length - j];

        if (multipliedArray.Length * 2 > array.Length)
        {
            multipliedArray[multipliedArray.Length - 1] = array[middleOfArray - 1];
        }
    }

    return multipliedArray;
}

int length = 11;
int leftRange = 0;
int rightRange = 10;
int[] array = CustomArray(length, leftRange, rightRange);

ArrayOutput(array);
ArrayOutput(ArrayOppositeElementsMultiplier(array));