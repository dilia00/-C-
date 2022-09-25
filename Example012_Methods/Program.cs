void Method1()
{
    Console.WriteLine("Автор …");
}

void Method2(string msg) //— где void ключевое слово, дальше идентификатор, в скобках
//указаны какие-то аргументы.
{
    Console.WriteLine(msg); //— оператор, в скобках указан принятый аргумент.
}

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg); //- где переменная count отображает на экране
        //определённое количество сообщений msg.
        i++;
    }
}

//Metod21(msg: “Текст”, count: 4);
//Явно указывая наименование аргумента, не обязательно писать их по порядку.
//Metod21(count: 4, msg: “Текст”);

int Metod3() //- не принимает никакие аргументы
{
    return DataTime.Now.Year; //- обязательное использование оператора return,
}

// int year = Metod3();
// Console.WriteLine(year);

string Method4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

// string res = Method4(10, "z");
// Console.WriteLine(res);


// for (int i = 2; i < 10; i++)
// {
//     for (int j = 2; j < 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i * j}");
//     }
//     Console.WriteLine();
// }


// Работа с текстом
// Дан текст. В тексте нужно вме пробелы заменить черточками |.
// маленькие буквы "к" заменить большими "К",
// а большие "С" заменить маленькими "с".

// string text =
//     "- Я думаю, - сказал князь, улыбаясь, -что, "
//     + "ежели бы вас послали вместо нашего милого Винценгероде,"
//     + "вы бы взяли приступом согласие прусского короля."
//     + "Вы так красноречивыю Вы дадите мне чаю?";
string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue)
            result = result + $"{newValue}";
        else
            result = result + $"{text[i]}";
    }
    return result;
}

// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'С', 'с');
// Console.WriteLine(newText);


// Алгоритм выбора min max

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition])
                minPosition = j;
        }
        int temp = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temp;
    }
}

void SelectionSortMax(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition])
                maxPosition = j;
        }
        int temp = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temp;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
SelectionSortMax(arr);
PrintArray(arr);
