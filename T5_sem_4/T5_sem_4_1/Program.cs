// Задача 1: Напишите цикл, 
//который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Write("Введите А: ");
double A = Convert.ToDouble(Console.ReadLine());
double S = 1;
Console.Write("Введите B (степень числа А) = ");
int B = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < B; i++)
{
S *= A;
}
Console.WriteLine($"А в степени В = {S}");


Console.WriteLine($"End");