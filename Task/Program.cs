// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

Console.WriteLine("Введите массив строк через пробелы");
//string input = Console.ReadLine();
string input = "dfgg rge 34rgefg 23 1 0 ttt";

string[] resultArray = new string[0];
int approvedLength = 3;
string[] inputArray;

inputArray = StringSplit(input);

for (int i = 0; i < inputArray.Length; i++)
{
    if (inputArray[i].Length <= approvedLength)
    {
        resultArray = AddElementInArray(resultArray, inputArray[i]);
    }
}
for (int i = 0; i < resultArray.Length; i++)
{
Console.Write(resultArray[i]+ ' ');
}

string[] StringSplit(string array)
{
    int count = 1;

    for (int k = 0; k < array.Length; k++)
    {
        if (array[k] == ' ')
            count++;
    }

    string[] returnArray = new string[count];
    int i = 0;
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j] != ' ')
        {
            returnArray[i] += array[j];
        }
        else
            i++;
    }
    return returnArray;
}

string[] AddElementInArray(string[] array, string newElement)
{
    string[] tempArray = new string[array.Length+1];
    tempArray[tempArray.Length-1] = newElement;
    for (int i = 0; i < array.Length; i++)
    {
        tempArray[i] = array[i];
    }
    return tempArray;
}

