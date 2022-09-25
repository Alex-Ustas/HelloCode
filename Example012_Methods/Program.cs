Console.Clear();
// --- Type 1 ------------------------------------------------------------
void Method1()
{
    Console.WriteLine("Hello!");
}
Method1();
Console.WriteLine();

// --- Type 2 ------------------------------------------------------------
void Method2(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg + " " + (i + 1));
        i++;
    }
}
//Method2(msg: "Hello, Alex!", count: 2);
Method2(count: 3, msg: "Hello, Alex!");
Console.WriteLine();

// --- Type 3 ------------------------------------------------------------
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);
Console.WriteLine();

// --- Type 4 ------------------------------------------------------------
string Method4(int count, string c)
{
    string msg = String.Empty;

    for (int i = 0; i < count; i++) msg = c + " " + msg;
    return msg;
}
string result = Method4(4, "Hello, yopta!");
Console.WriteLine(result);
Console.WriteLine();

// Таблица умножения
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}

// --- Task 1 ------------------------------------------------------------
string text = "В день своего тридцатишестилетия, 18 мая, Тревис Корнелл поднялся в пять " +
              "утра, облачился в тяжелые походные ботинки, джинсы, ковбойку в голубую клетку, " +
              "сел в красный пикап и поехал от своего дома в Санта-Барбаре в направлении " +
              "каньона Сантьяго на востоке графства Ориндж, к югу от Лос-Анджелеса.";

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] == oldValue) result += $"{newValue}";
        else result += $"{text[i]}";
    }
    return result;
}

string newText = Replace(text, ' ', '_');
newText = Replace(newText, 'с', 'С');
Console.WriteLine(newText);
Console.WriteLine();

// Сортировка методом минимакса
int[] arr = { 1, 5, 4, 9, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPos = i;

        // Search max value in array
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[maxPos]) maxPos = j;
        }

        int tempVal = array[i];
        array[i] = array[maxPos];
        array[maxPos] = tempVal;
    }
}

void ReverseSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPos = i;

        // Search min value in array
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPos]) maxPos = j;
        }

        int tempVal = array[i];
        array[i] = array[maxPos];
        array[maxPos] = tempVal;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
ReverseSort(arr);
PrintArray(arr);
