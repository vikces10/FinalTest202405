Console.WriteLine("Введите элементы массива строк через запятую без пробела:");
string input = Console.ReadLine();
string[] inputArray = input.Split(',');

string[] resultArray = FilterArray(inputArray);

Console.WriteLine("Исходный массив:");
PrintArray(inputArray);

Console.WriteLine("Новый массив:");
PrintArray(resultArray);

string[] FilterArray(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Trim().Length <= 3)
        {
            count++;
        }
    }
    string[] result = new string[count];
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Trim().Length <= 3)
        {
            result[index] = array[i].Trim();
            index++;
        }
    }
    return result;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"\"{array[i]}\"");
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}
