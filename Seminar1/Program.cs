int number = 12;

Console.WriteLine("Quantity " + number + number);
Console.WriteLine("Quantity " + (number + number));

string s = number.ToString();
Console.WriteLine(s);

Console.Write("Enter your name ");
string name = Console.ReadLine();
Console.WriteLine("Hi, " + name);

Console.Write("Enter your age ");
int age = int.Parse(Console.ReadLine());

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

if (a > b)
{
    Console.WriteLine("A > B");
}
else if (a < b)
{
    Console.WriteLine("A < B");
}
else
{
    Console.WriteLine("A = B");
}
