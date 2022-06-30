Console.WriteLine("введите X1: ");
int X1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите Y1: ");
int Y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите X2: ");
int X2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите Y2: ");
int Y2 = Convert.ToInt32(Console.ReadLine());

void Zadacha21(int X1, int Y1, int X2, int Y2)
{
    Console.WriteLine(Math.Sqrt((Y2-Y1)*(Y2-Y1) + (X2-X1)*(X2-X1)));
}
Zadacha21(X1, Y1, X2, Y2);