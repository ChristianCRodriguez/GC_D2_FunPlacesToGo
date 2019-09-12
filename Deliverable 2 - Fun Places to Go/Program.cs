using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deliverable_2___Fun_Places_to_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring variables to hold user input
            string user = "", userAction = "", numberOfGuestsInput;
            int numberOfGuestsOutput;

            Console.WriteLine("Hello, please enter your name");
            user = Console.ReadLine();

            Console.WriteLine("Hello, {0}, what are you in the mood for today?", user);

            Console.WriteLine("1) Action");
            Console.WriteLine("2) Chill Times");
            Console.WriteLine("3) Danger");
            Console.WriteLine("4) Good Food");

            Console.WriteLine("Please type in the number desired and press enter.");

            userAction = Console.ReadLine();
            //using to validate user input to be only options available
            while (userAction != "1" && userAction != "2" && userAction != "3" && userAction != "4")
            {
                Console.WriteLine("I'm sorry, but I did not understand that input, please try again.");
                
                userAction = Console.ReadLine();
            }

            Console.WriteLine("How many people are you bringing with you?");
            numberOfGuestsInput = Console.ReadLine();

            //using to validate user input to be only act
            while (!int.TryParse(numberOfGuestsInput, out numberOfGuestsOutput))
            {
                Console.WriteLine("I'm sorry, but I did not understand that input, please try again.");
                numberOfGuestsInput = Console.ReadLine();
            }
            

            //switch to check value of user action and then switch insde the case to check on  number of guests
            switch (userAction)
            {
                case "1":
                    if (numberOfGuestsOutput == 0)
                    {
                        Console.WriteLine("Okay if you’re in the mood for action, then you should go Stock Car Racing and travel in sneakers!");
                    }
                    else if (numberOfGuestsOutput >= 1 && numberOfGuestsOutput <= 4)
                    {
                        Console.WriteLine("Okay if you’re in the mood for action, then you should go Stock Car Racing and travel in a Sedan!");
                    }
                    else if(numberOfGuestsOutput >= 5 && numberOfGuestsOutput <= 10)
                    {
                        Console.WriteLine("Okay if you’re in the mood for action, then you should go Stock Car Racing and travel in a Volkswagen bus!");
                    }
                    else
                    {
                        Console.WriteLine("Okay if you’re in the mood for action, then you should go Stock Car Racing and travel in an airplane!");
                    }
                    break;
                case "2":
                    if (numberOfGuestsOutput == 0)
                    {
                        Console.WriteLine("Okay if you’re in the mood for chilling, then you should go hiking and travel in sneakers!");
                    }
                    else if (numberOfGuestsOutput >= 1 && numberOfGuestsOutput <= 4)
                    {
                        Console.WriteLine("Okay if you’re in the mood for chilling, then you should go hiking and travel in a Sedan!");
                    }
                    else if (numberOfGuestsOutput >= 5 && numberOfGuestsOutput <= 10)
                    {
                        Console.WriteLine("Okay if you’re in the mood for chilling, then you should go hiking and travel in a Volkswagen bus!");
                    }
                    else
                    {
                        Console.WriteLine("Okay if you’re in the mood for chilling, then you should go hiking and travel in an airplane!");
                    }
                    break;
                case "3":
                    if (numberOfGuestsOutput == 0)
                    {
                        Console.WriteLine("Okay if you’re in the mood for danger, then you should go sky diving and travel in sneakers!");
                    }
                    else if (numberOfGuestsOutput >= 1 && numberOfGuestsOutput <= 4)
                    {
                        Console.WriteLine("Okay if you’re in the mood for danger, then you should go sky diving and travel in a Sedan!");
                    }
                    else if (numberOfGuestsOutput >= 5 && numberOfGuestsOutput <= 10)
                    {
                        Console.WriteLine("Okay if you’re in the mood for danger, then you should go sky diving and travel in a Volkswagen bus!");
                    }
                    else
                    {
                        Console.WriteLine("Okay if you’re in the mood for danger, then you should go sky diving and travel in an airplane!");
                    }
                    break;
                case "4":
                    if (numberOfGuestsOutput == 0)
                    {
                        Console.WriteLine("Okay if you’re in the mood for good food, then you should go to taco bell and travel in sneakers!");
                    }
                    else if (numberOfGuestsOutput >= 1 && numberOfGuestsOutput <= 4)
                    {
                        Console.WriteLine("Okay if you’re in the mood for good food, then you should go to taco bell and travel in a Sedan!");
                    }
                    else if (numberOfGuestsOutput >= 5 && numberOfGuestsOutput <= 10)
                    {
                        Console.WriteLine("Okay if you’re in the mood for good food, then you should go to taco bell and travel in a Volkswagen bus!");
                    }
                    else
                    {
                        Console.WriteLine("Okay if you’re in the mood for good food, then you should go to taco bell and travel in an airplane!");
                    }
                    break;
            }

            Console.WriteLine("Have a good time! Goodbye.");
            Console.ReadLine();
        }
    }
}
