// See https://aka.ms/new-console-template for more information

//  Введите числа M и N
//  Напишите программу, которая найдёт сумму натуральных элементов
//  в промежутке от M до N

//---------------------------------------------------------
//  объявляем переменные

int M = 0;
int N = 0;
int rezult = 0;
//------------------------------------------------
//  ввод числа строк, столбцов, min max для генератора чисел

int GetNumber(string text)
{
    int number = 0;
    System.Console.WriteLine(text);
    number = Convert.ToInt32(Console.ReadLine());
    return number;
}

//----------------------------------------------------
//  Рекурсивный подсчет суммы чисел

// void NumberSum(int M, int N, int sum)
// {

//     sum = sum + N;
//     if (N <= M)
//     {
//         Console.Write($"Сумма натуральных чисел  =  {sum} ");
//         return;
//     }

//     NumberSum(M, N - 1, sum);

// }


// int NumberSum(int M, int N)
// {
// if (N <= M) return N;
// return N + NumberSum(M, N - 1);
// }

//----------------------------------------------------------------------
//  рекурсивный подсчет суммы чисел от М до N

int NumberSum(int M, int N)
{
    
    Console.WriteLine($":  M =   {M}    N =   {N}");
    if (M >= N)
    {
        return M+1000;
    }
    else
    {
    
   Console.WriteLine(":  sum = " + M);
return M + NumberSum(M + 1, N);
    }
    

}
//-------------------------------------------------

//-----------------------------------------------------------------------
//  основная программа

Console.WriteLine("Введите два натуральных числа M и N, так что M < N");

M = GetNumber("Введите натуральное число M");

N = GetNumber("Введите натуральное число N");

rezult = NumberSum(M, N);

Console.WriteLine($"rezult =  {rezult} ");