using System;
using System.Linq;

namespace PrimeChecker
{
    class Program
    {
        static void ShowPrompt(string message=null)
        {
            // this is the prompt the user sees throughout the program
            // the first time it's shown, the message is blank. 

            Console.WriteLine(new string('-', 40));

            if (message != null){
                Console.WriteLine(message + "\n");
            }

            Console.WriteLine("Please enter a number or press q to quit");
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("\nYour Entry:");
        }

        static void Main(string[] args)
        {
            // this bool keeps the menu showing
            bool appClosed = false;

            // message defaults to blank
            string message = "\n";
            
            while (!appClosed){

                Console.Clear();
                ShowPrompt(message);
                
                // read the input 
                string number = Console.ReadLine();
                
                // check for a request to quit
                if (number != null && number.Contains('q')){ appClosed = true; }

                // check if it's a number 
                bool isNumber = Int32.TryParse(number, out int inputNmbr);

                if (isNumber)
                {
                    if (CheckForPrime.IsNumberPrime(inputNmbr)){
                        message = "\n" + number + " is a prime number";
                    }
                    else{
                        message = "\n" + number + " is NOT a prime number";
                    }
                }
                else{
                    message = "You entered " + number + "\nThis is not a number";
                }
            }
        }
    }
}
