// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] NewArray(string[] array, int num)
{
    string[] result = new string[CountLess(array, num)];

    for (int i = 0, j = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            result[j] = array[i];
            j++;
        }
    }
    return result;
}

int CountLess(string[] array, int num)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= num)
        {
            count++;
        }
    }
    return count;
}

Console.Clear();
Console.Write("Введите массив через пробел: ");
string[] array = Console.ReadLine()!.Split(" ");
int number = 3;
string[] array2 = NewArray(array, number);
Console.WriteLine();
Console.WriteLine($"[{String.Join(", ", array)}] -> [{String.Join(", ", array2)}]");