Console.WriteLine("Введите четверть: ");
int i = Convert.ToInt32(Console.ReadLine());

void Zadacha18(int i)
{
    if (i == 1)
    {
        Console.WriteLine("x (0;infinity), y(0;infinity)");
    }
    else if (i == 2)
    {
        Console.WriteLine("x (infinity;0), y(0;infinity)");
    }
    else if (i == 3)
    {
        Console.WriteLine("x (infinity;0), y(infinity;0)");
    }
    else if (i == 4)
    {
        Console.WriteLine("x (0;infinity), y(infinity;0)");
    }
}
Zadacha18(i);