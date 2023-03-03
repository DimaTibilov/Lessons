// See https://aka.ms/new-console-template for more information

//------------------------------------------------
//  ввод числа строк элементов массива
int GetNumberStroka(string text)
{
    int num = 0;
    System.Console.WriteLine(text);
    num = Convert.ToInt32(Console.ReadLine());
    return num;
}
//------------------------------------------------
//------------------------------------------------
//  ввод числа столбцов элементов массива 
int GetNumberStolbec(string text)
{
    int num = 0;
    System.Console.WriteLine(text);
    num = Convert.ToInt32(Console.ReadLine());
    return num;
}
//------------------------------------------------

// 142403
// // печать массива
// string Print(double[] array)
// {
//   string result = String.Empty;
//   int len = array.Length;
//   int index = 0;
//   while (index < len)
//   {
//     result = result + " " + array[index];
//     index++;
//   }
//   return result;
// }
// //------------------------------------------------




//  заполнение массива числами
long [,] FillByRandom(int str, int stolb)
{
    Console.WriteLine("заполнение массива");
    //int[,] arr1 = new int[4, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
    long[,] array = new long[str, stolb];
    
    
 int min=100;
 int max=999;
 long number = 0;
 
 
// int r=matrix.GetLength(0); // строки
// int c=matrix.GetLength(1); // столбцы

for (int i=0; i < str; i++)
{
    for (int j = 0; j < stolb; j++)
    {
        number = new Random().Next(min,max);    
        array[i, j] = number;
        Console.Write(array[i, j]+ " ");
    }
        Console.WriteLine("");
}

 return array;
} 
//-----------------------------------------------------------------------


int stroka = 0;
stroka = GetNumberStroka("Введите размер строк массива ");

int stolbec = 0;
stolbec = GetNumberStolbec("Введите размер столбцов массива ");

long[,] numbers = FillByRandom(stroka, stolbec);














//  double DiffMaxMin (double [] array)
// {
//     double different = 0;
//     int len = array.Length;
//     int index = 0;
//     double max = 0;
//     double min = 999.99;

//   while (index < len)
//     {
//     if (array[index] > max)
//         {
//             max = array[index];
//         } 
        
//     if (array[index] < min)
//         {
//             min = array[index];
//         }    
//         index = index + 1;
//     }
//     different = max - min;

// return different;
    
// }

