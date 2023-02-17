// See https://aka.ms/new-console-template for more information

//  Программа находит 2 цифру 3-х значного числа

int number = 0; //  

int EnterNumber ()  //  метод ввода 3-х значного числа с клавиатуры
{
    int c = 0;
  while (c<100 || c >999)   //  цикл если ввели не 3-х значное число
  {
    Console.WriteLine("Введите 3-х значное число");
    c = Convert.ToInt32(Console.ReadLine());
    if (c<100 || c>999)   //  проверка если число не 3-х значное
                          //  пользователю предлагается повторный ввод числа
    {
        Console.WriteLine("Вы ввели не 3-х значное число");
        Console.WriteLine("Повторите ввод");
    }
    
    } 
    return c;
}

number = EnterNumber(); //  вызов метода ввода числа

number = (number / 10) % 10;    //  делим число на 10, целую часть от деления делим на 10
                                // присваиваем остаток в number - получаем 2 цифру числа

Console.Write("Вторая цифра 3-х значного число   =   ");
Console.Write(number);
