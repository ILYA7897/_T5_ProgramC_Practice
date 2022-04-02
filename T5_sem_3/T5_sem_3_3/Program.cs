//Задача 3: Напишите программу, 
//которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите ЧИСЛО N =");
string strN = Console.ReadLine();
int N = int.Parse(strN) ;

for (int i=1; i<(N+1); i++)
{
int result = i*i*i ;
Console.WriteLine(result);
}
Console.WriteLine($"End ");

