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
            string? userChoice = "";

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

            switch(userChoice)
                {
                    case "1":
                    var flashcardsList = ManageStack.GetListOfFlashcards(stackId);
                    foreach(Flashcard flashcard in flashcardsList)
                    {
                        Console.WriteLine($"{flashcard.FlashcardId} {flashcard.Front} {flashcard.Back}");
                    }
                    //;
                    break;
                case "2":
                    //;
                    break;
                case "3":
                    //;
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
    }
}
