// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

Console.Clear();

Console.Write("Введите b1: ");
double b1 = Double.Parse(Console.ReadLine()!);

Console.Write("Введите k1: ");
double k1 = Double.Parse(Console.ReadLine()!);

Console.Write("Введите b2: ");
double b2 = Double.Parse(Console.ReadLine()!);

Console.Write("Введите k2: ");
double k2 = Double.Parse(Console.ReadLine()!);

double x = (b1 - b2)/(k2 - k1);
double y = (k2 * b1 - k1 * b2)/(k2 - k1);
 
    if (k1 == k2)
        Console.WriteLine("Прямые не пересекаются");
    else
        Console.WriteLine($"Точка пересечения прямых: ({x};{y})");
