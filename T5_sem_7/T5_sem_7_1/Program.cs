// Семинар 7 
//Задача 7_1: Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

Console.WriteLine("Зададим двумерный массив m x n . Введите число m = ") ;
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Зададим двумерный массив m x n . Введите число n = ") ;
int n = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[m,n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
    array[i,j] = new Random().NextDouble() * 100; // NextDouble() дает случайное вещественное число в диапазоне от 0 до 1
    Console.Write("{0,6:F2}", array[i,j]);
    }
Console.WriteLine() ;
}
Console.WriteLine() ;
Console.WriteLine("End") ;
