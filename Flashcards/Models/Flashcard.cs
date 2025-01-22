using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Flashcards.Models;

namespace Flashcards
{
    internal class Flashcard
    {
        public int FlashcardId { get; set; }

        public int StackId { get; set; }

        [StringLength(100)]
        public string Front { get; set; }

        [StringLength(100)]
        public string Back { get; set; }

        public Flashcard(int stackId, string front, string back)
        {
            StackId = stackId;
            Front = front;
            Back = back;

        } //Constructor
        public Flashcard()
        {
        } //Proxy constructor to allow for delitions usinf stubs - ef core
    }
}
