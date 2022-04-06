// Семинар 7 
//Задача 7_2: 
//Задача 2: Напишите программу, 
// которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.WriteLine("Зададим двумерный массив m x n . Введите число m = ") ;
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Зададим двумерный массив m x n . Введите число n = ") ;
int n = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[m,n];

// Заполняем массив с заданной размерностью случайными числами. Печатаем этот массив (для проверки)
//recARAY1(array);
// для m
int mm = array.GetLength(0); 
Console.WriteLine($"Определение размерности массива M[mxn]. m = {mm}");
// для n
int nn = array.GetLength(1); 
Console.WriteLine($"Определение размерности массива M[mxn]. n = {nn}");
for (int ii = 0; ii < mm; ii++)
{
    for (int jj = 0; jj < nn; jj++)
    {
    array[ii,jj] = new Random().NextDouble() * 100; // NextDouble() дает случайное вещественное число в диапазоне от 0 до 1
    Console.Write("{0,6:F2}", array[ii,jj]);
    }
Console.WriteLine() ;
}

// Получение позиции элемента в двумерном массиве 
Console.WriteLine("Введите запрашиваемую позицию элемента в двумерном массиве M[i; j]. Введите число i = ") ;
int i = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите запрашиваемую позицию элемента в двумерном массиве M[i; j]. Введите число j = ") ;
int j = Convert.ToInt32(Console.ReadLine());
// Возврат значения запрашиваемого элемента или же указание, что такого элемента нет
//int m = array1.GetLength(0); 
//int n = array1.GetLength(1); 
if (i < mm)
{
    if (j < nn)
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
