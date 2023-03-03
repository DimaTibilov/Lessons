// See https://aka.ms/new-console-template for more information

//  Программа нахождения точки пересечения 2-х прямых

string rezult = String.Empty;   //  для вывода результата вычислений в консоль

//  метод ввода коэффициентов уравнений

int GetIntValueFromUser(string text)
{
    int num = 0;
    bool flag = false;
    while (!flag)   //  проверка что ввели именно число
    {
        Console.WriteLine($"Введите коэффициент {text}: ");
        flag = int.TryParse(Console.ReadLine(), out num);
    }
    return num;
}
//--------------------------------------------------
//  вызов метода ввода коэффициентов уравнений 

void GetLineByUser(int[,] koff)
{
    //  заполнение 2-мерного массива коэффициентами уравнений

    koff[0, 0] = GetIntValueFromUser("k1 = ");
    koff[0, 1] = GetIntValueFromUser("b1 = ");
    Console.WriteLine($"Получаем уравнение --- y = {koff[0, 0]} * x + {koff[0, 1]}");
    
    koff[1, 0] = GetIntValueFromUser("k2 = ");
    koff[1, 1] = GetIntValueFromUser("b2 = ");
    Console.WriteLine($"Получаем уравнение --- y = {koff[1, 0]} * x + {koff[1, 1]}");
}

//------------------------------------------------
//  объявление массива, хранящего коэффициенты уравнений

int[,] CreateLine()
{
    return new int[,] { { 0, 0 }, { 0, 0 } };
}
//----------------------------------------------------
string CheckLine(int[,] array)
{
    int size = 2;
    double[] num = new double[size];
    double second = 0;

    //  если все коэффициенты k1 k2 и b1 b2 -кратны одному числу - прямые совпадают
    //  в нашем частном случае кратность должна быть = 1

    if ((array[0, 0] == array[1, 0]) && (array[0, 1] == array[1, 1]))
    {
        return ("Прямые совпадают"); ;
    }

    //  вычисляем кратность коэффициентов b1 и b2

    if (array[0, 1] > array[1, 1])
    {
        second = (array[0, 1] * 1.0) % (array[1, 1] * 1.0);
    }
    else
    {
        second = (array[1, 1] * 1.0) % (array[0, 1] * 1.0);
    }

    //  если коэфффициенты при x y - кратны,
    //  а b1 и b2 - нет (остаток от их деления не 0) прямые параллельны

    if ((array[0, 0] == array[1, 0]) && (second != 0))
    {
        return ("Прямые параллельны");
    }
    
    //  если условия выше не выполнились,
    //  вызываем метод вычисления точки пересечения прямых

    num = DotCross(array);
    return ($"Точка пересечения прямых {num[0]}, {num[1]}");
}

//----------------------------------------------------
//  поиск точки пересечения прямых

double[] DotCross(int[,] array)
{
    int size = 2;

    double[] dot = new double[size];
    //  вычисляем координату - x
    dot[0] = Math.Round((((array[1, 1] - array[0, 1]) * 1.0) / ((array[0, 0] - array[1, 0] * 1.0))), 2);// x

    //  вычисляем координату - y
    dot[1] = Math.Round((array[1, 0] * dot[0] + array[1, 1]), 2);// y

    return dot;
}
//-----------------------------------------------------

int[,] lines = CreateLine();    //  вызов метода создания массива коэффициентов уравнений

GetLineByUser(lines);           //  ввод коэффициентов уравнений

rezult = CheckLine(lines);        //  проверка прямые могут: совпадать, быть параллельны
                                  //  если пересекаются - поиск точки пересечения
Console.WriteLine();
Console.WriteLine(rezult);      //  вывод результата в консоль