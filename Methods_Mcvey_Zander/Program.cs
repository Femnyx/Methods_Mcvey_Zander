using System;

namespace Methods_Mcvey_Zander
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a whole number!");
           
            //x is a placeholder for a number.
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter another whole number!");
            
            //y is a placeholder for a number.
            int y = Convert.ToInt32(Console.ReadLine());

            //Multiplies x (num1) and y (num2).
            Console.WriteLine(Multiply(x,y));

            //The Console asks the user for their name.
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            WelcomeUser(name);

            Goodbye();
        }

        static int Multiply(int num1, int num2)
        {
            //Multiplies num 1 and num2.
            return num1 * num2;
        }

        static void WelcomeUser(string username)
        {
            //The Console greets the user.
            Console.WriteLine($"Hello, {username}! It is nice to meet you!");
        }

        static void Goodbye()
        {
            //The Console tells the user to have a fantastic day.
            Console.WriteLine("Have a fantastic day!");
        }
    }
}
