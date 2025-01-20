using Flashcards.Data;
using Flashcards.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flashcards.UserInterface
{
    internal class StacksMenu
    {
        public static void DisplayManageStacksMenu()
        {
            Console.WriteLine("");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Manage Stacks Menu");
            Console.WriteLine("----------------------------");
            Console.WriteLine("");

            var stacksList = ManageStacks.GetListOfStacks();
            // get all the stacks and print the id and stack name 
            foreach (Stack stack in stacksList)
            {
                Console.WriteLine($"{stack.StackId}.{stack.StackName}");
            }
            Console.WriteLine("c.Create a Stack");
            Console.WriteLine("d.Delete a Stack");
            Console.WriteLine("0.Main Menu");
            Console.WriteLine("");
            Console.WriteLine("Choose a stack of flashcards to interact with. " +
                "You can also choose to create or delete a stack." +
                " Enter 0 to go back to the main menu.");

            string? userChoice = Console.ReadLine();
            if (userChoice == "c")
            {
                // create a stack
                Console.WriteLine("you pressed c!");
            }
            else if (userChoice == "d")
            {
                // delete a stack
                Console.WriteLine("you pressed d!");
            }
            // this means a user entered a stack id otherwise show error
            else
            {
                if (!int.TryParse(userChoice, out int userChoiceAsInteger))
                {
                    Console.WriteLine("You entered invalid input. Please try again");
                }
                else // user input successfully converted to int. Now check if it is a valid stack id
                {
                    if (!HelperMenuMethods.CheckIfIdIsValid(stacksList, userChoiceAsInteger))
                    {
                        Console.WriteLine("You entered invalid input. Please try again");
                    }
                    else // user entered valid stack id
                    {
                        StackMenu.DisplayStackMenu(userChoiceAsInteger);
                    }
                }
            }      
        }
    }
}
