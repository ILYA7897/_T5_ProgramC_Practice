// See https://aka.ms/new-console-template for more information
//Семинар 1 задача 1
// Задача 1: Напишите программу,
// которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите число №1 = ");
string strV1 = Console.ReadLine();
double value1 = double.Parse(strV1) ;
Console.WriteLine("Введите число №2 = ");
string strV2 = Console.ReadLine();
double value2 = double.Parse(strV2) ;
if (value1 > value2)
{
Console.WriteLine($"Число №1 = {value1} больше числа №2 {value2}");    
}
else
Console.WriteLine($"Число №1 = {value2} больше или равно числу №2 ");