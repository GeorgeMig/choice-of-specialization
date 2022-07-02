// Я решил немного поиграть. Знаю, что это не треубется в задание, но ведь так веселее, согласны?

Console.WriteLine("Привет! Как тебя зовут?");
Console.Write("Введи свое имя с большой буквы -> ");
string name = Console.ReadLine();

Console.WriteLine();
Console.WriteLine($"Приятно познакомиться, {name}! Я, программа, которая умеет из заданного массива строк формировать массив строк, длина которых меньше или равна 3-м символам.");

void Description(string names) // метод сделан, чтобы продемонстрировать использоование рекурсии.
{
    Console.WriteLine("Значение элементам массива ты присваиваешь самостоятельно при помощи ввода символов.");
    Console.WriteLine("Размер исходного массива задаешь при помощи ввода чисел");
    Console.WriteLine();
    Console.WriteLine($"{names}, тебе все понятно?");
    Console.Write("Ответ (введи да или нет) -> ");
    string answer = Console.ReadLine();
    if (answer == "нет")
    {
        Console.WriteLine();
        Console.WriteLine("Хорошо. Повторю ещё раз.");
        Console.WriteLine("Я, программа, которая умеет из заданного массива строк формировать массив строк, длина которых меньше или равна 3-м символам.");
        Description(names);
    }
    else
    {
        return;
    }
}
Description(name);

Console.WriteLine();
Console.Write($"{name}, тогда пора задать размер массиву. Введи число, которому должен соответствовать размер массива -> ");
int l = int.Parse(Console.ReadLine());
string[] arrStr = new string[l];
Console.WriteLine();
string[] FillArr(string[] arr)// метод заполнения массива
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Введи {i + 1} элемент массива - ");
        arr[i] = Console.ReadLine();
    }
    return arr;
}
arrStr = FillArr(arrStr);
Console.WriteLine();
Console.WriteLine("Элементы исходного массива:");
void PrintArr(string[] arr) // данный метод выводит в консоль элементы массива
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write("-" + arr[i]);
        Console.WriteLine();
    }
}
PrintArr(arrStr);
string[] arrRes = Result(arrStr, l);// //Создание массива, в котором будет записываться результат;
string[] Result(string[] arr, int m) // данный метод осуществляет подсчет элементов массива на соотвптствие условию и записывает их в финальный массив arrRes.
{
    int[] arrIndex = new int[m];
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            arrIndex[count] = i;
            count++;
        }

    }

    string[] arrRe = new string[count];
    for (int j = 0; j < arrRe.Length; j++)
    {
        arrRe[j] = arr[arrIndex[j]];
    }
    return arrRe;
}
Console.WriteLine();
Console.WriteLine($"Все элементы массива, длинна которых меньше или равна 3-м символам:");
PrintArr(arrRes); // вывод массива, содержащего результат.

Console.WriteLine();
Console.WriteLine($"Готово! {name}, буду рада встретиться снова :-D");