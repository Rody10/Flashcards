using System;
using System.Collections.Generic;
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

    }
}
