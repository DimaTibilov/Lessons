// See https://aka.ms/new-console-template for more information
Console.WriteLine("Программа вычисляет из 2х введенных чисел большее и меньшее");

int first = 0;
int second = 0;

int vvod_chisla ()  //  метод ввода числа с клавивтуры
{
    Console.WriteLine("Введите число = ");
    int c = Convert.ToInt32(Console.ReadLine());
    return c;
}

void vuvod_rezult(int bolshee, int menshee) //  метод вывода результатов на экран
{
    Console.Write("Большее число = ");
    Console.Write(bolshee);
    Console.WriteLine();
    Console.Write("Меньшее число = "); 
    Console.Write(menshee);
}

first = vvod_chisla (); //  ввод чисел с клавиатуры
second = vvod_chisla ();

if (first > second) //  сравнение какое число больше
{
    vuvod_rezult(first, second);    //  вызов метода
}
else
{
    vuvod_rezult(second, first);
}

