// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();

int NumberInput(string MessageToUser)
{
    Console.Write(MessageToUser);
    return Convert.ToInt32(Console.ReadLine());
}

int ExpoundTheNumber(int number, int power)
{
    int result = 1;

    for (int i = 1; i <= power; i++)
    {
        result = result * number;
    }

    return result;
}

int number = NumberInput("Введи число, которое я буду возводить в степень: ");
int power = NumberInput("Введи саму степень: ");

Console.Write($"Получается, если {number} возвести в {power}, получится {ExpoundTheNumber(number, power)}");