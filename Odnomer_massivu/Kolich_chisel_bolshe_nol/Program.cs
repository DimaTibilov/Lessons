// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// See https://aka.ms/new-console-template for more information

//  Программа вычисления разницы между максимальным и минимальным элементами массива

int size = 0;
int[] numbers;

//------------------------------------------------
//  ввод числа элементов массива
int GetNumber(string text)
{
    int num = 0;
    System.Console.WriteLine(text);
    num = Convert.ToInt32(Console.ReadLine());
    return num;
}
//------------------------------------------------

// печать массива
string Print(int[] array)
{
    string result = String.Empty;
    int len = array.Length;
    int index = 0;
    while (index < len)
    {
        result = result + array[index] + "   ";
        index++;
    }

    return result;

}
//------------------------------------------------

//  заполнение массива числами
int[] FillByUser(int size)
{

    int[] array = new int[size];
    int num = 0;

    for (int index = 0; index < array.Length; index++)
    {
        System.Console.WriteLine($"Введите {size} число любого знака");
        num = Convert.ToInt32(Console.ReadLine());
        array[index] = num;

    }

    return array;
}
//-----------------------------------------------------------------------

//  поиск макс и мин чисел массива и их разности
int BolsheNol(int[] array)
{

    int len = array.Length;
    int index = 0;
    int rez = 0;

    while (index < len)
    {
        if (array[index] > 0)
        {
            rez = rez + 1;
        }
        index = index + 1;

    }
    return rez;
}
//------------------------------------------------------------------

size = GetNumber("Введите размер массива ");

Console.WriteLine("Заполнение массива");  //  вывод массива в консоль

numbers = FillByUser(size);   //  вызов метода заполнения массива числами

Console.WriteLine("массив заполнен");

Console.WriteLine(Print(numbers));
Console.WriteLine("массив распечатан");
//  вывод в консоль разницы между макс и мин элементами массива
Console.WriteLine($"Кол-во элементов массива > 0 :   {BolsheNol(numbers)}");
// Console.WriteLine($"Кол-во элементов массива > 0 :");
// Console.WriteLine(BolsheNol(numbers));
