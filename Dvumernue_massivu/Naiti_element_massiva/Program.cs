// See https://aka.ms/new-console-template for more information

//  Напишите программу, которая на вход принимает позиции элемента
//  в двумерном массиве, и возвращает значение этого элемента
//  или же указание, что такого элемента нет

//  объявление переменных

int stroka = 0;
int stolbec = 0;
int min = 0;
int max = 0;
int indexStr = 0;
int indexColumn = 0;

//------------------------------------------------
//  ввод числа строк, столбцов, min max для генератора чисел массива

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
    int str = array.GetLength(0); // кол-во строк в массиве
    int stolb = array.GetLength(1); // кол-во столбцов в массиве

    for (int i = 0; i < str; i++)
    {
        for (int j = 0; j < stolb; j++)
        {

            Console.Write(array[i, j] + "   "); //  вывод массива в консоль
        }
        Console.WriteLine("");
    }
}

//----------------------------------------------------------------
//  заполнение массива числами

double[,] FillByRandom(int str, int stolb, int min, int max)
{
    double first = 0;   //  для генератора чисел
    double second = 0;   //  для генератора чисел

    Console.WriteLine("Заполнение массива");

    double[,] array = new double[str, stolb];   //  объявление возвращаемого массива из метода

    for (int i = 0; i < str; i++)
    {
        for (int j = 0; j < stolb; j++)
        {
            first = Math.Round((new Random().Next(min, max) + new Random().NextDouble()), 2);
            second = Math.Round((new Random().Next(min, max) + new Random().NextDouble()), 2);
            array[i, j] = Math.Round((first - second), 2);  //  заполняем массив случайными вещественными числа
        }

    }

    return array;
}

//---------------------------------------------------------------------
//  основная программа

stroka = GetNumber("Введите размер строк массива ");

stolbec = GetNumber("Введите размер столбцов массива ");

Console.WriteLine("Введите диапазон для генерации чисел массива");

min = GetNumber("Введите min число");

max = GetNumber("Введите max число");

double[,] numbers = FillByRandom(stroka, stolbec, min, max);

Console.WriteLine("");

Print(numbers); //  вывод сгенерированного массива в консоль

Console.WriteLine("Определяем число массива по индексам");

indexStr = GetNumber("Введите номер строки");

indexColumn = GetNumber("Введите номер столбца");

if ((indexStr < stroka) && (indexColumn < stolbec))
    {
        Console.WriteLine($"Элемент массива {numbers[indexStr, indexColumn]}");   
    }
    else
    {
        Console.WriteLine("Нет элемента массива с такими индексами");
    }
