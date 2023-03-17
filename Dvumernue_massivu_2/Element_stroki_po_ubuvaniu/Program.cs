// See https://aka.ms/new-console-template for more information

//  Задайте двумерный массив из целых чисел 
//  Напишите программу, которая упорядочит по убыванию 
//  элементы каждой строки двумерного массива
//-------------------------------------------------
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

//-----------------------------------------------------------------------
//  поиск max и min чисел в каждой строке массива 

int[,] MinMaxInOneRow(int[,] array)
{

    int row = array.GetLength(0); // кол-во строк в массиве
    int column = array.GetLength(1); // ко-во столбцов в массиве
    int[,] minMax = new int[row, 2];    //  выходной массив max и min значений строк

    for (int i = 0; i < row; i++)   //  цикл на кол-во строк массива
    {
        int max = array[i, 0];  //  присваиваем max и min значения 
        int min = array[i, 0];  //  как первые элементы массива для новой i строки

        for (int j = 0; j < column; j++)
        {
            if (array[i, j] > max)
            {
                max = array[i, j];  //  поиск max элемента
            }
            else if (array[i, j] < min)
            {
                min = array[i, j];  //  поиск min элемента
            }

        }
        //  заполняем выходной массив
        minMax[i, 0] = min; 
        minMax[i, 1] = max;

    }
    return minMax;

}

//-----------------------------------------------------------------------
//   сортировка массива

int[,] SortMassiv(int[,] array, int[,] minMax)
{
    int row = array.GetLength(0); // кол-во строк в массиве
    int column = array.GetLength(1); // ко-во столбцов в массиве
    int min = 0;
    int max = 0;

    for (int j = 0; j < row; j++)   //  сортируем в каждой строке
    {
        min = minMax[j, 0]; //  присваиваем мин значение для j-ой строки 
        max = minMax[j, 1]; //  присваиваем макс значение для j-ой строки

        int t = 0;

        int[] count = new int[max - min + 1];
        int z = 0;

        for (int i = 0; i < count.Length; i++)
        {
            count[i] = 0;
            t++;
        }
        for (int i = 0; i < column; i++)
        {
            count[array[j, i] - min]++;
            t++;
        }

        for (int i = max; i >= min; i--)
        {
            while (count[i - min]-- > 0)
            {
                array[j, z] = i;
                z++;
                t++;
            }
        }

        Console.WriteLine($"Кол-во итераций для сортировки массива в {j + 1} : " + t);
    }
    return array;
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

//----------------------------------------------------
//  заполнение двумерного массива целыми числами

int[,] FillByRandom(int row, int column, int min, int max)
{
    Random rnd = new Random();
    int number = 0; //  для хранения случайных чисел
    int[,] array = new int[row, column]; //  объявляем массив возвращаемый из метода

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            number = rnd.Next(min, max);   //  получаем случайное целое число 
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

Console.WriteLine("Заполнение массива");

int[,] numbers = FillByRandom(row, column, min, max);

PrintArrayTwoDim(numbers);

Console.WriteLine("Поиск min и max элементов в каждой строке массива");

int[,] minMax = MinMaxInOneRow(numbers);

PrintArrayTwoDim(minMax);

int[,] backMassiv = SortMassiv(numbers, minMax);

Console.WriteLine("Сортировка каждой строки массива по убыванию чисел");

Console.WriteLine("Алгоритм - обобщение на произвольный целочисленный диапазон");

PrintArrayTwoDim(backMassiv);