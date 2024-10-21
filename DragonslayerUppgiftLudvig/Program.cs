



using static DragonslayerUppgiftLudvig.Hero;

namespace DragonslayerUppgiftLudvig;

internal class Program
{
    public static Hero PlayerHero { get; set; }
    public static HeroType ChosenHeroType { get; set; }
    public static bool InputWarrior;
    public static bool InputMage;    
    static void Main(string[] args)
    {
        MenuToTheGame();
    }

    private static void MenuToTheGame()
    {
        bool exitGame = false;

        while (!exitGame)
        {
            Console.WriteLine("c = New Character, h = StartGame, s = SaveGame, q = QuitGame ");
            var menuOption = Console.ReadKey().KeyChar;
            Console.WriteLine();

            switch (menuOption)
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
                case 'q':   //quit game,
                    exitGame = true;
                    break;
                default:
                    Console.WriteLine("This option is not available!");
                    break;
            }
        }
    }
    public static void Battle()
    {
        Console.WriteLine($"A wild {Dragon.Name} appears!");

        while (Dragon.IsAlive() && IsAlive())
        {
            Console.WriteLine("\nWhat do you want to do? (a = attack, h = heal, r = run)");
            char action = Console.ReadKey().KeyChar;
            Console.WriteLine();

            switch (action)
            {
                case 'a':
                    int damage = Attack(ChosenHeroType);
                    Dragon.TakeDamage(damage);
                    if (Dragon.IsAlive())
                    {
                        string dragonAttack = Dragon.PerformRandomAttack();
                        int dragonDamage = Dragon.GetDamageFromAttack(dragonAttack);
                        TakeDamage(dragonDamage);
                    }
                    break;
                case 'h':
                    HealToFullHealth();
                    break;
                case 'r':
                    InCombatOptions.TryingToRunAway();
                    Console.WriteLine($"{PlayerName} ran away from the fight!");
                    return; // Exit combat
                default:
                    Console.WriteLine("Invalid option! Please choose again.");
                    break;
            }

            if (!IsAlive())
            {
                Console.WriteLine($"{PlayerName} has been slain by {Dragon.Name}!");
                return;
            }
            else if (!Dragon.IsAlive())
            {
                Console.WriteLine($"{PlayerName} has defeated {Dragon.Name}!");
            }
        }
    }
    private static void StartTheGame()
    {
        if (PlayerHero == null)
        {
            Console.WriteLine("No character created! Please create a character first.");
            return;
        }

        Dragon fireDragon = new Dragon("FireDragon", 150, 1, 1, 1, 10, new List<string> { "Fireball", "FireBreath", "Swipe" });
        

        InCombatOptions combatOptions = new InCombatOptions(PlayerHero, ChosenHeroType, fireDragon);
        InCombatOptions.CombatMenu();
    }

    private static void ChooseHeroType(string playerName)
    {
        Console.WriteLine("What type of hero do you want to play? (Mage or Warrior)");

        while (true)
        {
            string inputChar = Console.ReadLine()!.ToLower();

            if (inputChar == "mage")
            {
                Console.WriteLine("You chose a Mage!");
                ChosenHeroType = HeroType.Mage;
                PlayerHero = new Hero(playerName, 100, 5, 5, 10, 1);
                break;
            }
            else if (inputChar == "warrior")
            {
                Console.WriteLine("You chose a Warrior!");
                ChosenHeroType = HeroType.Warrior;
                PlayerHero = new Hero(playerName, 120, 10, 10, 2, 1);
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice! Please type 'Mage' or 'Warrior'.");
            }
        }
    }

    public static void AskForPlayerName()
    {
        Console.WriteLine("Choose a player name: ");
        string playerName = Console.ReadLine()!;

        ChooseHeroType(playerName);       
    }
}

