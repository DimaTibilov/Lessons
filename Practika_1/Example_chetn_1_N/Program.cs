// See https://aka.ms/new-console-template for more information
Console.WriteLine("Программа выводит все четные числа от 1 до введенного числа");

int chislo = 0;
int chetnoe = 2;    //  первое четное число

int vvod_chisla ()  //  метод ввода числа с клавивтуры
{
    Console.WriteLine("Введите число = ");
    int c = Convert.ToInt32(Console.ReadLine());
    return c;
}
   
chislo = vvod_chisla ();  //  метод ввода числа с клавиатуры

Console.Write("Четные числа в диапазоне от 1 до ");
Console.Write(chislo);  
Console.WriteLine(); 

while (chislo >= chetnoe)
{
    
    
    Console.Write(chetnoe); 
    Console.Write("  ");   
    chetnoe = chetnoe + 2;  //  перебираем четные числа до введенного числа
}

