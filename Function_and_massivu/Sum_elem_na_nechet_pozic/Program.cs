// See https://aka.ms/new-console-template for more information

//  Программа вычисления суммы нечетных элементов массива

int size = 0;
double[] numbers;

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
string Print(double[] array)
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
double [] FillByRandom(int size)
{

double [] array = new double [size];
int min=100;
int max=999;
double first = 0;
double second = 0;
for (int index=0; index < array.Length; index++)
{

first = Math.Round((new Random().Next(min,max)+new Random().NextDouble()), 2);
second = Math.Round((new Random().Next(min,max)+new Random().NextDouble()), 2);
array[index] = Math.Round((first - second), 2);

}

return array;
} 
//-----------------------------------------------------------------------

//  поиск макс и мин чисел массива и их разности
double Summa (double [] array)
{
    string result = String.Empty;
    int len = array.Length;
    int i = 1;
    double sum = 0;
    while(i < len)
    {
        result = result + array[i] + "   ";
        sum = sum + array[i];
        i = i + 2;
    }
    Console.WriteLine($"Элементы с нечетными индексами: {result}");
    return Math.Round(sum, 2);
}
//-----------------------------------------------------------------------

size = GetNumber("Введите размер массива ");

numbers = FillByRandom(size);   //  вызов метода заполнения массива числами

Console.WriteLine("Заполнение массива");  //  вывод массива в консоль
Console.WriteLine(Print(numbers));
Console.Write($"Сумма элементов с нечетными индексами = {Summa(numbers)}");        
