// See https://aka.ms/new-console-template for more information

//  Задайте значение N
//  Напишите программу, которая выведет все натуральные числа
//  в промежутке от N до 1. Выполнить с помощью рекурсии.

//------------------------------------------------------
//  объявляем переменные

int N = 0;
string end = String.Empty;

//------------------------------------------------
//  ввод числа строк, столбцов, min max для генератора чисел

int GetNumber(string text)
{
    int number = 0;
    System.Console.WriteLine(text);
    number = Convert.ToInt32(Console.ReadLine());
    return number;
}

//---------------------------------------------------------------------
//  формируем строку чисел используя рекурсию

string NumberPrint(int N)
{

    if (N >= 1)
    {
        return $"{N}  " + NumberPrint(N - 1);
    }
    else
    {
        return String.Empty;
    }
}

//-----------------------------------------------------------------------
//  основная программа

N = GetNumber("Введите натуральное число N");

Console.WriteLine("Вывод натуральных чисел от N до 1");

end = NumberPrint(N);

Console.WriteLine(end);