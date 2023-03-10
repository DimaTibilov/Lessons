// See https://aka.ms/new-console-template for more information

//  Задайте двумерный массив из целых чисел. 
//  Найдите среднее арифметическое элементов в каждом столбце

//  объявляем переменные
int stroka = 0;
int stolbec = 0;
int min = 0;
int max = 0;
string sredRezult = String.Empty;
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
//  вычисляем среднее арифметическое в каждом столбце массива

Console.WriteLine("Определяем среднее арифметическое в каждом столбце массива");

double[] SredneeArifm(int[,] array)
{
    int str = array.GetLength(0); // кол-во строк в массиве
    int stolb = array.GetLength(1); // кол-во столбцов в масиве
    int sum = 0;    //  сумма элементов одного столбца массива
    double[] rezult = new double[stolb];    //  объявляем массив возвращаемый из метода

    string result = String.Empty;

    for (int j = 0; j < stolb; j++) //  цикл 1столбец - пробегаем по строкам и тд
    {
        for (int i = 0; i < str; i++)
        {
            sum = sum + array[i, j];    //  сумма чисел столбца масива
        }
        rezult[j] = Math.Round((sum * 1.0 / str * 1.0), 2); //  заполняем массив средним арифм посчитанным по столбцам

        sum = 0;
    }
    return rezult;  //  возвращаем массив средних арифметических значений столбцов массива
}

//------------------------------------------------
//  печать массива

void Print(int[,] array)
{
    string result = String.Empty;
    int str = array.GetLength(0); // кол-во строк в массиве
    int stolb = array.GetLength(1); // ко-во столбцов в массиве

    for (int i = 0; i < str; i++)
    {
        for (int j = 0; j < stolb; j++)
        {

            Console.Write(array[i, j] + "   "); //  выводим в консоль массив
        }
        Console.WriteLine("");
    }
}
//-------------------------------------------------
//  вывод результата в консоль

string PrintSredZnach(double[] array)
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
//  заполнение массива числами

int[,] FillByRandom(int str, int stolb, int min, int max)
{
    int number = 0; //  для хранения случайных чисел
    Console.WriteLine("заполнение массива");
    int[,] array = new int[str, stolb]; //  объявляем массив возвращаемый из метода

    for (int i = 0; i < str; i++)
    {
        for (int j = 0; j < stolb; j++)
        {
            number = new Random().Next(min, max);   //  получаем случайное целое число 
            array[i, j] = number;   //  заполняем массив случайными целыми числами
        }
    }

    return array;
}

//-----------------------------------------------------------------------
//  основная программа

stroka = GetNumber("Введите размер строк массива ");

stolbec = GetNumber("Введите размер столбцов массива ");

Console.WriteLine("Введите диапазон для генератора чисел массива");

min = GetNumber("Введите min число");

max = GetNumber("Введите max число");

Console.WriteLine("");

int[,] numbers = FillByRandom(stroka, stolbec, min, max);

Print(numbers);

double[] sredInStolb = SredneeArifm(numbers);

sredRezult = PrintSredZnach(sredInStolb);

Console.WriteLine("Среднее арифметическое по столцам чисел массива");

Console.WriteLine(sredRezult);