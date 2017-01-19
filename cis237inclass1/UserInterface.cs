using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass1
{
    class UserInterface
    {
        // Methods
        public int GetUserInput()
        {
            // print menu
            PrintMenu();

            // get input
            string input = Console.ReadLine();


            // While input is not valid re-get the input

            while(input != "1" && input != "2")
            {
                //Print error message
                PrintErrorMessage();
                
                // Re-print the menu
                PrintMenu();

                input = Console.ReadLine();
            }

            // Return the validated input

            return int.Parse(input);
        }

        private void PrintMenu()
        {
            Console.WriteLine("what would you like to do?");
            Console.WriteLine("1 - Print List");
            Console.WriteLine("2 - Exit");
        }

        private void PrintErrorMessage()
        {
            Console.WriteLine("That is not a valid entry.");
            Console.WriteLine("Please make a valid choice");
            Console.WriteLine();
        }

        public void Output(string output)
        {
            Console.WriteLine(output);
        }
    }
}
