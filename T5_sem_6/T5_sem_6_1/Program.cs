//СЕМИНАР 6
// Задача 1: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

void recARAY1 (int[] array1)
{
int Length = array1.Length ;
    for (int z = 0; z < Length; z++) 
    {
    Console.Write("Введите любое число = ");
    array1[z] = Convert.ToInt32(Console.ReadLine());
    }
}

void printARAY1 (int[] array1)
{
int Length = array1.Length ;
    for (int z = 0; z < Length; z++) 
    {
    Console.Write($"    {array1[z]}");
    }
}

Console.Write("Введите любые числа M раз. Число М = ");
int M = Convert.ToInt32(Console.ReadLine());
int[] array1 = new int [M];

recARAY1 (array1) ;
printARAY1 (array1) ;
Console.WriteLine("  ");

int count = 0;
int z = 0;
for (z = 0; z<array1.Length ; z++)
{
    if (array1[z]>0)
    {
        count++ ;
    }
}
Console.WriteLine($"Количество чисел больше 0 =  {count}");

Console.WriteLine("  ");
Console.Write($"End");

