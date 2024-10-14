



namespace DragonslayerUppgiftLudvig;

internal class Program
{
    public static bool InputWarrior;
    public static bool InputMage;
    static string chooseWarrior = "Warrior";
    static string chooseMage = "Mage";
    static void Main(string[] args)
    {
        MenuToTheGame();








    }

    private static void MenuToTheGame()
    {
        bool breakLoop = false;

        do
        {
            Console.WriteLine("c = New Character, g = StartGame, s = SaveGame, q = QuitGame ");
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
                    if (menuChar == 'q')
                        breakLoop = true;
                    break;
                default:
                    Console.WriteLine("This option is not available!");
                    break;
            }
        }
        while (breakLoop == true);
    }

    private static void StartTheGame()
    {
        if (InputWarrior == true) 
            Console.WriteLine($"Welcome {Hero.PlayerName} the {chooseWarrior} to the game!");//"{mage / warrior}"
        else if (InputMage == true)
            Console.WriteLine($"Welcome {Hero.PlayerName} the {chooseMage} to the game!");



    }

    private static void IntroToTheGame()
    {



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
            Hero mage = new Hero(Hero.PlayerName, 100, 10, 10, 10, 1);
            InputMage = true;
        }
        else if (inputChar == "warrior")
        {
            Console.WriteLine("You choose a Warrior");
            Hero warrior = new Hero(Hero.PlayerName, 100, 10, 10, 10, 1);
            InputWarrior = true;
        }
    }
}

