//Задача 2: Напишите программу, которая
// принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

int distance (int[] array)
{
    int index = 0 ;
    int result = 0 ;
    result = (array[3] - array[0]) * (array[3] - array[0]) +
             (array[4] - array[1]) * (array[4] - array[1]) +     
             (array[5] - array[2]) * (array[5] - array[2])    ;
    return result ;
}

Console.Write("Введите координаты точки №1 х1 =");
string strx1 = Console.ReadLine();
Console.Write("Введите координаты точки №1 y1 =");
string stry1 = Console.ReadLine();
Console.Write("Введите координаты точки №1 z1 =");
string strz1 = Console.ReadLine();

int x1 = int.Parse(strx1) ;
int y1 = int.Parse(stry1) ;
int z1 = int.Parse(strz1) ;

Console.WriteLine($"Координаты точки №1 {x1} {y1}  {z1})");
//Console.WriteLine($"Координаты точки №1 ({arrayA()})");

Console.Write("Введите координаты точки №2 х2 =");
string strx2 = Console.ReadLine();
Console.Write("Введите координаты точки №1 y2 =");
string stry2 = Console.ReadLine();
Console.Write("Введите координаты точки №1 z2 =");
string strz2 = Console.ReadLine();

int x2 = int.Parse(strx2) ;
int y2 = int.Parse(stry2) ;
int z2 = int.Parse(strz2) ;

int [] arrayA = new int [6] {x1, y1, z1, x2, y2, z2} ;

Console.WriteLine($"Координаты точки №2 ({x2}  {y2}  {z2})");

int Res = distance(arrayA) ;
var dist = Math.Sqrt(Res);

Console.WriteLine($"Растояние = от точки №1 до точки №2 =  {dist} ") ;

Console.WriteLine($"End ");
