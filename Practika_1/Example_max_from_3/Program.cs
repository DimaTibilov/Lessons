// See https://aka.ms/new-console-template for more information
Console.WriteLine("Программа вычисляет максимальное из 3х введенных чисел");

int first = 0;
int second = 0;
int third = 0;
int max = 0;
// int a = 0;
// int b = 0;

int vvod_chisla ()  //  метод ввода числа с клавиатуры
{
    Console.WriteLine("Введите число = ");
    int c = Convert.ToInt32(Console.ReadLine());
    return c;
}


int maximum (int a, int b)  //  поиск максимального из 2 чисел
{
    
    if (a > b)
    {
        return a;
    }
    else
    {
        return b;    
    }    
    
}


first = vvod_chisla (); //  ввод чисел с клавиатуры
second = vvod_chisla ();
third = vvod_chisla ();

max = maximum (maximum (first, second), third); //  вызов метода, поиск максимального из 3 чисел

Console.Write("Максимальное число = ");
Console.Write(max);