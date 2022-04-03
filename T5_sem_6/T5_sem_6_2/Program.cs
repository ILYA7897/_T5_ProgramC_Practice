// Задача 2. Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем 

 Console.Write("Введите число  b1 = ");
 int b1 = Convert.ToInt32(Console.ReadLine());

 Console.Write("Введите число  k1 = ");
 int k1 = Convert.ToInt32(Console.ReadLine());


 Console.Write("Введите число  b1 = ");
 int b2 = Convert.ToInt32(Console.ReadLine());

 Console.Write("Введите число  k1 = ");
 int k2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Введены следующие числа {b1} {k1} {b2} {k2}");
 
 // Пересечение линий в точке x3=(b2-b1)/(k1-k2) , y3=k1(b2-b1)/(k1-k2)+b1

int x3 = (b2-b1) / (k1-k2) ;
int y3 = k1 * (b2-b1) / (k1-k2) + b1 ;


Console.WriteLine($"Пересечение прямых будет в точке х3 = {x3} y3 = {y3}");

 Console.WriteLine($" ");
 
 Console.WriteLine($"END "); 