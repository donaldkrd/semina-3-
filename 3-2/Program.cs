//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.Clear();
int x1 = ReadInt("Введите координату X1 точки: ");
int y1 = ReadInt("Введите координату Y1 точки: ");
int z1 = ReadInt("Введите координату Z1 точки: ");
int x2 = ReadInt("Введите координату X2 точки: ");
int y2 = ReadInt("Введите координату Y2 точки: ");
int z2 = ReadInt("Введите координату Z2 точки: ");

int A = x2 - x1;
int B = y2 - y1;
int C = z1 - z2;

double length = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine($"Длинна отрезка {length}");

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
