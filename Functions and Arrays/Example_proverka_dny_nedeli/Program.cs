// See https://aka.ms/new-console-template for more information

//  Программа проверят является ли день недели выходным

int dayOfWeek = 0; //  

int EnterDay ()  //  метод ввода числа с клавиатуры
{
    int day = 0;
  while (day<1 || day>7)   //  цикл если ввели номер не существующего дня недели
  {
    Console.WriteLine("Введите номер дня недели");
    day = Convert.ToInt32(Console.ReadLine());
    if (day>=1 && day<=7)   //  проверка существует ли такой день недели

    {
        Console.WriteLine("Есть такой день недели");
    }
    else
    {
        Console.WriteLine("Нет такого дня недели");
    }
    } 
    return day;
}

dayOfWeek = EnterDay(); //  вызов метода ввода числа

if (dayOfWeek==6 || dayOfWeek==7)
{
    Console.Write("Это выходной день");
}
else
{
    Console.Write("Это будний день");
}
