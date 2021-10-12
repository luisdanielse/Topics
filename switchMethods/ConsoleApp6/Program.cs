using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            string option = "A";

            while (option != "C")
            {
                option = displayOptions();

                switch (option)
                {
                    case "A":
                        doSomethingWithOptA();
                        break;
                    case "B":
                        Console.WriteLine("Lets do something with letter B");
                        break;
                    case "C":
                        Console.WriteLine("Thank you. Good bye");
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }

                /*
                if (option == "A")
                {
                    Console.WriteLine("Lets do something with letter A");
                }
                if (option == "B")
                {
                    Console.WriteLine("Lets do something with letter B");
                }
                */
            }
        }


        public static string displayOptions()
        {

            string option;
            Console.WriteLine("This are the options: ");

            Console.WriteLine("A for option a");
            Console.WriteLine("B for option b");
            Console.WriteLine("C for option quit");

            option = Console.ReadLine();
            Console.WriteLine("The option selected is {0}", option);
            return option;
        }

        public static void doSomethingWithOptA()
        {
            Console.WriteLine("Lets do something with letter A");
            Console.WriteLine("Lets do something with letter A");
            Console.WriteLine("Lets do something with letter A");
            Console.WriteLine("Lets do something with letter A");
            Console.WriteLine("Lets do something with letter A");
        }
        

    
    }

    
}
