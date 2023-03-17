// See https://aka.ms/new-console-template for more information

//  Задайте прямоугольный двумерный массив 
//  Напишите программу, которая будет находить строку 
//  с наименьшей суммой элементов

//  объявляем переменные

int row = 0;    //  кол-во строк в массиве
int column = 0; //  кол-во столбцов в массиве
int min = 0;    //  для генератора чисел min и max - диапазон генерации чисел
int max = 0;
string average = String.Empty;  //  из чисел одномерного массива 
                                //  формируем строку и выводим в консоль 

//------------------------------------------------
//  ввод числа строк, столбцов, min max для генератора чисел

int GetNumber(string text)
{
    int number = 0;
    System.Console.WriteLine(text);
    number = Convert.ToInt32(Console.ReadLine());
    return number;
}

//------------------------------------------------
//  вычисляем среднее арифметическое в каждом столбце массива

double[] FindAverageInRow(int[,] array)
{
    int row = array.GetLength(0); // кол-во строк в массиве
    int column = array.GetLength(1); // кол-во столбцов в масиве
    double summaInRow = 0;    //  сумма элементов одной строки массива
    double[] averageForEverRow = new double[column];    //  объявляем массив возвращаемый из метода

    for (int i = 0; i < row; i++) //  цикл 1строка - пробегаем по сттолбцам и тд
    {
        for (int j = 0; j < column; j++)
        {
            summaInRow = summaInRow + array[i, j];    //  сумма чисел строки массива
        }
        averageForEverRow[i] = Math.Round((summaInRow / column), 2); //  заполняем массив средним арифм посчитанным по строкам

        summaInRow = 0;
    }
    return averageForEverRow;  //  возвращаем массив средних арифметических значений столбцов массива
}

//------------------------------------------------
//  находим минимальное арифмет среднее из арифмет средних 
//  вычисленных по каждой строке массива

double MinAverageFromAllRows (double[] array)
{
    int number = array.Length; // кол-во элементов массива
    double minAverage = array[0];

    for (int i = 0; i < number; i++) //  цикл пробегаем по элементам массива
    {
        if (minAverage > array[i])  //  если есть число массива меньше чем найденное минимальное
        {                           //  то присваиваем его в minAverage
            minAverage = array[i];  
        } 
    }
        
    return minAverage;  //  возвращаем min из средних арифметических значений строк массива
}

//------------------------------------------------
//  вывод двумерного массива в консоль

void PrintArrayTwoDim(int[,] array)
{
    int row = array.GetLength(0); // кол-во строк в массиве
    int column = array.GetLength(1); // ко-во столбцов в массиве

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            Console.Write(array[i, j] + "   "); //  выводим в консоль массив
        }
        Console.WriteLine();
    }
}

//-------------------------------------------------
//  вывод одномерного массива в консоль

string PrintArrayOneDim(double[] array)
{
    string result = String.Empty;
    int length = array.Length;

    for (int i = 0; i < length; i++)
    {
        result = (result + array[i] + "   ");   //  формируем строку с результатами средних значений

    }
    return result;
}

//----------------------------------------------------
//  заполнение двумерного массива целыми числами

int[,] FillByRandom(int row, int column, int min, int max)
{
    int number = 0; //  для хранения случайных чисел
    int[,] array = new int[row, column]; //  объявляем массив возвращаемый из метода

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            number = new Random().Next(min, max);   //  получаем случайное целое число 
            array[i, j] = number;   //  заполняем массив случайными целыми числами
        }
    }

    return array;
}

//-----------------------------------------------------------------------
//  основная программа

row = GetNumber("Введите размер строк массива ");

column = GetNumber("Введите размер столбцов массива ");

Console.WriteLine("Введите диапазон для генератора чисел массива");

min = GetNumber("Введите min число");

max = GetNumber("Введите max число");

int[,] numbers = FillByRandom(row, column, min, max);

Console.WriteLine("Заполнение массива");

PrintArrayTwoDim(numbers);

double[] averageInRows = FindAverageInRow(numbers);

average = PrintArrayOneDim(averageInRows);

Console.WriteLine("Определяем среднее арифметическое в каждой строке массива");

Console.WriteLine(average);

double minAverageFromAllRows = MinAverageFromAllRows (averageInRows);

Console.WriteLine("Минимальное среднее арифметическое из всех строк массива");

Console.WriteLine(minAverageFromAllRows);