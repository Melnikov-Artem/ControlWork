/*
Из имеющегося массива строк формирует новый массив, 
длина которых меньше либо равна 3 символам.
Первоначальный массив ввести с клавиатуры
*/

int ReadWriteMss(string msg)
{
    Console.Write($"{msg}");
    return Convert.ToInt32(Console.ReadLine());
}

string[] GetArray(int sizeN, string message)
{
    string[] arrStr = new string[sizeN];
    for (int i = 0; i < arrStr.Length; i++)
    {
        Console.WriteLine($"{message}{i + 1}: ");
        arrStr[i] = Console.ReadLine();

    }
    return arrStr;
}

void PrintArray(string[] array)
{
    Console.WriteLine("Исходный массив:");
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void PrintNewArray(string[] array)
{
    Console.WriteLine("Массив после выборки:");
    int count = 0;
    //string elem = String.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            if (count > 0)
            {
                Console.Write(", ");
            }
            count += 1;
            Console.Write($"{array[i]}");
        }
    }
    Console.WriteLine();
}

Console.Clear();
Console.WriteLine("Сформируем массив из строк.");
int numberStr = ReadWriteMss("Введите количество строк в массиве:");
string message = "Введите строку №";
string[] firstArray = GetArray(numberStr, message);
PrintArray(firstArray);
PrintNewArray(firstArray);