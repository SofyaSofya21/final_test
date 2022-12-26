// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

Console.WriteLine("Введите массив строк через пробелы");
//string input = Console.ReadLine();
string input = "dfgg rge 34rgefg 23 1 0 ttt";

string[] resultArray;
int approvedLength = 3;
string[] inputArray;

inputArray = StringSplit(input);


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



// for (int i = 0; i < inputArray.Length; i++)
// {

// }