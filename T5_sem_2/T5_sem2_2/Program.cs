//Семинар 2 задача 2
// Задача 2: Напишите программу,
// которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
Random rnd = new Random();
int value = rnd.Next(1,999);
//int value = 563;
Console.WriteLine($"Получено случайное число {value}");   
int s1 = value/100 ;
int s2 = (value%100)/10 ;
int s3 = value%10 ;
int[] array = { s1, s2, s3 };
Console.WriteLine($"Получили массив int {array[0]}   {array[1]}   {array[2]}");
Console.WriteLine($"Элементы массива int без 2 элемента {array[0]}  {array[2]}");
string val = value.ToString() ;
Console.WriteLine($"В строку переведено {val}");   
string strS1 = s1.ToString() ;
string strS2 = s2.ToString() ;
string strS3 = s3.ToString() ;
string [] arrayStr = { strS1, strS2, strS3 };
string sumStr = strS1 + strS3 ;
int result = int.Parse(sumStr);
Console.WriteLine($"Полученное число без второй цифры (string -> int) {sumStr}");
Console.WriteLine($"End ");
   
