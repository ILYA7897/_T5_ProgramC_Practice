// Семинар  8
// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.

void PrintARAY (double [] array)
{
     int m = array.GetLength(0); 
//    Console.WriteLine($"Определение размерности одномерного массива с суммой строк = {m}");
    for (int a = 0; a < m; a++)
    {
        Console.Write(array[a]);
        Console.Write("      ") ;
    }
}


Console.WriteLine("Зададим двумерный массив m x n . Введите число m = ") ;
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Зададим двумерный массив m x n . Введите число n = ") ;
int n = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[m,n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
    array[i,j] = new Random().Next(0,10);
    Console.Write("{0,6:F2}", array[i,j]);
    }
Console.WriteLine() ;
}
Console.WriteLine() ;

// Определяем кол-во строк М
int M = array.GetLength(0); 
// проверка присваемого числа 
//Console.WriteLine($"Определение размерности массива M[mxn]. m = {M}");

// Определяем кол-во столбцов N
int N = array.GetLength(1); 
// проверка присваемого числа 
//Console.WriteLine($"Определение размерности массива M[mxn]. n = {N}");

double[] arrayS = new double[M]; // создаем массив для записи суммы строк
for (int i = 0; i < M; i++)
{
    for (int j = 0; j < N; j++)
    {
    arrayS[i]  = arrayS[i] + array[i,j]; 
    }
    Console.WriteLine($"Сумма  {i}  строки   = {arrayS[i]}");
}

PrintARAY (arrayS) ;
Console.WriteLine($"        ");
Console.WriteLine($" Длина массива суммы строк {arrayS.Length}       ");

//double Min( double[] arrayS1)
//{
//    for (int d = 0; d < arrayS1.Length ; d++)
//    {
//    double result = arrayS1[0] ;
//    if ( arrayS1[d] < result ) result = arrayS1[d] ;
//    return result ;
//    }
//}

//Min(arrayS) ;
double MIN2 = arrayS.Min() ;

Console.WriteLine($"Min значение суммы строк =  {MIN2} ");

double min3 = arrayS[0] ; 
//int z = 0;
int x = 0 ;
for (int z = 0; z < arrayS.Length; z++)
{
    if (arrayS[z] < min3)
    {
    min3 = arrayS[z];
    x = z;
    }
}

Console.WriteLine($"Минимальное значение массива суммы строк {MIN2} Его индекс = {x} ");

Console.WriteLine($"Ответ: Строка начального массива m x n с min суммой элементов = {MIN2} имеет индекс [{x} ] ");

Console.WriteLine($"End ");

