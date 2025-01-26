using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Flashcards.Models
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

        } // Constructor

        public Stack()
        {
        } //Proxy constructor to allow for delitions using stubs - ef core
    }
}
