Console.WriteLine("введите целое натуральное число N: ");
int number = Convert.ToInt32(Console.ReadLine());

void Zadacha22(int number)
{
   int count = 1;
   while (count <= number)
   {
        Console.WriteLine(count*count);
      count++;
   }
}
Zadacha22(number);



