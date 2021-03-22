using System;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
        start:
            Console.WriteLine("What type of measurements are you looking to convert (inch, foot, fidget spinner, meme)? ");
            string type = Console.ReadLine();

            if (type == "inch")
            {
                Console.WriteLine("How many units are you looking to convert? ");
                double inch = double.Parse(Console.ReadLine());
                double fidspin = inch * 3.5;
                if (inch == 1)
                    Console.WriteLine(inch + " inch equals " + fidspin + " fidget spinners.");
                else if (fidspin == 1)
                    Console.WriteLine(inch + " inches equals " + fidspin + " fidget spinner.");
                else
                    Console.WriteLine(inch + " inches equals " + fidspin + " fidget spinners.");
            }           
            else if (type == "foot")
            {
                Console.WriteLine("How many units are you looking to convert? ");
                double foot = double.Parse(Console.ReadLine());
                double memes = foot * 5;
                if (foot == 1)
                    Console.WriteLine(foot + " foot equals " + memes + " memes.");
                else if (memes == 1)
                    Console.WriteLine(foot + " feet equals " + memes + " meme.");
                else
                    Console.WriteLine(foot + " feet equals " + memes + " memes.");
            }

            else if (type == "fidget spinner")
            {
                Console.WriteLine("How many units are you looking to convert? ");
                double fidspin = double.Parse(Console.ReadLine());
                double inches = fidspin / 3.5;
                if (fidspin == 1)
                    Console.WriteLine(fidspin + " fidget spinner equals " + inches + " inches.");
                else if (inches == 1)
                    Console.WriteLine(fidspin + " fidget spinners equals " + inches + " inch.");
                else
                    Console.WriteLine(fidspin + " fidget spinners equals " + inches + " inches.");
            }

            else if (type == "meme")
            {
                Console.WriteLine("How many units are you looking to convert? ");
                double memes = double.Parse(Console.ReadLine());
                double feet = memes / 5;
                if (memes == 1)
                    Console.WriteLine(memes + " meme equals " + feet + " feet.");
                else if (feet == 1)
                    Console.WriteLine(memes + " memes equals " + feet + " foot.");
                else
                    Console.WriteLine(memes + " memes equals " + feet + " feet.");
            }
            else
            {
                Console.WriteLine("Incorrect imput.  Try again.");
                goto start;
            }
        query:
            {
                Console.WriteLine("Would you like to try again? (yes or no)");
                string yesno = Console.ReadLine();
                if (yesno == "no")
                {
                    Console.WriteLine("Thank you for participating.");
                    Environment.Exit(0);
                }

                else if (yesno == "yes")
                {
                    goto start;
                }
                else
                {
                    Console.WriteLine("Invalid imput.  Would you like to try again? (yes or no)");
                    goto query;
                }
        }
    }
}
}

        







    

