// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();

double NumberInput(string MessageToUser)
{
    Console.Write(MessageToUser);
    return Convert.ToDouble(Console.ReadLine());
}

Console.WriteLine("Есть две прямые, которые имеют вид y1 = k1*x + b1 y2 = k2*x + b2, ввести нужно");
double k1 = NumberInput("k1: ");
double b1 = NumberInput("b1: ");
double k2 = NumberInput("k2: ");
double b2 = NumberInput("b2: ");

double x = Math.Round((b2 - b1) / (k1 - k2), 2);
double y = Math.Round(k1 * ((b2 - b1) / (k1 - k2)) + b1, 2);

Console.WriteLine($"Точка пересечения: ({x}; {y})");