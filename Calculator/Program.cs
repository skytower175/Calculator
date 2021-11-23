using System;

namespace Calculator
{
    class Program
    {
        public static int currentnumber = 0;
        public static Boolean run = true;
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator");

            while (run)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out int value))
                {
                    currentnumber = value;
                }
                else
                {
                    switch (input.ToLower())
                    {
                        case "+":
                            Add();
                            break;
                        case "-":
                            Sub();
                            break;
                        case "*":
                            Mult();
                            break;
                        case "/":
                            Div();
                            break;
                        case "exit":
                            run = false;
                            break;

                    }
                }
                Console.WriteLine(currentnumber);
            }


        }
        static void Add()
        {
            Console.WriteLine("please enter your number");
            if (int.TryParse(Console.ReadLine(), out int value))
            {
                currentnumber = currentnumber + value;
            }
        }
        static void Sub()
        {
            Console.WriteLine("please enter your number");
            if (int.TryParse(Console.ReadLine(), out int value))
            {
                currentnumber = currentnumber - value;
            }

        }
        static void Mult()
        {
            Console.WriteLine("please enter your number");
            if (int.TryParse(Console.ReadLine(), out int value))
            {
                currentnumber = currentnumber * value;
            }

        }
        static void Div()
        {
            Console.WriteLine("please enter your number");
            if (int.TryParse(Console.ReadLine(), out int value))
            {
                currentnumber = currentnumber / value;
            }

        }

    }
}
