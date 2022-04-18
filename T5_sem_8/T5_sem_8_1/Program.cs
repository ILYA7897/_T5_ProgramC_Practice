// Семинар  8
// Задача 8_1: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

void PrintARAY (double [ , ] array)
{
     int m = array.GetLength(0); 
//    Console.WriteLine($"Определение размерности одномерного массива с суммой строк = {m}");
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < m; j++)
        {
        Console.Write(array[i,j]);
        Console.Write("      ") ;
        }
        Console.WriteLine("      ") ;
    }
}

static double[,] SortUbiv(double[,] x)
{
    double minVal = x[0, 0];
    for (int i = 0; i < x.GetLength(0); i++)// перечисление строк
    {
        for (int j = 0; j < x.GetLength(1); j++)// перечисление символов(столбцов)
        {
            for (int q = i; q < x.GetLength(0); q++)//перечесления строк для проверки
            {
                for (int w = (q == i) ? j : 0; w < x.GetLength(1); w++)   // перечесление смиволов для проверки (исключаем проверенные и заменннеые символы)
                {
 
                    if (x[i, j] < x[q, w])
                    {
                        minVal = x[q, w];
                        x[q, w] = x[i, j];
                        x[i, j] = minVal;
                    }
 
                }
            }
 
        }
    }
            
    return x;
}
        
Console.WriteLine("Зададим двумерный массив m x n . Введите число m = ") ;
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Зададим двумерный массив m x n . Введите число n = ") ;
int n = Convert.ToInt32(Console.ReadLine());
double[,] array1 = new double[m,n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
    array1[i,j] = new Random().Next(0,10);
 //   Console.Write("{0,6:F2}", array1[i,j]);
    }
//Console.WriteLine() ;
}
Console.WriteLine() ;

PrintARAY(array1) ;
Console.WriteLine() ;

array1=SortUbiv(array1);

PrintARAY(array1) ;

Console.WriteLine($"End ");

