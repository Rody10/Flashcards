using Flashcards.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Flashcards.Data
{
    internal class ManageStacks
    {
        public static List<Models.Stack> GetListOfStacks()
        {
            List<Models.Stack> stacksList = new List<Models.Stack>();
            using (var context = new FlashcardsContext())
            {
                foreach(var stack in context.Stacks)
                {
                    stacksList.Add(stack);
                }
            }
            return stacksList;
        }
        public static int CreateStack(string stackName)
        {
            using (var context = new FlashcardsContext())
            {
                var newStack = new Models.Stack(stackName);
                context.Stacks.Add(newStack);
                return context.SaveChanges();
            }
        }
    }
}
