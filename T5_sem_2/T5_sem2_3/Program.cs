//Семинар 2 задача 3
// Задача 3: Напишите программу,
// которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Random rnd = new Random();
int value = rnd.Next(1,999);
//int value = 23;
Console.WriteLine($"Получено случайное число {value}");   
string message = value.ToString() ; // получаем string
int len = message.Length ;
Console.WriteLine($"Количество цифр в случайном числе {len}"); 
if (len == 3)
{
char CharS3 = message[2]; // символ 'третье число'
Console.WriteLine($"Третья цифра заданного числа {CharS3}") ;   //выводим символ 'третье число'
}
else
{
Console.WriteLine($"Третьей цифры нет. Число {value}") ;   //выводим Третьей цифры нет.
} 
Console.WriteLine($"End ");