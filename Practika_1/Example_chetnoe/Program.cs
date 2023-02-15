// See https://aka.ms/new-console-template for more information
Console.WriteLine("Программа проверяет является ли введенное число четным");

// из математики известно: четные числа делятся на 2 без остатка
// то есть остаток результата деления равен 0
// остаток деления нечетного числа на 2 равен 1

int chislo = 0;
int posled_cifra = 0;

int vvod_chisla ()  //  метод ввода числа с клавиатуры
{
    Console.WriteLine("Введите число = ");
    int c = Convert.ToInt32(Console.ReadLine());
    return c;
}
   
chislo = vvod_chisla (); //  ввод числа с клавиатуры

if(chislo > 10)
{ 
    posled_cifra = chislo % 10; //  выделяем последнюю цифру числа
    posled_cifra = posled_cifra % 2;    //  проверка на четность
}
else
{
    posled_cifra = chislo % 2;    //  проверка на четность
}

if (posled_cifra ==0)
{
    Console.Write("Число ");
    Console.Write(chislo); 
    Console.Write(" четное");   
}
else
{
    Console.Write("Число ");
    Console.Write(chislo); 
    Console.Write(" не четное"); 
}