// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

Console.WriteLine("Введи корды двух точек в 3д пространстве");
double x1 = Convert.ToDouble(Console.ReadLine()),
       y1 = Convert.ToDouble(Console.ReadLine()),
       z1 = Convert.ToDouble(Console.ReadLine()),
       x2 = Convert.ToDouble(Console.ReadLine()),
       y2 = Convert.ToDouble(Console.ReadLine()),
       z2 = Convert.ToDouble(Console.ReadLine());

double dist = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1, 2));

Console.WriteLine($"{dist} твоя дистанция");