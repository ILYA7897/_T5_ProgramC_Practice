// Задача 1: Напишите программу,
// которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//string strx = string.Empty ;
//string strx01 = string.Empty ;
//string strx34 = string.Empty ;
for (int x=10000; x <100000; x++)
{
   string strx = x.ToString() ; 
   char strx0 = strx[0];
   char strx1 = strx[1];
   char strx3 = strx[3];
   char strx4 = strx[4];

   char[] chars01 = {strx0, strx1};
   char[] chars34 = {strx3, strx4};
   
   string strx01 = new string(chars01);
   string strx34 = new string(chars34);

    if (strx01 == strx34)
    {
    Console.WriteLine($"Число {strx} является палиндором поскольку {strx01} равно {strx34} ");
    }
}
Console.WriteLine($"END");
