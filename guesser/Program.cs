using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guesser
{
    class Guesser
    {
        // the "const" keyword makes the value of the variable final, meaning it can never be modified
        // a variable with "const" acts also as if it had the "static" modifier, meaning it can be accessed without needing to instantiate an object


        static void Main(string[] args)
        {
            int maxTrials = 10;
            int trials = 0;

            Console.WriteLine("Try guessing the right name! You have 10 tries!");

            while (true && trials <= maxTrials)
            {
                
                string name = Console.ReadLine();
                switch (name)
                {
                    case "Frida":
                        Console.WriteLine("Congratulations!, the application will close in 3 seconds!");
                        System.Threading.Thread.Sleep(3000);
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Sorry, please try again");
                        trials++;
                        break;

                }
                if (trials == maxTrials)
                {
                    Console.WriteLine("You're out of guesses!, the application will close in 3 seconds!");
                    System.Threading.Thread.Sleep(3000);
                    Environment.Exit(0);
                }
            }
        }
    }
}
