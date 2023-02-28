// See https://aka.ms/new-console-template for more information

//  Программа возводит число А в степень b


int A = 0;
int b = 0;
int rezult = 1;     //  хранит результат возведения в степень
int stepen = 0;     //  сколько раз надо перемножить квадрат числа на квадрат числа
int kvadrat = 0;    //  просто квадрат числа: А*А

int EnterNumber (string text)  //  метод ввода числа с клавиатуры
{
    int number = 0;

    Console.WriteLine($"{text}");
    number = Convert.ToInt32(Console.ReadLine());
        
    return number;

}


A = EnterNumber("Введите число"); //  вызов метода ввода первого числа

b = EnterNumber("Введите степень в которую надо возвести число"); //  вызов метода ввода второго числа

stepen = b / 2;     //  сколько раз надо перемножить квадрат числа на квадрат числа

kvadrat = A * A;    //  квадрат числа А


//  для сокращения вычислений перемножаем не само число на само себя кол-во раз
//  равных степени числа
//  а перемножаем квадрат числа на квадрат числа и если степень нечетная умножаем результат на само число А
for (int i = 1; i <= stepen; i++)  
    {
        rezult = kvadrat * rezult;     
    }   

if ((b % 2) == 1)
    {
        rezult = rezult * A;
    }

Console.WriteLine("");
Console.WriteLine($"{A} в степени {b} = {rezult}");