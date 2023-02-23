// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Ну, я решила немного выпендриться

Console.Clear();

int DigitOfNum (int num)
{
    int length = 1;

    while (num >= 10)
    {
        num = num / 10;
        length = length * 10;
    }

    return length;
}

Console.Write("Вводи любое число, которое инт позволит, а я скажу, палиндром оно, или не: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 10)
{
    Console.WriteLine("Это вообще однозначное число");
}

while (num / DigitOfNum(num) == num % 10 && num > 10 || num < -10)
{
    num = num % DigitOfNum(num);
    num = num / 10;
    
    if (num < 10)
    {
        Console.WriteLine($"А число-то твое реально палиндром");
        break;
    }
}

if (num / DigitOfNum(num) != num % 10)
{
    Console.WriteLine("Не, оно не палиндром");
}