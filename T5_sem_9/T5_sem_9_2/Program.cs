//Семинар 9
//Задача 9_2: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N используя рекурсию.
//M = 1; N = 15 -> 120
//M = 4; N = 8 -> 30

void print1 (int N, int M)
{
    int sum = 0 ;
    for (int x = M; x <= N; x++)
    {
        sum = sum + x ;                
    }
    Console.Write(sum);  
}

Console.Write("Введите первое  число M  = ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите первое  число N  = ");
int N = Convert.ToInt32(Console.ReadLine());

print1 (N,M) ;

Console.WriteLine("  ");
Console.Write($"End");

