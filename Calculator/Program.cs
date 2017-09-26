using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Program prog = new Program();//object needed to instantiate Class
            int num1, num2, operation;//variables we use in our app

            Console.WriteLine("Press any key to continue");//Telling user how he/she can exit app
            while (!(Console.ReadKey(true).Key == ConsoleKey.Escape))//while escape is not pressed continue looping
            {
                Console.WriteLine("Press ESC to stop");//Telling user how he/she can exit app
                Console.WriteLine("Enter first number");

                num1 = int.Parse(Console.ReadLine());//Reading user input

                Console.WriteLine("Choose your operation: ");
                Console.WriteLine("1. Addition (+) ");
                Console.WriteLine("2. Subtraction (-) ");            //Operator options
                Console.WriteLine("3. Division (/) ");
                Console.WriteLine("4. Multiplication (*) ");

                Console.WriteLine("Operation (1/2/3/4): ");
                operation = int.Parse(Console.ReadLine()); //reading user option

                

                if (operation == 1)
                {
                    Console.WriteLine("Enter the second number: ");
                    num2 = int.Parse(Console.ReadLine());
                    prog.Add(num1, num2);

                }
                else if (operation == 2)
                {
                    Console.WriteLine("Enter the second number: ");
                    num2 = int.Parse(Console.ReadLine());
                    prog.Subtract(num1, num2);
                }
                else if (operation == 3)                
                {
                    Console.WriteLine("Enter the second number: ");
                    num2 = int.Parse(Console.ReadLine());
                    prog.Divide(num1, num2);
                }
                else if (operation == 4)
                {
                    Console.WriteLine("Enter the second number: ");
                    num2 = int.Parse(Console.ReadLine());
                    prog.Multiply(num1, num2);
                }
                else
                {
                    Console.WriteLine("Invalid operation choice");
                }
            }
            
        }
        public void Add(int num1, int num2)
        {
            int result = num1 + num2;
            Console.WriteLine("Result " + result);
        }
        public void Subtract(int num1, int num2)
        {
            int result = num1 - num2;
            Console.WriteLine("Result " + result);
        }
        public void Divide(int num1, int num2)
        {
            int result = 0;
            if(num1 == 0)
            {
                Console.WriteLine("Tis Impossible");
            }
            else
            {
                result = num1 / num2;
                Console.WriteLine("Result: " + result);
            }
        }
        public void Multiply(int num1, int num2)
        {
            int result = num1 * num2;
            Console.WriteLine("Result " + result);
        }
    }
}
