// Numbers to string -------------------------------------------------------
string NumbersFor(int a, int b)
{
    string result = String.Empty;
    for (int i = a; i <= b; i++)
    {
        result += $"{i} ";
    }
    return result;
}

string NumbersRec(int a, int b)
{
    if (a <= b) return $"{a} " + NumbersRec(a + 1, b);
    else return String.Empty;
}

void TaskNumbers()
{
    Console.WriteLine("--- Number ---");
    Console.Write("Введите a: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите b: ");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("For => " + NumbersFor(a, b));
    Console.WriteLine("Rec => " + NumbersRec(a, b));
}

// Sum from 1 to n --------------------------------------------------------------
int SumFor(int n)
{
    int result = 0;
    for (int i = 1; i <= n; i++) result += i;
    return result;
}

int SumRec(int n)
{
    if (n == 1) return 1;
    else return n + SumRec(n - 1);
}

void TaskSum()
{
    Console.WriteLine("--- Sum ---");
    Console.Write("Введите n: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("For => " + SumFor(n));
    Console.WriteLine("Rec => " + SumRec(n));
}

// Power --------------------------------------------------------------
int PowerFor(int a, int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= a;
    return result;
}

int PowerRec(int a, int n)
{
    return n == 0 ? 1 : PowerRec(a, n - 1) * a;
}

int PowerRecMath(int a, int n)
{
    if (n == 0) return 1;
    else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
    else return PowerRecMath(a, n - 1) * a;
}

void TaskPower()
{
    Console.WriteLine("--- Power ---");
    Console.Write("Введите a: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите n: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("For => " + PowerFor(a, n));
    Console.WriteLine("Rec => " + PowerRec(a, n));
    Console.WriteLine("RecMath => " + PowerRecMath(a, n));
}

// Word search --------------------------------------------------------------
char[] s = { 'а', 'и', 'с', 'в' };

void WordSearchFor()
{
    int count = s.Length;
    int n = 1;
    for (int i = 0; i < count; i++)
    {
        for (int j = 0; j < count; j++)
        {
            for (int k = 0; k < count; k++)
            {
                for (int l = 0; l < count; l++)
                {
                    Console.WriteLine($"{n++,-5} {s[i]}{s[j]}{s[k]}{s[l]}");
                }
            }
        }
    }
}

int n = 1;
void WordSearchRec(string alphabet, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        Console.WriteLine($"{n++,-5} {new String(word)}");
        return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        WordSearchRec(alphabet, word, length + 1);
    }
}

void TaskWords()
{
    WordSearchFor();
    Console.WriteLine();
    WordSearchRec("аисв", new char[2]);
}

// Directory scan --------------------------------------------------------------
string path = "D:\\Users\\User\\Documents\\Work\\GeekBrains\\C#\\Examples";
DirectoryInfo di = new DirectoryInfo(path);

void DirScanFor()
{
    FileInfo[] fi = di.GetFiles();
    for (int i = 0; i < fi.Length; i++)
    {
        Console.WriteLine(fi[i].Name);
    }
}

void CatalogInfoRec(string path, string indent = "")
{
    DirectoryInfo catalog = new DirectoryInfo(path);
    DirectoryInfo[] catalogs = catalog.GetDirectories();
    for (int i = 0; i < catalogs.Length; i++)
    {
        Console.WriteLine($"{indent}{catalogs[i].Name}");
        CatalogInfoRec(catalogs[i].FullName, indent + "  ");
    }

    FileInfo[] files = catalog.GetFiles();
    for (int i = 0; i < files.Length; i++)
    {
        Console.WriteLine($"{indent}{files[i].Name}");
    }
}

void TaskDirScan()
{
    Console.WriteLine(di.CreationTime);
    DirScanFor();
    Console.WriteLine("-----------------------------------");
    CatalogInfoRec(path);
}

// Towers ------------------------------------------------------------------------
void Towers(string source = "1", string dest = "3", string middle = "2", int count = 3)
{
    if (count > 1) Towers(source, middle, dest, count - 1);
    Console.WriteLine($"{source} >> {dest}");
    if (count > 1) Towers(middle, dest, source, count - 1);
}

void TaskTowers()
{
    Console.WriteLine("--- Towers ---");
    Towers();
}

// Bypass of math structure --------------------------------------------------------------------
// <num> = ((4 - 2)* (1 + 3)) / 10
string emp = String.Empty;
string[] tree = { emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3" };

void InOrderTraversal(int pos = 1)
{
    if (pos < tree.Length)
    {
        int left = 2 * pos;
        int right = 2 * pos + 1;
        if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
        Console.WriteLine(tree[pos]);
        if (right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right);
    }
}

void TaskBypass()
{
    Console.WriteLine("--- Bypass ---");
    InOrderTraversal();
}




// Tasks execution ------------------------------------------------------------------
Console.Clear();
//TaskNumbers();
//Console.WriteLine();
//TaskSum();
//Console.WriteLine();
//TaskPower();
//Console.WriteLine();
//TaskWords();
//Console.WriteLine();
//TaskDirScan();
//Console.WriteLine();
TaskTowers();
Console.WriteLine();
TaskBypass();
