using System;

namespace MetanitLesson1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Make your deposit: ");
            decimal num = decimal.Parse(Console.ReadLine());
            decimal percent;

            if (num > 0 && num < 100)
            {
                percent = num * 5 / 100;
            }
            else if (num >= 100 && num <= 200)
            {
                percent = num * 7 / 100;
            }
            else if (num > 200)
            {
                percent = num * 10 / 100;
            }
            else
            {
                throw new Exception("Wrong deposit amount!");
            }

            num += percent + 15; 

            Console.WriteLine($"The amount after adding the percent and the bonus is {num}");

            Console.ReadLine();
        }
    }
}
