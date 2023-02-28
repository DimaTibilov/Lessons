// See https://aka.ms/new-console-template for more information

//  Программа считает сумму цифр в числе


int N = 0;
int rezult = 0;

int EnterNumber ()  //  метод ввода числа с клавиатуры
{
    int number = 0;

    Console.WriteLine("Введите число N");
    number = Convert.ToInt32(Console.ReadLine());
        
    return number;

}

int Summa (int num) //  метод суммирования цифр числа
{
    int sum = 0;
    int lastNumber = 0;
    
    while (num != 0)  //  разбираем число на цифры
        {
            lastNumber = num % 10;    //  выделяем последнюю цифру числа
            if (lastNumber == 0)
            {
                sum = num;  //  если число состоит из одной цифры   
            }
            num = num / 10;             //  уменьшаем число на 1 цифру - отбрасываем крайнюю правую цифру
            sum = sum + lastNumber;      //  Суммируем отдельные цифры числа
            
        }
    
    return sum;
}

N = EnterNumber(); //  вызов метода ввода числа

rezult = Summa(N);  //  вызов метода суммирования цифр в числе

Console.WriteLine($"Сумма всех цифр числа  --- {rezult}");
