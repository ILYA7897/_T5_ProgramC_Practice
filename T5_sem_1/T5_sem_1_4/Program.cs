//Семинар 1 (C#) задача 4
// Задача 4: Напишите программу,
// которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число = ");
string strV1 = Console.ReadLine();
double N = double.Parse(strV1) ;
int x = 2 ;
for (x = 2; x < N; ) 
{
//Console.WriteLine($"Чётные числа от 1 до N {x} ");
Console.WriteLine(x);
x = x + 2 ;
}
Console.WriteLine($"End");