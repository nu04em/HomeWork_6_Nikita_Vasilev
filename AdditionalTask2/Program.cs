// По целочисленным координатам вершин треугольника (x1,y1), (x2,y2) и (x3,y3) 
// требуется вычислить его площадь

Console.Clear();

Console.Write("Введите координату X1: ");
double x1 = Double.Parse(Console.ReadLine()!);

Console.Write("Введите координату Y1: ");
double y1 = Double.Parse(Console.ReadLine()!);

Console.Write("Введите координату X2: ");
double x2 = Double.Parse(Console.ReadLine()!);

Console.Write("Введите координату Y2: ");
double y2 = Double.Parse(Console.ReadLine()!);

Console.Write("Введите координату X3: ");
double x3 = Double.Parse(Console.ReadLine()!);

Console.Write("Введите координату Y3: ");
double y3 = Double.Parse(Console.ReadLine()!);

double area = 0.5 * Math.Abs((x2 - x1) * (y3 - y1) - (x3 - x1) * (y2 - y1));

Console.Write($"Площадь треугольника равна: {area}");