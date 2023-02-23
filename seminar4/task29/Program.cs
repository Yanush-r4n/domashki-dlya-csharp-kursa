// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();

int NumberInput(string MessageToUser)
{
    Console.Write(MessageToUser);
    return Convert.ToInt32(Console.ReadLine());
}

int[] ArrayFiller(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }

    return array;
}

int count = NumberInput("Какого размера массив ты хочешь заполнить? - ");

Console.WriteLine("Ну, а теперь заполняй массив");

Console.Write($"Твой массив - [{string.Join(", ", ArrayFiller(count))}]");