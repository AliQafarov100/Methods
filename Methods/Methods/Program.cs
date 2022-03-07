using System;

namespace Methods
{
    class Program
    {
        #region Tasks
        static void Main(string[] args)
        {
            //First Task.
            //Console.WriteLine("Enter a number: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //Nearest(number);


            //Second Task.
            //Console.WriteLine("Enter a first meaning");
            //int firstMean = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter a second meaning");
            //int secondMean = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the operation to be perfomed: ");
            //char operate = Convert.ToChar(Console.ReadLine());

            //Calculate(firstMean, secondMean, operate);

            //Third Task.
            //Console.WriteLine("Enter a number");
            //int num = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("The number of numbers divisible by the number corresponding to the condition:" + " " + Check(num));


        }

        public static int Check(int num)
        {
            int count = 0;

            for (int i = 0; i < num; i++)
            {

                if (num < 50)
                {
                    if (i % 3 == 0)
                    {
                        count++;

                    }
                }
                else if (num >= 50 && num <= 100)
                {
                    if (i % 5 == 0)
                    {
                        count++;
                    }
                }
                else if (num > 100)
                {
                    if (i % 8 == 0)
                    {
                        count++;
                    }
                }

            }
           
            return count;
        }

        public static int Calculate(int firtsMean, int secondMean, char operate)
        {
            int result = 0;

            if (operate == '+')
                 Console.WriteLine("The result: " + (result = firtsMean + secondMean));
            
            else if (operate == '-')
                Console.WriteLine("The result: " + (result = firtsMean - secondMean));
            
            else if (operate == '*')
                Console.WriteLine("The result: " + (result = firtsMean * secondMean));
           
            else if (operate == '/')
              Console.WriteLine("The result: " + (result = firtsMean / secondMean));


            return result;

        }

        public static int Nearest(int number)
        {
            int remind = (number / 7) * 7;
            int bigFunc = remind + 7;
            int littleFunc = remind + 3;
            int modulus = number % 7;

            if (modulus == 0)
            {
                Console.WriteLine("This number divisible by 7");
            }
           
            else if (modulus != 0)
            {
                for (int i = remind + 1; i < bigFunc; i++)
                {
                    if (number <= littleFunc)
                    {
                        Console.WriteLine("This number isn't divisible by 7. Nearest number divisible by 7: " + remind);
                        break;
                    }
                    else if (number > littleFunc && number <= bigFunc)
                    {
                        Console.WriteLine("This number isn't divisible by 7. Nearest number divisible by 7: " + bigFunc);
                        break;
                    }

                }
            }

            return number;
        }
        #endregion
    }
}
