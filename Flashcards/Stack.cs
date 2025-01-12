using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Flashcards
{
    internal class Stack
    {
        public int StackId { get; set; }
        [StringLength(50)]
        public string StackName { get; set; }
        public ICollection<Flashcard> Flashcards { get; set; } = new List<Flashcard>();
        
        public Stack(string stackName)
        {
            StackName = stackName;

        } // Consructor
    }
}
