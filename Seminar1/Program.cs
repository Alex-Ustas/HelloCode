// Игра угадай число
Console.WriteLine("Game started");

int secret_number = new Random().Next(1, 11);
int attempt = 5;
bool win = false;

while (attempt > 0)
{
    Console.Write("Enter num 1-10: ");
    int user_number = int.Parse(Console.ReadLine());
    //Console.WriteLine(user_number);

    if (user_number > secret_number)
    {
        Console.WriteLine("Секретное число меньше");
        attempt--;
    }
    else if (user_number < secret_number)
    {
        Console.WriteLine("Секретное число больше");
        attempt--;
    }
    else if (user_number == secret_number)
    {
        Console.WriteLine("Число угадано");
        win = true;
        break;
    }
}

if (win)
{
    Console.WriteLine("Мы победили!");
    Console.WriteLine("Осталось попыток: " + (attempt - 1));
}
else
{
    Console.WriteLine("Мы проиграли!");
    Console.WriteLine("Секретное число - " + secret_number);

}
