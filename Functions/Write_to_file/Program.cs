// See https://aka.ms/new-console-template for more information

//  Программа генерирует числа, записывает их в файл 
//  и считывает числа из файла и выводит их на экран с редакцией


int N = 0;                          //  кол-во генерируемых чисел
string write = String.Empty;        //  
string razdelitel = String.Empty;   //  символ6 разделитель чисел
string textFinal = String.Empty;    //  отредактированный текст с разделителем
string input = String.Empty;        //  в эту переменную считываются данные из файла

int EnterNumber ()  //  метод ввода числа с клавиатуры
{
    int number = 0;

    Console.WriteLine("Введите число N");

    number = Convert.ToInt32(Console.ReadLine());
        
    return number;

}

string WriteTxt (int num)      //   метод записи данных в строку
{
    int K = 0;                 //   переменная для хранения генерируемого числа
    string output = "";        //   переменная для записи всех цифр в файл
    Console.WriteLine("");

    for (int i = 1; i <= num; i++)
        {
            K = new Random().Next(0, 100);      //  генерация случайного числа
            output = output + K + " ";          //  формирование строки для записи в файл
            Console.Write($" {K} ");            //  вывод в консоль чисел
            
        }
        
    return output;
}

//  метод замены символа разделителя в исходном файле

string Replace (string textForChange, char oldSymbol, string newSymbol)
{

string text = String.Empty;         //  хранит результат отредактированной строки
int lenght = textForChange.Length;  //  получаем длину символов в исходной строке

for (int i = 0; i < lenght; i++)
 {

    if (textForChange[i] == oldSymbol)  //  замена символа если попадается 'пробел'
        {
            text = text + $"{newSymbol}";
        }
    else
        {
        text = text + $"{textForChange[i]}";
        }
 }
 return text;
}


N = EnterNumber(); //  вызов метода ввода числа

write = WriteTxt(N);  //  вызов метода записи в файл случайных чисел
File.WriteAllText("file.txt", write);  //  запись всех чисел в файл
Console.WriteLine($"    Файл записан");
Console.WriteLine("");
razdelitel = "  |  ";   //  в качестве разделителя выберем строку символов

Console.Write("Разделитель для чисел считываемых из файла:");
Console.WriteLine(razdelitel);

input = File.ReadAllText("file.txt");   //  считываем числа из файла в строку

//  вызов метода замены символа 'пробел' на строку razdelitel
textFinal = Replace (input, ' ', razdelitel);
Console.WriteLine("");
Console.WriteLine("Cтрока с заменой разделителя между цифрами:");
Console.WriteLine("");
Console.WriteLine(textFinal);