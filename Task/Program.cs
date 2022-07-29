/* Написать программу, которая из имеющегося массива строк формирует массив из строк,
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться
коллекциями, лучше обойтись исключительно массивами.
**Примеры**:

["hello", "2", "world", ":-)"] -> ["2", ":-)"]

["1234", "1567", "-2", "computer science"] -> ["-2"]

["Russia", "Denmark", "Kazan"] -> [] */

//Функция заполнения массива требуемыми данными
void FillNewArray(string[] tempArray, string[] oldArray)
{
    int i = 0;
    int j = 0;
    {
        for (i = 0; i < oldArray.Length; i++)
        {
            string s = oldArray[i];
            if (s.Length <= 3)
            {
                tempArray[j] = oldArray[i];
                Console.Write($"{tempArray[j]} ");
                j++;
            }
        }
    }
}

//Начало программы
Console.WriteLine("Программа, которая из имеющегося массива строк формирует массив из строк,длина которых меньше либо равна 3 символа");
Console.Write("Введите размер массива: ");
string inputNumberOfArray = Console.ReadLine();
int numberOfArray = int.Parse(inputNumberOfArray);
//Инициализация и заполнение массива
string[] arrayOfString = new string[numberOfArray];
int i = 0;
int count = 0;
for (i = 0; i < numberOfArray; i++)
{
    Console.WriteLine($"Введите {i + 1}-й элемент массива: ");
    arrayOfString[i] = Console.ReadLine();
    string s = arrayOfString[i];
    if (s.Length <= 3)
    {
        count++;
    }
}
//Заполнение нового массива нужными значениями
Console.WriteLine($"Новый массив будет состоять из {count} элементов ");
string[] newArray = new string[count];
Console.WriteLine(
    "Массив, в котором содержатся элеменnы, длина которых меньше или равна 3-м символам: "
);
FillNewArray(newArray, arrayOfString);