

namespace DragonslayerUppgiftLudvig;

internal class Program
{
    static void Main(string[] args)
    {
        IntroToTheGame();





    }

    private static void IntroToTheGame()
    {
        AskForPlayerName();
    }

    static void AskForPlayerName()
    {
        Console.WriteLine("Choose a playername: ");
        Hero.PlayerName = Console.ReadLine()!;
        Console.WriteLine("What type of hero do you want to play?");
        Console.WriteLine("Mage, Warrior");
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
