using System;

namespace Boolean_Comparison_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Two different programs showing usage of while and do while with boolean comparison
            //while
            Console.WriteLine("Given these numbers: 16, 06, 68, 88, ?, 98");
            Console.WriteLine("What is the mystery number before 88?: ");
            int input1 = Convert.ToInt32(Console.ReadLine());
            bool number = input1 == 87;

            while (!number)
            {
                switch (input1)
                {
                    case 87:
                        Console.WriteLine("Congratulations you figure it out! Press enter for the next problem.");
                        number = true;
                        break;
                    default:
                        Console.WriteLine("Try again.");
                        Console.WriteLine("Hint: Try reading the numbers upsidedown.");
                        input1 = Convert.ToInt32(Console.ReadLine());
                        break;
                }
                Console.ReadLine();
            }

            //do while 
            Console.WriteLine("What is 6 + -5 * (10 / 10)?");
            int input2 = Convert.ToInt32(Console.ReadLine());
            bool number2 =  input2 == 1;

            do
            {
                switch (input2)
                {
                    case 0:
                        Console.WriteLine("Close but try again");
                        input2 = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 1:
                        Console.WriteLine("You are correct!");
                        number2 = true;
                        break;
                    default:
                        Console.WriteLine("Try again, hint: remnember to use PEMDAS.");
                        input2 = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!number2);
            Console.ReadLine(); 
        }
    }
}
