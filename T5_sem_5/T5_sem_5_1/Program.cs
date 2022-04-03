//Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

void recARAY  (int[] array)
{
    int Length = array.Length ;
    for (int index= 0; index < Length; index++)
    {
    array[index] = new Random().Next(100, 999) ;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position =0;
    while (position < count)
    {
        Console.Write($"  {col[position]}") ;
        position++ ;
    }
}

int[] arrayN = new int [10] ;
recARAY (arrayN) ;
PrintArray(arrayN);
Console.WriteLine() ;

int count = 0;
for (int i = 0; i < arrayN.Length; i++)
{
    if ((arrayN[i] % 2) == 0) count++ ;
}
Console.WriteLine($"Количество четных чисел в массиве = {count}");

Console.WriteLine($"End");
