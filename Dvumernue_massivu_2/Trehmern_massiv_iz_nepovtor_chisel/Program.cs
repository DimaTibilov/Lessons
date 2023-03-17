// See https://aka.ms/new-console-template for more information

//  Сформируйте трёхмерный массив из неповторяющихся двузначных чисел
//  Напишите программу, которая будет построчно выводить массив,
//  добавляя индексы каждого элемента

//---------------------------------------------
//  объявляем переменные

int row = 0;    //  кол-во строк в массиве
int column = 0; //  кол-во столбцов в массиве
int layer = 0;      //  кол-во слоев массива
int min = 0;    //  для генератора чисел min и max - диапазон генерации чисел
int max = 0;
string text = String.Empty;
//------------------------------------------------
//  ввод числа строк, столбцов, min max для генератора чисел

int GetNumber(string text)
{
    int number = 0;
    System.Console.WriteLine(text);
    number = Convert.ToInt32(Console.ReadLine());
    return number;
}

//------------------------------------------------
//  вывод трехмерного массива в консоль

void PrintArrayThreeDim(int[,,] array)
{
    int row = array.GetLength(0); // кол-во строк в массиве
    int column = array.GetLength(1); // ко-во столбцов в массиве
    int layer = array.GetLength(2);     //  кол-во слоев массива
    for (int k = 0; k < layer; k++) //  перебираем 3-е измерение массива - слои
    {
        //----------------------------------------------------------------------------------
        Console.WriteLine($"{k} слой"); //  надпись - какой слой выводим в консоль

        for (int t = 1; t <= column; t++)   // надпись - кол-во столбцов в массиве
        {
            Console.Write($"{t} столбец     ");
        }
        Console.WriteLine();
        //--------------------------------------------------------------------------------
        for (int i = 0; i < row; i++)   //  перебираем стоки массива
        {
            int numberRow = i;  //  для надписи - вывода кол-ва столбцов в консоль 
            for (int j = 0; j < column; j++)    //  перебираем стобцы массива
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k})     "); //  выводим в консоль массив
            }

            numberRow = i + 1;
            Console.Write($"   ---    {numberRow} строка"); //  надпись - какая сторка массива выводится в консоль
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

//-------------------------------------------------
//  выбор рандомных неповторяющихся чисел для массива
//  по условию задачи надо заполнить 3-х мерный массив 
//  2-х значными неповторяющимися числами от 10 до 99
//  то есть максимальная размерность массива 5х6х3 = 90 элементов

int[] NumberGenerate(int min, int ind)
{
    int[] array = new int[ind]; //  формируем массив чисел от 10 до 85

    for (int i = 0; i < ind; i++)
    {
        array[i] = min + i;
    }

    return array;

}

//  -------------------------------------------
//  перемешиваем элементы массива для получения псевдослучайной последовательности

int[] MixArray(int[] array)
{
    int size = array.Length;
    int change = 0;
    Random rnd = new Random();
    int pos = 0;
    for (int i = 0; i < size; i++)
    {
        change = array[i];
        pos = rnd.Next(i, size);
        array[i] = array[pos];
        array[pos] = change;
    }
    return array;
}
//----------------------------------------------------
//  заполнение трехмерного массива целыми числами

int[,,] FillByRandom(int row, int column, int layer, int[] mix)
{
    int index = 0;
    int[,,] array = new int[row, column, layer]; //  объявляем массив возвращаемый из метода
    int ind = row * column * layer;
    for (int k = 0; k < layer; k++)
    {
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {

                array[i, j, k] = mix[index];   //  заполняем массив случайными целыми числами    
                index++;
            }

        }
    }

    return array;
}

//----------------------------------------------------------------------
//  проверка правильности введенного числа

int CheckNumber(int number, int level, char operation)
{
    switch (operation)
    {
        case '<':
            while (number > level)
            {
                Console.WriteLine("Введеное число больше диапазона");
                number = GetNumber(text);
            }
            return number;

        case '>':
            while (number < level)
            {
                Console.WriteLine("Введеное число меньше диапазона");
                number = GetNumber(text);
            }
            return number;

        default:
            break;
    }
    return number;
}



//-----------------------------------------------------------------------
//  основная программа

//   просто попробовал вызов вложенного метода, как можно компактно написать ?
//   и как проще написать проверку правильного ввода ?

text = "Введите размер строк массива не больше 5";
row = CheckNumber(GetNumber(text), 5, '<');

text = "Введите размер столбцов массива не больше 5";
column = CheckNumber(GetNumber(text), 5, '<');

text = "Введите ко-во слоев массива не больше 3";
layer = CheckNumber(GetNumber(text), 3, '<');

Console.WriteLine("Введите диапазон для генерации чисел");

text = "Введите min число больше 10";
min = CheckNumber(GetNumber(text), 10, '>');

text = "Введите max число меньше 85";
max = CheckNumber(GetNumber(text), 85, '<');

int numberElementov = row * column * layer;

int[] numberNotRepit = NumberGenerate(min, numberElementov);

int[] mix = MixArray(numberNotRepit);

Console.WriteLine("Заполняем 3-х мерный массив 2-х значными неповторяющимися числами от 10 до 99");

int[,,] numbers = FillByRandom(row, column, layer, mix);

Console.WriteLine("Выводим 3-х мерный массив в консоль слоями 1-2-3");

PrintArrayThreeDim(numbers);