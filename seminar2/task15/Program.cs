// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();

Console.Write("Введи номер дня недели, а я скажу, выходной это или нет - ");
short num = Convert.ToByte(Console.ReadLine());

if (num == 6 || num == 7)
{
    Console.WriteLine("Поздравляю, можешь откиснуть");
}
else if (num > 0 && num < 6)
{
    Console.WriteLine("День недели канечно, но не выходной");
}
else
{
    Console.WriteLine("Чёта ты напутал, перечитай условие");
}