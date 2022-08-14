// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними
// в 2D простарнстве. Например: А(3,6); В(2,1) - 5,09. А(7,-5); В(1,-1) - 7,21.
Console.WriteLine("Введите координату Х1");
var numberX1 = Console.ReadLine();
int x1 = int.Parse(numberX1!);

Console.WriteLine("Введите координату Y1");
var numberY1 = Console.ReadLine();
int y1 = int.Parse(numberY1!);

Console.WriteLine("Введите координату Х2");
var numberX2 = Console.ReadLine();
int x2 = int.Parse(numberX2!);

Console.WriteLine("Введите координату Y1");
var numberY2 = Console.ReadLine();
int y2 = int.Parse(numberY2!);

double AB = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1));
Console.WriteLine("\n" + AB.ToString("N2"));
