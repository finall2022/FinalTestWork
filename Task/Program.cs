/* Написать программу, которая из имеющегося массива строк формирует массив из строк,
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться
коллекциями, лучше обойтись исключительно массивами.
**Примеры**:

["hello", "2", "world", ":-)"] -> ["2", ":-)"]

["1234", "1567", "-2", "computer science"] -> ["-2"]

["Russia", "Denmark", "Kazan"] -> [] */

Console.Write("Введите размер массива: ");
string inputNumberOfArray = Console.ReadLine();
int numberOfArray = int.Parse(inputNumberOfArray);
Console.WriteLine($"Размер массива: {numberOfArray}");
string[] arrayOfString = new string[numberOfArray];
int i = 0;
int count = 0;
for (i = 0; i < numberOfArray; i++)
{
    Console.WriteLine($"Введите {i + 1}-й элемент массива: ");
    arrayOfString[i] = Console.ReadLine();
    string s = arrayOfString[i];
    Console.WriteLine("Символов в строке: {0}", s.Length);
    if (s.Length <= 3)
    {
        count++;
    }
}

Console.WriteLine($"Новый массив из {count} элементов ");
string[] newArray = new string[count];
int j = 0;
Console.WriteLine("Массив, в котором содержатся элеменды, длина которых меньше или равна 3-м символам: ");
for (i = 0; i < arrayOfString.Length; i++)
{
    string s = arrayOfString[i];
    if (s.Length <= 3)
    {
        newArray[j] = arrayOfString[i];
        Console.Write($"{newArray[j]} ");
        j++;
    }
}
