// void Zadacha17(int x , int y)
//{
//if (x> 0 && y> 0) Console.WriteLine("Первая четверть");
// else if (x< 0 && y> 0) Console.WriteLine("Вторая четверть");
//else if (x< 0 && y< 0) Console.WriteLine("Третья четверть");
// else  Console.WriteLine("Четвертая четверть");

//}

// Zadacha17(4, 6);


        void Zadacha17()
        {
            Console.WriteLine("Введите число x");
            int numberA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число y");
            int numberB = Convert.ToInt32(Console.ReadLine());

            if (numberA > 0 & numberB > 0)
            {
                Console.WriteLine("1 четверть");
            }
            else if (numberA < 0 & numberB > 0)
            {
                Console.WriteLine("2 четверть");
            }
            else if (numberA < 0 & numberB < 0)
            {
                Console.WriteLine("3 четверть");
            }
            else if (numberA > 0 & numberB < 0)
            {
                Console.WriteLine("4 четверть");
            }
        }
        Zadacha17();
