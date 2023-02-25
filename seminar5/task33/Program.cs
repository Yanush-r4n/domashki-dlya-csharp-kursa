// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

int ReadNumber(string messageToUser)
{
    Console.Write(messageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int[] GetRandomArray(int length, int leftRange, int rightRange)
{

    int[] array = new int[length];

    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(leftRange, rightRange + 1);
    }

    return array;
}

string Detector(int[] array, int number)
{
    bool detector = false;
    string message = "Нет";

    for (int i = 0; i < array.Length; i++)
    {
        if (number == array[i])
        {
            detector = true;
            break;
        }
    }
    if (detector)
    {
        message = "Да";
    }

    return message;
}

int length = ReadNumber("Ввдеите длину массива: ");
int leftRange = ReadNumber("Введите левую границу вашего массива: ");
int rightRange = ReadNumber("Введите правую границу вашего массива: ");
int[] array = GetRandomArray(length, leftRange, rightRange);

int find = ReadNumber("Введите число, а я скажу, есть оно в массиве, или нет: ");

Console.WriteLine($"[{string.Join(", ", array)}]");
Console.Write(Detector(array, find));