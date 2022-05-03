/* Семинар 11. от простого к практике. Домашние задание №11
Задача 1: Определите, является ли число степенью двойки:
N = 16 -> "Является степень двойки"
N = 12 -> “Не является степенью двойки” */

void NumberisPowerOf2(int x)
{
    if ((x != 0) && ((x & (x - 1)) == 0))
    {
    Console.WriteLine($"N - Является степенью двойки") ;
    }
    else Console.WriteLine($"N - Не является степенью двойки") ;
}
Console.Write("Введите N = ");
var x = int.Parse(Console.ReadLine());
NumberisPowerOf2(x) ;
Console.WriteLine($"End") ;

 