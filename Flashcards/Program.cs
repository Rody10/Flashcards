using Flashcards.UserInterface;

MainMenu.DisplayTitle();
MainMenu.DisplayMainMenuOptions();

/*
using (var context = new FlashcardsContext())
{
    var xhosa = new Stack("Xhosa");
    context.Add(xhosa);
    context.SaveChanges();

    var stack = context.Stacks.First(a => a.StackName == "Xhosa");
    if (stack != null)
    {
        var flashcard1 = new Flashcard("wake up", "vuka");
        var flashcard2 = new Flashcard("run", "gijima");
        var flashcard3 = new Flashcard("think", "cinga");

        stack.Flashcards.Add(flashcard1);
        stack.Flashcards.Add(flashcard2);
        stack.Flashcards.Add(flashcard3);
    }
    context.SaveChanges();
}
-------------------------------


Console.WriteLine("----------------------------");
Console.WriteLine("Flashcards Application Menu");
Console.WriteLine("----------------------------");
Console.WriteLine("");

bool terminateApp = false;

while (!terminateApp)
{
    string? userChoice = "";

    Console.WriteLine("1. Manage Flashcard Stacks");
    Console.WriteLine("2. Study Session");
    Console.WriteLine("3. Study Session Data");
    Console.WriteLine("0. Exit");

    userChoice = Console.ReadLine();

}
*/



