// Семинар 8 .
// Задача 3: Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.

void PrintARAY (double [ , ] array)
{
     int m = array.GetLength(0); 
//    Console.WriteLine($"Определение размерности одномерного массива с суммой строк = {m}");
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < m; j++)
        {
        Console.Write(array[i,j]);
        Console.Write("      ") ;
        }
        Console.WriteLine("      ") ;
    }
}

Console.WriteLine("Зададим две матрицы  m x m . Введите число m = ") ;
int m = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[m,m];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < m; j++)
    {
    array[i,j] = new Random().Next(0,10);
    Console.Write("{0,6:F2}", array[i,j]);
    }
Console.WriteLine() ;
}
Console.WriteLine() ;

// Определяем кол-во строк М
int M = array.GetLength(0); 

// Определяем кол-во столбцов N
int N = array.GetLength(1); 

// создаем матрицу для записи произведения первых двух матриц
double[ , ] arrayS = new double[m,m]; 
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < m; j++)
    {
    arrayS[i,j]  = array[i,j]*array[i,j]; 
    Console.WriteLine($"Полученное произведение {i}  = {arrayS[i,j]}");
    }
    
}

PrintARAY (arrayS) ;
Console.WriteLine($"        ");

Console.WriteLine($" END  ");
