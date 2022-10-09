int x1, y1, z1, x2, y2, z2;
x1 = Coords ("Введите координату X первого числа; ");
y1 = Coords ("Введите координату Y первого числа; ");
z1 = Coords ("Введите координату Z первого числа; ");
x2 = Coords ("Введите координату X второго числа; ");
y2 = Coords ("Введите координату Y второго числа; ");
z2 = Coords ("Введите координату Z второго числа; ");
//Console.Write($"{x1}, {y1}, {z1}, {x2}, {y2}, {z2}");

Double distanse = Distanse(x1, y1, z1, x2, y2, z2);
Console.Write($"A ({x1},{y1},{z1}); B({x2},{y2},{z2}) -> {distanse}");
static int Coords(string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine() ?? "");
    return result;
}

static double Distanse(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double result = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1, 2));
    return result;
}