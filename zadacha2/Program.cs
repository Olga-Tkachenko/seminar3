// Напишите программу, которая по заданному номеру четверти показывает диапазон возможных координат
// точек в этой четверти (X и Y).
Console.WriteLine("Введите номер четверти:");
var numberString = Console.ReadLine();
int number = int.Parse(numberString!);
if(number<1 || number>4)
{
    Console.WriteLine("Невозможно вычеслить диапазон");
    return;
}
else if(number==1) Console.WriteLine("Х от бесконечности до нуля и Y от бесконечности до нуля");
else if(number==2) Console.WriteLine("Х от минус бесконечности до нуля и Y от бесконечности до нуля");
else if(number==3) Console.WriteLine("Х от минус бесконечности до нуля и Y от минус бесконечности до нуля");
else if(number==4) Console.WriteLine("Х от бесконечности до нуля и Y от минус бесконечности до нуля");