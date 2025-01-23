using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

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

        public static int EditFlashcard(int flashcardId, string front, string back)
        {
            using (var context = new FlashcardsContext())
            {
                var flashcard = context.Flashcards.FirstOrDefault(x => x.FlashcardId == flashcardId);

                if (flashcard != null)
                {
                    flashcard.Front = front;
                    flashcard.Back = back;
                }            
                return context.SaveChanges();
            }
           
        }
        
        public static int AddFlashcard(int stackId, string front, string back)
        {
            using (var context = new FlashcardsContext())
            {
                var newFlashcard = new Flashcard(stackId, front, back);
                context.Flashcards.Add(newFlashcard);
                return context.SaveChanges();
            }
        }

        public static int DeleteFlashcard(int flashcardId)
        {
            using (var context = new FlashcardsContext())
            {
                var flashcard = new Flashcard { FlashcardId = flashcardId };
                context.Flashcards.Attach(flashcard);
                context.Flashcards.Remove(flashcard);
                return context.SaveChanges();
            }
        }

        public static string GetStackName(int stackId)
        {
            using (var context = new FlashcardsContext())
            {
                var stack = context.Stacks.FirstOrDefault(x => x.StackId == stackId);
                if (stack != null)
                {
                    return stack.StackName;
                }
                return "Stack name not found!";
            }
        }



    }
}
