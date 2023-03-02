// See https://aka.ms/new-console-template for more information

//  Программа вычисления разницы между максимальным и минимальным элементами массива

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

for (int index=0; index < array.Length; index++)
{

first = Math.Round((new Random().Next(min,max)+new Random().NextDouble()), 2);

array[index] = first;

}

return array;
} 
//-----------------------------------------------------------------------

//  поиск макс и мин чисел массива и их разности
double DiffMaxMin (double [] array)
{
    double different = 0;
    int len = array.Length;
    int index = 0;
    double max = 0;
    double min = 999.99;

  while (index < len)
    {
    if (array[index] > max)
        {
            max = array[index];
        } 
        
    if (array[index] < min)
        {
            min = array[index];
        }    
        index = index + 1;
    }
    different = Math.Round((max - min), 2);

return different;
    
}
//-----------------------------------------------------------------------

size = GetNumber("Введите размер массива ");

numbers = FillByRandom(size);   //  вызов метода заполнения массива числами

Console.WriteLine("Заполнение массива");  //  вывод массива в консоль
Console.WriteLine(Print(numbers));
 //  вывод в консоль разницы между макс и мин элементами массива
Console.WriteLine($"Разница между max и min элементами массива:   {DiffMaxMin(numbers)}");

