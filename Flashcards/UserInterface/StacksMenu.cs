using Flashcards.Data;
using Flashcards.Models;
using System;
using System.Collections;
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
            bool goBackToMainMenu = false;
            Console.WriteLine("");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Manage Stacks Menu");
            Console.WriteLine("----------------------------");
            Console.WriteLine("");
            while (!goBackToMainMenu)
            {
                var stacksList = ManageStacks.GetListOfStacks();
                // get all the stacks and print the id and stack name 
                foreach (Models.Stack stack in stacksList)
                {
                    Console.WriteLine($"{stack.StackId}.{stack.StackName}");
                }
                Console.WriteLine("c.Create a Stack");
                Console.WriteLine("d.Delete a Stack");
                Console.WriteLine("e.Edit the name of a stack");
                Console.WriteLine("0.Main Menu");
                Console.WriteLine("");
                Console.WriteLine("Choose a stack of flashcards to interact with.");
                Console.WriteLine("You can also choose to create or delete a stack.");

                string? userChoice = Console.ReadLine();
                if (userChoice == "c")
                {
                    string nameOfStack = "";
                    Console.WriteLine("Enter the name of the stack you want to create");
                    nameOfStack = Console.ReadLine();
                    int addingOfStackWasSuccesful = ManageStacks.CreateStack(nameOfStack);
                    if (addingOfStackWasSuccesful>0)
                    {
                        Console.WriteLine("The stack was successfully added!");
                    }         
                }
                else if (userChoice == "d")
                {
                    int stackIdToDelete = GetIDOfStackToDelete();
                    int succeededInDeletingStack = ManageStacks.DeleteStack(stackIdToDelete);
                    if (succeededInDeletingStack > 0)
                    {
                        Console.WriteLine("Succesfully deleted the flashcard!");
                    }
                    else
                    {
                        Console.WriteLine("Could not delete the flashcard!");
                    }
                    break;
                }
                else if (userChoice == "e")
                {
                    var stacksListForEditing = ManageStacks.GetListOfStacks();
                    foreach (Models.Stack stack in stacksListForEditing)
                    {
                        Console.WriteLine($"{stack.StackId}.{stack.StackName}");
                    }
                    int idOfStackToEdit = GetIDOfStackToEdit();
                    string nameOfStack = GetNameForStack();
                    int succeededInEditingStack = ManageStacks.EditStack(idOfStackToEdit, nameOfStack);
                    if (succeededInEditingStack > 0)
                    {
                        Console.WriteLine("Successfully edited the flashcard!");
                    }
                    else
                    {
                        Console.WriteLine("Could not edit the flascard!");
                    }

                }
                else if (userChoice == "0")
                {
                    MainMenu.DisplayTitle();
                    MainMenu.DisplayMainMenuOptions();
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
        private static int GetIDOfStackToDelete()
        {
            Console.Write("What is the ID of the stack you want to delete?");
            string? stackIdToDelete = Console.ReadLine();
            int stackIdToDeleteAsInt;
            while (!int.TryParse(stackIdToDelete, out stackIdToDeleteAsInt))
            {
                Console.WriteLine("You should enter an integer. Please try again:");
            }
            return stackIdToDeleteAsInt;
        }

        private static int GetIDOfStackToEdit()
        {
            Console.Write("What is the ID of the stack you want to edit?");
            string? stackIdToEdit = Console.ReadLine();
            int stackIdToEditAsInt;
            while (!int.TryParse(stackIdToEdit, out stackIdToEditAsInt))
            {
                Console.WriteLine("You should enter an integer. Please try again:");
            }
            return stackIdToEditAsInt;
        }
        private static string GetNameForStack()
        {

            Console.WriteLine($"Enter name for the stack:");
            string? nameOfStack = Console.ReadLine();
            if (nameOfStack == null)
            {
                nameOfStack = "";
            }
            return nameOfStack;
        }

    }
            
}
