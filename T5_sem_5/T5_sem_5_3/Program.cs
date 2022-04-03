// Задача 3: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

void recARAY_double  (double[] array)
{
    int Length = array.Length ;
    for (int index= 0; index < Length; index++)
    {
    array[index] = new Random().NextDouble() * 100; // NextDouble() дает случайное вещественное число в диапазоне от 0 до 1
    Console.Write("{0,6:F2}", array[index]);
    }
}

double[] aMassiv = new double [6];
recARAY_double (aMassiv) ;
Console.WriteLine() ;

Double min = aMassiv.Min(); //находим мин элемент
Console.WriteLine($"Минимальный элемент =  {min} ");

Double max = aMassiv.Max(); //находим мин элемент
Console.WriteLine($"Максимальный элемент =  {max} ");

Double result = max - min ;
Console.WriteLine($"Разница между мах и мин элементами =  {result} ");

Console.WriteLine("End");