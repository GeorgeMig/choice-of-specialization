//Создание исходного массива 
Console.Write("Необходимо задать размер массиву. Введите цифру, которой должен соответствовать размер массива -> ");
int l = int.Parse(Console.ReadLine());
string[] arrStr = new string[l];
Console.WriteLine();
for (int i = 0; i < arrStr.Length; i++)
{
    Console.Write($"Введите {i + 1} элемент массива - ");
    arrStr[i] = Console.ReadLine();
}

//Печать элементов исходного массива 

void PrintArr(string [] arr) // данный метод выводит в консоль элементы массива
{
    Console.WriteLine();
    Console.WriteLine($"Элементы массива:");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"|{i}|");
        Console.Write(" " + arr[i]);
        Console.WriteLine();
    }
}
PrintArr(arrStr);