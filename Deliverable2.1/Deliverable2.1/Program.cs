using System;

namespace Deliverable2
{
    class Program
    {
        private static string r;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Chatbot.");
            Console.WriteLine("ChatBot can respond to simple statements like hello, sup, hello there or bye");
            Console.WriteLine("What would you like to say to ChatBot?");

            int a = 1;
            int b = 1;
            int c = 1;
            
            while ((r != "hello") || (r != "sup") || (r != "hello there"))
            {   
                string r = Console.ReadLine().ToLower();

                if (a == 1 && r == "hello")
                {
                    Console.WriteLine("Hi good to see you");
                    a++;
                }
                else if (b == 1 && r == "sup")
                {
                    Console.WriteLine("I am good");
                    b++;
                }
                else if (c == 1 && r == "hello there")
                {
                    Console.WriteLine("General Kenobi");
                    c++;
                }
                else if (r == "bye")
                {
                    Console.WriteLine("Good bye!");
                    Environment.Exit(0);
                }
                else if ((r != "hello") && (r != "sup") && (r != "hello there"))
                {
                    Console.WriteLine("I'm sorry, I didn't understand.  Please try again.");
                }
                else if ((a >= 2) || (b >= 2) || (c >= 2))
                {
                    Console.WriteLine("I'm sorry you have already said that");
                }
                Console.WriteLine("What else would you like to say to ChatBot?");
                }
            }
        }
    }






