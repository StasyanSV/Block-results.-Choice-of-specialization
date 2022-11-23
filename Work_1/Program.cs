// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться 
// коллекциями, лучше обойтись исключительно массивами

Console.Clear();

string[] array1 = {"hello", "2", "world", ":-)", "1234", "cat"};

string[] SecondArrayWithIF(string[] arr)
{
    string[] newArr = new string[arr.Length];

    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
    if(arr[i].Length <= 3)
        {
        newArr[count] = arr[i];
        count++;
        }
    }
    newArr  = newArr.SkipLast(arr.Length-count).ToArray();
    return newArr;
}


void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}
