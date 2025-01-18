using Flashcards.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flashcards.Data
{
    internal class ManageStacks
    {
        public static List<Stack> GetListOfStacks()
        {
            List<Stack> stacksList = new List<Stack>();
            using (var context = new FlashcardsContext())
            {
                foreach(var stack in context.Stacks)
                {
                    stacksList.Add(stack);
                }
            }
            return stacksList;
        }
    }
}
