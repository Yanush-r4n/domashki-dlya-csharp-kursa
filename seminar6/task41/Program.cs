// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int NumberInput(string MessageToUser)
{
    Console.Write(MessageToUser);
    return Convert.ToInt32(Console.ReadLine());
}

int[] ArrayOfNumbers(int size)
{
    int[] array = new int[size];
    
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }

    return array;
}

int Detector(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }

    return count;
}

Console.Clear();

int size =  NumberInput("Сколько чисел на проверку даш? - ");
int[] array = ArrayOfNumbers(size);
int count = Detector(array);
Console.WriteLine($"{count} чисел больше нуля");