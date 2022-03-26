//Семинар 1 (C#) задача 3
// Задача 3: Напишите программу,
// которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Введите число = ");
string strV1 = Console.ReadLine();
double value1 = double.Parse(strV1) ;
double z = value1%2 ;
Console.WriteLine($"Остаток деления на 2 =  {z}");
if (z == 0)
{
Console.WriteLine($"Число {value1} является чётным");
}
else
{
Console.WriteLine($"Число {value1} не является чётным");
}
Console.WriteLine($"End");

