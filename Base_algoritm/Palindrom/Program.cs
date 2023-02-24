// See https://aka.ms/new-console-template for more information

//  Программа проверяет является ли введенное число палиндромом


int EnterNumber ()  //  метод ввода числа с клавиатуры
{
  int number = 0;
  while (number<=10000 || number>=100000)   //  цикл если ввели меньше чем 5-х значное число
    {
    Console.WriteLine("Введите число");
    number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ввели не 5-ти значное число");
        
    } 
    return number;
}

int N = 0;
int K = 0;
int lastNumber = 0;
N = EnterNumber(); //  вызов метода ввода числа
K = N;  //  копируем N в K
int numberBack = 0;

while (N != 0)  //  переворачиваем число
{
    lastNumber = N % 10;
    N = N / 10;
    numberBack = numberBack * 10 + lastNumber;
    
}

Console.WriteLine(numberBack);  //  проверяем число палиндром или нет

if (numberBack == K)
{
    Console.WriteLine($"Число   {K} ---   палиндром");
}
else
{
    Console.WriteLine($"Число   {K} ---    не палиндром");
}
    
