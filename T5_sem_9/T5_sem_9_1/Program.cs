//Семинар 9
//Задача 9_1: Задайте значения M и N. Напишите программу, 
// которая выведет все чётные натуральные числа в промежутке от M до N используя рекурсию.
//Пример:
//M = 1; N = 5 -> "2, 4"
//M = 4; N = 8 -> "4, 6, 8"
void print1 (int N, int M)
{
    for (int x = M; x <= N; x++)
    {
        if (x % 2 == 0) 
        {
        Console.Write(x);
        Console.Write("  ");
        }
    }
}

Console.Write("Введите первое  число M  = ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите первое  число N  = ");
int N = Convert.ToInt32(Console.ReadLine());

print1 (N,M) ;

Console.WriteLine("  ");
Console.Write($"End");

