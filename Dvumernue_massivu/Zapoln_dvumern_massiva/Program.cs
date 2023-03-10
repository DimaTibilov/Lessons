// See https://aka.ms/new-console-template for more information

//  Задайте двумерный массив размером m×n, 
//  заполненный случайными вещественными числами

//  объявление переменных

int stroka = 0;
int stolbec = 0;
int min = 0;
int max = 0;

//------------------------------------------------
//  ввод числа строк, столбцов, min max для генератора чисел

int GetNumber(string text)
{
    int num = 0;
    System.Console.WriteLine(text);
    num = Convert.ToInt32(Console.ReadLine());
    return num;
}

//------------------------------------------------
//  печать массива

void Print(double[,] array)
{
    string result = String.Empty;
    int str = array.GetLength(0); // строки
    int stolb = array.GetLength(1); // столбцы

for (int i=0; i < str; i++)
{
    for (int j = 0; j < stolb; j++)
    {
        
        Console.Write(array[i, j]+ "   ");
    }
        Console.WriteLine("");
}

}

//------------------------------------------------
//  заполнение массива числами
double [,] FillByRandom(int str, int stolb, int min, int max)
{
    double first = 0;
    double second = 0;
    Console.WriteLine("Заполнение массива");
    double [,] array = new double[str, stolb];
 
for (int i=0; i < str; i++)
{
    for (int j = 0; j < stolb; j++)
    {
        first = Math.Round((new Random().Next(min,max)+new Random().NextDouble()), 2);
        second = Math.Round((new Random().Next(min,max)+new Random().NextDouble()), 2);
        array[i, j] = Math.Round((first - second), 2);
    }
}

 return array;
} 
//-----------------------------------------------------------------------
//  основная программа

stroka = GetNumber("Введите размер строк массива ");

stolbec = GetNumber("Введите размер столбцов массива ");

Console.WriteLine("Введите диапазон для генератора чисел");

min = GetNumber("Введите min число");

max = GetNumber("Введите max число");

double[,] numbers = FillByRandom(stroka, stolbec, min, max);

Console.WriteLine("");

Print(numbers); //  вывод массива в консоль
