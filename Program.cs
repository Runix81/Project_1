// Метод генерирующий рандомные строки длиной от 1 до 6 символов
string DoString()
{
    bool lowerCase = false;                     // булевая переменная установленная в значение лож
    char offset = lowerCase ? 'a' : 'A';        // проверяем символ, если в нижнем регистре, то переводим в верхний
    int lettersOffset = 26;                     // переменная задающая количество символов                             
    Random rnd = new Random();
    int size = rnd.Next(1, 7);                  // задается случайный размер строки от 1 до 6
    string res = "";                            // создаем новую строку

    for (var i = 0; i < size; i++)                                      // цикл заполняющий строку 
    {                                                                   // случайными символами
        char letter = (char)rnd.Next(offset, offset + lettersOffset);   // и возвращающий ее
        res += letter;                                                  
    }
    return res;
}

// Метод создающий заполняющий и возвращающий массив
string[] AddArray()
{
    Random rnd = new Random();
    string[] array = new string[rnd.Next(1, 10)];   
    for (int i = 0; i < array.Length; i++)          // метод создающий массив длиной от 1 до 9 элементов
    {                                               // используя метод создания строк 
        array[i] = DoString();                      // возвращает заполненый массив
    }
    return array;
}

// Метод выводящий в консоль массив
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)          // метод выводит в консоль элементы массива 
    {                                               // используя цикл for 
        System.Console.Write($"{array[i]}  ");
    }
}

// Метод получает на вход исходный массив, находит элементы длина которых меньше или равна 3 символам
// и создает новый массив заполненый этими элементами.
string[] FromOneArrayToAnother(string[] array)
{
    string[] resArray = new string[array.Length];       // создаем массив, который будет заполнен элементами не дленее 3х символов
    int count = 0;                                      // переменная для изменения элемента резудьтирующего массива
    for (int i = 0; i < array.Length; i++)              // цикл переберающий элементы исходного массива, полученного на входе
    {                                                   // проверяет длину этих символов и если они не дленее 3х символов
        if (array[i].Length <= 3)                       // записывает их в результирующий массив и увеличивает на 1 номер элемента массива
        {
            resArray[count] = array[i];
            count++;
        }
    }
    return resArray;                                    // возвращает полученный, результирующий массив
}

string[] arr = AddArray();              // создаем новый массив и присваиваем ему массив созданный методом AddArray
PrintArray(arr);                        // выводим в консоль исходный массив
System.Console.WriteLine("");           // переходим на новую строчку
PrintArray(FromOneArrayToAnother(arr)); // выводим в консоль массив полученый после применения метода FromOneArrayToAnother