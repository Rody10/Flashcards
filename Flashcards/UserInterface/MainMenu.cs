using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flashcards.UserInterface
{
    internal static class MainMenu
    {
        public static void DisplayTitle()
        {
            Console.WriteLine("");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Flashcards Application Menu");
            Console.WriteLine("----------------------------");
            Console.WriteLine("");
        }
        public static void DisplayMainMenuOptions()
        {
            string? userChoice = "";
            bool terminateApp = false;
            while (!terminateApp)
            {
                Console.WriteLine("1. Manage Flashcard Stacks");
                Console.WriteLine("2. Study Session");
                Console.WriteLine("3. Study Session Data");
                Console.WriteLine("0. Exit");

                userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        StacksMenu.DisplayManageStacksMenu();
                        break;
                    case "2":
                        StudySessionMenu.DisplayStudySessionMenu();
                        break;
                    case "3":
                        StudySessionDataMenu.DisplayStudySessionDataMenu();
                        break;
                    case "0":
                        terminateApp = true;
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
}
