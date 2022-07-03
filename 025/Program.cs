Console.WriteLine("введите целое натуральное число N: ");
int number = Convert.ToInt32(Console.ReadLine());

void Zadacha23(int number)
{
   int count = 1;
   while (count <= number)
   {
        Console.WriteLine(count*count*count);
      count++;
   }
}
Zadacha23(number);

