// Напишите программу, которая принимает на вход координаты точки (X и Y), причем X и Y не равны нулю
// и выдает номер четверти плоскости в которой находится эта точка.
Console.WriteLine("Введите координату Х:");
var xString = Console.ReadLine();
int x = int.Parse(xString!);
if(x==0)
{
    Console.WriteLine("Невозможно вычеслить четверти для точки лежащей на оси");
    return;
}
Console.WriteLine("Введите координату Y:");
var yString = Console.ReadLine();
int y = int.Parse(yString!);
if(y==0)
{
    Console.WriteLine("Невозможно вычеслить четверти для точки лежащей на оси");
    return;
}
int result = 0;
if(x>0 && y>0)
result=1;
else if(x<0 && y<0)
result=3;
else if(x<0 && y>0)
result=2;
else if(x>0 && y<0)
result= 4;
if(result!=0)
Console.WriteLine("Номер четверти в которой находится точка: " + result);
else
Console.WriteLine("Ошибка. Не удалось вычислить номер четверти");