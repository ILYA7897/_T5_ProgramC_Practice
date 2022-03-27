//Семинар 2 задача 4
// Задача 3: Напишите программу,
// которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите цифру, обозначающую день недели = ");
string strV1 = Console.ReadLine();
int value1 = int.Parse(strV1) ;
//if (value1 == 6 && value1 == 7)
if (value1 == 6)
{
Console.WriteLine($"Введенная цифра соответствует выходным {value1}") ;   
}
else
{
    if (value1 == 7)
    {
    Console.WriteLine($"Введенная цифра соответствует выходным {value1}") ;   
    }
    else 
    {
    Console.WriteLine($"Введенная цифра не соответствует выходным {value1}") ;  
    }
}
Console.WriteLine($"End ");
