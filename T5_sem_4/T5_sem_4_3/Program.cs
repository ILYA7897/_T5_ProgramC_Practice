// Задача 3: Напишите программу,
// которая задаёт массив из 8 элементов случайными числами и выводит их на экран.
// Оформите заполнение массива и вывод в виде функции (пригодится в следующих задачах)

void recARAY  (int[] array)
{
    int Length = array.Length ;
    for (int index= 0; index < Length; index++)
    {
    array[index] = new Random().Next(1, 10) ;
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

int[] arrayN = new int [8] ;
recARAY (arrayN) ;
PrintArray(arrayN);
Console.WriteLine() ;

Console.WriteLine($"End");