// See https://aka.ms/new-console-template for more information

//  Программа вычисления выдаёт таблицу кубов чисел от 1 до N.


int EnterNumber ()  //  метод ввода числа с клавиатуры
{
    int number = 0;

    Console.WriteLine("Введите число N");
    number = Convert.ToInt32(Console.ReadLine());
        
    return number;

}

int N = EnterNumber();

//  в цикле считаем кубы чисел от 1 до N и выводим на экран

for (int i = 1; i <= N ; i++)
{
    Console.WriteLine($"Куб числа {i}   =   {Math.Pow(i, 3)}");
}

