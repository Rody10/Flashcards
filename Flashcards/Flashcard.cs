using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Flashcards
{
    internal class Flashcard
    {
        public int FlashcardId { get; set; }

        public int StackId { get; set; }
        public Stack Stack { get; set; }
        [StringLength(100)]
        public string Front { get; set; }
        [StringLength(100)]
        public string Back { get; set; }

        public Flashcard(string front, string back)
        {
            Front = front;
            Back = back;

        } //Constructor
    }
}
