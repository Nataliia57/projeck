Console.WriteLine("Введите целое натуральное пятизначное число: ");
string number = Console.ReadLine();

void Zadacha19()
{
 if (number[0]==number[4] && number[1]==number[3])
    {
        Console.WriteLine("является палиндромом");
    }
    else
    {
        Console.WriteLine("не является палиндромом");
    }
}
Zadacha19();