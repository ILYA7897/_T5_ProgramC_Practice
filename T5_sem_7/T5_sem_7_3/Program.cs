// Семинар 7 
//Задача 7_3: Задача 3: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
//элементов в каждом столбце.

// Функция recARAY1 заполняет массив случайными числами и печатает его для проверки.
void recARAY1 (int [,] array)
{
     int m = array.GetLength(0); 
    Console.WriteLine($"Определение размерности массива M[mxn]. m = {m}");
    int n = array.GetLength(1); 
    Console.WriteLine($"Определение размерности массива M[mxn]. n = {n}");
    for (int a = 0; a < m; a++)
    {
        for (int b = 0; b < n; b++)
        {
        //array[a,b] = new Random().NextDouble() * 100; // NextDouble() дает случайное вещественное число в диапазоне от 0 до 1
        //Console.Write("{0,6:F2}", array[a,b]);
        array[a,b] = new Random().Next(-10,10);
        Console.Write(array[a,b]);
        Console.Write("      ") ;
        }
    Console.WriteLine() ;
    }
}

// Создаем двумерный массив
Console.WriteLine("Зададим двумерный массив 2 x 2 ") ;
//int m = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Зададим двумерный массив m x n . Введите число n = ") ;
//int n = Convert.ToInt32(Console.ReadLine());
int [,] array = new int [2,2];

// Вызываем функцию для заполнения массива заданной размерности случайными числами. 
// В функции прописана печать массива для проверки.
recARAY1(array);

// Находим среднее арифметическое элементов в каждом столбце.
int M = array.GetLength(0); 
Console.WriteLine($"Определение размерности массива M[mxn]. m = {M}");
int N = array.GetLength(1); 
Console.WriteLine($"Определение размерности массива M[mxn]. n = {N}");

double S0 = (array[0,0]+array[1,0])/2 ;
string S0str = S0.ToString()  ;

double S1 = (array[0,1]+array[1,1])/2 ;
string S1str = S1.ToString()  ;

Console.WriteLine($"Среднее арифметическое столбца [0,j]  = {S0str}");
Console.WriteLine($"Среднее арифметическое столбца [1,j]  = {S1str}");

Console.WriteLine($"End ");