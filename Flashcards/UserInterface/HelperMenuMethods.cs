using Flashcards.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flashcards.UserInterface
{
    internal class HelperMenuMethods
    {
        public static bool CheckIfIdIsValid(List<Models.Stack> stacksList, int userSelection)
        {
            List<int> validStackIds = new List<int>();
            foreach (Models.Stack stack in stacksList)
            {
                validStackIds.Add(stack.StackId);
            }
            bool stackIdIsValid = validStackIds.Contains(userSelection);
            return stackIdIsValid;
        }
        public static bool CheckIfIdIsValid(List<Flashcard> flashcardsList, int userSelection)
        {
            List<int> validFlashcardIds = new List<int>();
            foreach (Flashcard flashcard in flashcardsList)
            {
                validFlashcardIds.Add(flashcard.FlashcardId);
            }
            bool flashcardIdIsValid = validFlashcardIds.Contains(userSelection);
            return flashcardIdIsValid;
        }
    }
}
