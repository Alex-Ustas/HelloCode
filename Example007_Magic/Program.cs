Console.Clear();

int xa = 1, ya = 1,
    xb = 1, yb = 30,
    xc = 60, yc = 30;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("*");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("*");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("*");

int x = xa, y = yb;
int count = 0;

while (count < 100)
{
    int num = new Random().Next(0, 3);

    if (num == 0)
    {
      x = (x + xa)/2;
      y = (y + ya)/2;
    }

    if (num == 1)
    {
      x = (x + xb)/2;
      y = (y + yb)/2;
    }

    if (num == 2)
    {
      x = (x + xc)/2;
      y = (y + yc)/2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("*");
    count++;
}