



namespace DragonslayerUppgiftLudvig;

internal class Program
{
    static void Main(string[] args)
    {
        IntroToTheGame();






    }

    private static void MenuToTheGame()
    {
        Console.WriteLine("c = create character, g = start game, s = savegame, q = quitgame ");
        do
        {
            var menuChar = Console.ReadKey().KeyChar;

            switch (menuChar)
            {
                case 'c':   // create Character
                    AskForPlayerName();
                    break;
                case 'h':   // start game
                    StartTheGame();
                    break;
                case 's':   //save game
                    SaveGame.Saving();
                    break;
                case 'q':   //quit game
                    break;
                default:
                    Console.WriteLine("This option is not available!");
                    break;


            }
        }
        while (true);
    }

    private static void StartTheGame()
    {
        Console.WriteLine($"Welcome {Hero.PlayerName} the to the game!");//"{mage / warrior}"
        Console.WriteLine();





    }

    private static void IntroToTheGame()
    {

        MenuToTheGame();

    }

    public static void AskForPlayerName()
    {
        Console.WriteLine("Choose a playername: ");
        Hero.PlayerName = Console.ReadLine()!;
        Console.WriteLine("What type of hero do you want to play?");
        Console.WriteLine("Mage or Warrior");
        string inputChar = Console.ReadLine()!.ToLower();
        if (inputChar == "mage")
        {
            Console.WriteLine("You choose a Mage!");
            Hero.ChooseCharacterMage();

        }
        else if (inputChar == "warrior")
        {
            Console.WriteLine("You choose a Warrior");
            Hero.ChooseCharacterWarrior();
        }
    }
}
