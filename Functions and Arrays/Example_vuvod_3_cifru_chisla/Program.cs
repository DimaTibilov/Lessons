// See https://aka.ms/new-console-template for more information

int number = 0; //  

int EnterNumber ()  //  метод ввода числа с клавиатуры
{
    int c = 0;
  while (c<100)   //  цикл если ввели меньше чем  3-х значное число
  {
    Console.WriteLine("Введите число");
    c = Convert.ToInt32(Console.ReadLine());
    if (c<100)   //  проверка если число не 3-х значное
                 //  пользователю предлагается повторный ввод числа
    {
        Console.WriteLine("Нет 3-ей цифры в числе");
    }
    
    } 
    return c;
}

number = EnterNumber(); //  вызов метода ввода числа

while (number > 999)    //  если число больше чем 3-х значное 
{
    number = (number / 10);//  делим его на 10 и целую часть сохраняем в number

    Console.WriteLine(number);   
}

number = number % 10;   //  получив первые 3 цифры числа, делим его на 10
                        //  и сохраняем остаток в number

Console.Write("Третья цифра числа   =   ");
Console.Write(number);
