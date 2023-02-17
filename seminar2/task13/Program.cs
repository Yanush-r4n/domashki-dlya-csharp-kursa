// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. (номер цифры считается от левого края)

Console.Clear();

Console.Write("Введи чило, а я покажу его третью цифру, начиная отсчёт с левого края - ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 999)
{
    num = num%1000/100;
    Console.WriteLine($"{num} твоя третья цифра");
}
else if (num > 99 && num < 1000)
{
    num = num/100;
    Console.WriteLine($"{num} твоя третья цифра");
}
else if (num < -99 && num > -1000)
{
    num = num/100*(-1);
    Console.WriteLine($"{num} твоя третья цифра");
}
else if (num < -999)
{
    num = num%1000/100*(-1);
    Console.WriteLine($"{num} твоя третья цифра");
}
else
{
    Console.WriteLine($"У твоего числа {num} нет третьего числа так-то");
}