using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flashcards.Models;


namespace Flashcards.Data
{
    internal class FlashcardsContext : DbContext
    {
        // representation of tables in the database
        public DbSet<Flashcard> Flashcards { get; set; }
        public DbSet<Stack> Stacks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=FlashcardsAppDatabase;Trusted_Connection=True;"); // put this in config file
        }

    }
}
