// See https://aka.ms/new-console-template for more information

//  Программа вычисления расстояния между двумя точками в 3d пространстве

double distance = 0.0;  //  переменная хранящая расстояние

int[] EnterNumber ()  //  метод ввода координат точки с клавиатуры
{
    int[] koordDot = new int[3];

  
    Console.WriteLine("Введите координаты X точки");
    koordDot[0] = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine("Введите координаты Y точки");
    koordDot[1] = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine("Введите координаты Z точки");
    koordDot[2] = Convert.ToInt32(Console.ReadLine());
    
    return koordDot;

}

int[] koordDotFirst = EnterNumber(); //  вызов метода ввода координат 1ой точки
int[] koordDotSecond = EnterNumber(); //  вызов метода ввода координат 2ой точки

Console.WriteLine($"X1 = {koordDotFirst[0]}, Y1 =  {koordDotFirst[1]}, Z1 = {koordDotFirst[2]}");

Console.WriteLine($"X2 = {koordDotSecond[0]}, Y2 =  {koordDotSecond[1]}, Z2 = {koordDotSecond[2]}");

//вычисление расстояния между двумя точками в 3d пространстве

distance = Math.Sqrt(Math.Pow(koordDotSecond[0] - koordDotFirst[0], 2) +
                 Math.Pow(koordDotSecond[1] - koordDotFirst[1], 2) +
                 Math.Pow(koordDotSecond[2] - koordDotFirst[2], 2) );


Console.Write("Расстояние между 2-мя точками в 3D пространстве = ");
Console.Write(distance);