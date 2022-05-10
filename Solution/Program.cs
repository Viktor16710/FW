/*
Задача: Написать программу, котора из имеющегося массива строк формирует массив из строк,
длина которых меньше либо равна 3 символа.
Превоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> []
*/

string[] array = {"hello", "2", "world", ":-)"};
PrintArray(array);
string[] array1 = ArrayOf3Elements(array);
array1 = array1.Where(x => x != null).ToArray();
Console.WriteLine();
PrintArray(array1);

string[] ArrayOf3Elements(string[] array)
{
    string[] arrayToReturn = new string[array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        if(array[i].Length <= 3)
        {
            arrayToReturn[i] = array[i];
        }
    }
    return arrayToReturn;
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if(i != array.GetLength(0) - 1)
        {
            Console.Write(array[i] + ", ");
        }
        else
        {
            Console.Write(array[i]);
        }
    }
}