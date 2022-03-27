//Семинар 1 задача 1
// Задача 1: Напишите программу,
// которая принимает на вход трёхзначное число и на выходе показывает вторую 
// цифру этого числа.
Console.WriteLine("Введите целое трехзначное число = ");
string strV1 = Console.ReadLine();
int value1 = int.Parse(strV1) ;
int result = (value1%100)/10 ; 
Console.WriteLine($"Вторая цифра введённого числа {result}");    
Console.WriteLine($"End ");
