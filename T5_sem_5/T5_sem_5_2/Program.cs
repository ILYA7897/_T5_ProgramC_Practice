//Задача 2: Задайте одномерный массив, 
// заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

void recARAY  (int[] array)
{
    int Length = array.Length ;
    for (int index= 0; index < Length; index++)
    {
    array[index] = new Random().Next(1, 9) ;
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
double sum = 0 ;
for (int i = 0; i < arrayN.Length; i++)
{
    if ((arrayN[i] % 2) != 0) 
    {
    count++ ;    
    sum = sum + arrayN[i] ;
    }
}
Console.WriteLine($"Количество не четных чисел в массиве = {count} их сумма = {sum}");

Console.WriteLine($"End");
