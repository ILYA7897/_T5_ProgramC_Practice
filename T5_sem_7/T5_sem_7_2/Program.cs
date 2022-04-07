// Семинар 7 
//Задача 7_2: Напишите программу, 
// которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Функция recARAY1 заполняет массив случайными числами и печатает его для проверки.
void recARAY1 (double[,] array)
{
    int m = array.GetLength(0); 
    Console.WriteLine($"Определение размерности массива M[mxn]. m = {m}");
    int n = array.GetLength(1); 
    Console.WriteLine($"Определение размерности массива M[mxn]. n = {n}");
    for (int a = 0; a < m; a++)
    {
        for (int b = 0; b < n; b++)
        {
        array[a,b] = new Random().NextDouble() * 100; // NextDouble() дает случайное вещественное число в диапазоне от 0 до 1
        Console.Write("{0,6:F2}", array[a,b]);
        }
    Console.WriteLine() ;
    }
}
// Создаем двумерный массив
Console.WriteLine("Зададим двумерный массив m x n . Введите число m = ") ;
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Зададим двумерный массив m x n . Введите число n = ") ;
int n = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[m,n];

// Вызываем функцию для заполнения массива заданной размерности случайными числами. 
// В функции прописана печать массива для проверки.
recARAY1(array);

// Получение позиции элемента в двумерном массиве 
Console.WriteLine("Введите запрашиваемую позицию элемента в двумерном массиве M[i; j] (ПОЗИЦИЯ НАЧИНАЕТСЯ С 0 ЗНАЧЕНИЯ). Введите число i = ") ;
int i = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите запрашиваемую позицию элемента в двумерном массиве M[i; j].(ПОЗИЦИЯ НАЧИНАЕТСЯ С 0 ЗНАЧЕНИЯ). Введите число j = ") ;
int j = Convert.ToInt32(Console.ReadLine());
// Возврат значения запрашиваемого элемента или же указание, что такого элемента нет
int s = array.GetLength(0); 
int k = array.GetLength(1); 
if (i < s)
{
    if (j < k)
    {
    Console.Write("{0,6:F2}", array[i,j]);
    Console.WriteLine("  ");        
    }
    else
    {
    Console.WriteLine($"На запрашиваемой позиции [{i} x {j}] элемента нет");        
    } 
}
else
{
Console.WriteLine($"На запрашиваемой позиции [{i} x {j}] элемента нет");            
}

Console.WriteLine("End") ;
