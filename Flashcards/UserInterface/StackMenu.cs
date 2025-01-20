using Flashcards.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flashcards.UserInterface
{
    internal class StackMenu
    {
       public static void DisplayStackMenu(int stackId)
       {

            Console.WriteLine("");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Manage Stack Menu");
            Console.WriteLine("----------------------------");
            Console.WriteLine("");
            Console.WriteLine($"Current Working Stack: {stackId}"); // try to get stack name
            Console.WriteLine("");

            Console.WriteLine("1. View all flashcards in the stack");
            Console.WriteLine("2. View X number of cards in the stack (will show a prompt asking the user for X)");
            Console.WriteLine("3. Edit a flashcard");
            Console.WriteLine("4. Create a flashcard");
            Console.WriteLine("5. Delete a flashcard");
            Console.WriteLine("0. Return to the stacks menu");
            Console.WriteLine("");
            Console.WriteLine("Choose the operation you want to perform: ");

            string? userChoice = Console.ReadLine();

            switch (userChoice)
            {
                    case "1":
                    var flashcardsList = ManageStack.GetListOfFlashcards(stackId);
                    foreach(Flashcard flashcard in flashcardsList)
                    {
                        Console.WriteLine($"Flashcard Id:{flashcard.FlashcardId}    Front:{flashcard.Front}    Back:{flashcard.Back}");
                    }
                    break;
                case "2":
                    int numberOfRows = GetNumberOfRowsToReturn();
                    var xFlashcardsList = ManageStack.GetListOfFlashcards(stackId, numberOfRows);
                    foreach (Flashcard flashcard in xFlashcardsList)
                    {
                        Console.WriteLine($"Flashcard Id:{flashcard.FlashcardId}    Front:{flashcard.Front}    Back:{flashcard.Back}");
                    }
                    break;
                case "3":
                    var flashcardsListForEditing = ManageStack.GetListOfFlashcards(stackId);
                    
                    break;
                case "4":
                    //;
                    break;
                case "5":
                    //;
                    break;
                case "6":
                    //;
                    break;
                default:
                    Console.WriteLine("");
                    Console.WriteLine("You entered invalid input. Please try again");
                    Console.WriteLine("");
                    break;
                }
            }
     
        private static int GetNumberOfRowsToReturn()
        {
            Console.Write("How many cards do you want? ");
            string? userinput = Console.ReadLine();
            int userInputAsInt;
            if(int.TryParse(userinput, out userInputAsInt))
            {
                return userInputAsInt;
            }
            else
            {
                Console.WriteLine("You entered invalid input. Please try again.");
            }
            return 1; // fix
        }
    }   
}
