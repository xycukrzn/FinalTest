// Что-то очень важное
Console.WriteLine("Введите элементы массива через пробел:");
    string input = Console.ReadLine();
    string[] inputArray = input.Split(' ');

    string[] resultArray = FilterStrings(inputArray);

    Console.WriteLine("Результат:");
    foreach (string str in resultArray)
    {
        Console.WriteLine(str);
    }
    

static string[] FilterStrings(string[] inputArray)
{
    int count = 0;
    foreach (string str in inputArray)
    {
        if (str.Length <= 3)
        {
            count++;
        }
    }

    string[] resultArray = new string[count];
    int index = 0;
    foreach (string str in inputArray)
    {
        if (str.Length <= 3)
        {
            resultArray[index++] = str;
        }
    }

    return resultArray;
}