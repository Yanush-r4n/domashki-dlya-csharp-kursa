// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Ну, я решила немного выпендриться

Console.Clear();

int LengthOfNum (int num)
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

while (num / LengthOfNum(num) == num % 10 && num > 10 || num < -10)
{
    num = num % LengthOfNum(num);
    num = num / 10;
    
    if (num < 10)
    {
        Console.WriteLine($"А число-то твое реально палиндром");
        break;
    }
}

if (num / LengthOfNum(num) != num % 10)
{
    Console.WriteLine("Не, оно не палиндром");
}
if (num <= 9 || num >= -9)
{
    Console.WriteLine("Оно вообще однозначное, отзеркалить не получиться");
}