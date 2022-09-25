int[] array = { 13, 25, 73, 94, 15, 86, 47, 38, 29 };

int n = array.Length;
int find = 38;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}