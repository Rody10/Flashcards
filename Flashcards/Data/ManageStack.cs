using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flashcards.Data
{
    internal class ManageStack
    {
        public static List<Flashcard> GetListOfFlashcards(int stackId)
        {
            using (var context = new FlashcardsContext())
            {
                var flashcardsList = context.Flashcards.Where(x => x.StackId == stackId).ToList();
                return flashcardsList;
            }  
        }

        public static List<Flashcard> GetListOfFlashcards(int stackId, int numberOfRecords)
        {
            using (var context = new FlashcardsContext())
            {
                var flashcardsList = context.Flashcards.Where(x => x.StackId == stackId).Take(numberOfRecords).ToList();
                return flashcardsList;
            }
        }

        // Returns true if flashcard was successfully updated. Otherwise returns false.
        public static bool EditFlashcard(int flashcardId, string front, string back)
        {
            using (var context = new FlashcardsContext())
            {
                var flashcard = context.Flashcards.FirstOrDefault(x => x.FlashcardId == flashcardId);

                if (flashcard != null)
                {
                    flashcard.Front = front;
                    flashcard.Back = back;
                    return true;
                }
                
                else
                {
                    return false;
                }
            }
        }


    }
}
