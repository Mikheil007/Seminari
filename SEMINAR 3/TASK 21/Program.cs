// 21 Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите координты точки A");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координты точки A");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координты точки А");
int x3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координты точки B");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координты точки B");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координты точки B");
int y3 = Convert.ToInt32(Console.ReadLine());
double w;
w = Math.Sqrt(Math.Pow(x1-y1,2)+Math.Pow(x2-y2,2)+Math.Pow(x3-y3,2));
Console.WriteLine($" расстояние между координат {w} ");