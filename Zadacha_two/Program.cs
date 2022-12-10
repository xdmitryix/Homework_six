// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


// void FinalResult(int B1, int K1, int B2, int K2)
// {
//     int y1= 
// }








// Consolr.Clear();
// Console.WriteLine("введи значение b1: ");
// int b1 = int.Parse(Console.WriteLine());
// Console.WriteLine("введи значение k1: ");
// int k1 = int.Parse(Console.WriteLine());
// Console.WriteLine("введи значение b2: ");
// int b2 = int.Parse(Console.WriteLine());
// Console.WriteLine("введи значение k2: ");
// int k2 = int.Parse(Console.WriteLine());


Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
 
 
var x = -(b1 - b2) / (k1 - k2);
var y = k1 * x + b1;
 
x = Math.Round(x, 3);
y = Math.Round(y, 3);
 
Console.WriteLine($"Пересечение в точке: ({x};{y})");



