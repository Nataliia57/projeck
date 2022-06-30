string number = "24978";
 NewMethod(number);

        void NewMethod(string currentnumber)
        {


            if (currentnumber.Length < 3)
            {
                Console.WriteLine("третьей цифры нет");
            }
            else if (currentnumber[2] != 0)
            {
                Console.WriteLine(currentnumber[2]);
            }
        }
 
