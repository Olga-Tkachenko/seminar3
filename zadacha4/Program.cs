// Напишите программу, которая принимает на вход число (N) и выдает таблицу квадратов чисел от 1 до (N).
// Например: 5 - 1, 4, 9, 16, 25;  2 - 1,4.
Console.WriteLine("Введите число");
string? numberString = Console.ReadLine();
int number = int.Parse(numberString!);
int index = 1;
while(number >= index)
{
    var result = Math.Pow(index, 2);
    index++;
    Console.WriteLine(result);
}
