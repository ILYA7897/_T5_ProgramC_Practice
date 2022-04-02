// Задача 2: Напишите программу, 
// которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int Sum = 0 ;
for (int index= 0; index < (N+1); index++)
    {
        Sum = Sum + index ;
    }

Console.WriteLine($"Сумма цифр в числе = {Sum}");

Console.WriteLine($"End");