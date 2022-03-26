// See https://aka.ms/new-console-template for more information
//Семинар 1 (C#) задача 2
// Задача 2: Напишите программу,
// которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите число №1 = ");
string strV1 = Console.ReadLine();
int value1 = int.Parse(strV1) ;
Console.WriteLine("Введите число №2 = ");
string strV2 = Console.ReadLine();
int value2 = int.Parse(strV2) ;
Console.WriteLine("Введите число №3 = ");
string strV3 = Console.ReadLine();
int value3 = int.Parse(strV3) ;
int[] array = new int [3] { value1, value2, value3 };
int index = 0 ;
int max = 0 ;
max = array[index] ;
int len = array.Length;
Console.WriteLine($"Длина массива {len}");
//Console.WriteLine($"Максимальное число до цикла {max}");
for (index=0; index < len;)
{
//Console.WriteLine($"Index = {index}");
    if (array[index] > max)
    {
//    Console.WriteLine($"Index = {index}");
    max = array[index];
//    Console.WriteLine($"Максимальное число внутри if {max}");
    }
index++;
}
Console.WriteLine($"Максимальное число {max}");
Console.WriteLine($"End ");    

