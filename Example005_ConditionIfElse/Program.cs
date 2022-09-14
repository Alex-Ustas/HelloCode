Console.Write("Введите имя ");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
  Console.WriteLine("Ура, это Маша!");
}
else
{
  Console.Write("Привет, ");
  Console.WriteLine(username);
}