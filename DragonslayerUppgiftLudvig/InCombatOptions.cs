using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DragonslayerUppgiftLudvig;
internal class InCombatOptions
{
    private Hero _playerHero;
    private Hero.HeroType _heroType;
    private Dragon _dragon;

    public InCombatOptions(Hero playerHero, Hero.HeroType heroType, Dragon dragon)
    {
        _playerHero = playerHero;
        _heroType = heroType;
        _dragon = dragon;
    }

    public static void CombatMenu()
    {
        Console.WriteLine("What do you want to do? (a = attack, h = heal, r = run)");
        bool isFighting = true;

        while (isFighting)
        {
            var combatMenuOption = Console.ReadKey().KeyChar;
            Console.WriteLine();

            switch (combatMenuOption)
            {
                case 'a':// Start fighting
                    StartCombat();
                    break;
                case 'h':// Heal
                    HealToFullHealth();
                    break;

                default:
                    Console.WriteLine("Invalid option! Please choose again.");
                    break;
            }          

            if (!Hero.IsAlive())
            {
                Console.WriteLine($"{Hero.PlayerName} has been slain by {Dragon.Name}!");
                return;
            }
            else if (!Dragon.IsAlive())
            {
                Console.WriteLine($"{Hero.PlayerName} has defeated {Dragon.Name}!");
            }
        }

    }

    private static void StartCombat()
    {
        Console.WriteLine("You choose to start fighting dragons!");
        Program.Battle();
    }
    
    
    public static void CombatMageAttacks() //Attack for mage
    {
        Console.WriteLine("What spell do you want to use?");
        Console.WriteLine("f=fireball, a=arcaneblast, h=melee, r=run");

        var attacksMage = Console.ReadKey().KeyChar;
        switch (attacksMage)
        {
            case 'f':
                Console.WriteLine("\nCasting Fireball!");
                Dragon.TakeDamage(20);
                break;
            case 'a':
                Console.WriteLine("\nCasting Arcane Blast!");
                Dragon.TakeDamage(15);
                break;
            case 'h':
                Console.WriteLine("\nMelee attack!");
                Dragon.TakeDamage(5);
                break;
            case 'r':
                TryingToRunAway();
                break;

        }

    }
    public static void CombatWarriorAttacks() //Attack for warrior
    {
        Console.WriteLine("What attack do you want to use?");
        Console.WriteLine("h= Heroic strike, b=Bladestorm, o = Odin's Fury, r = Run");

        var attacksWarrior = Console.ReadKey().KeyChar;
        switch (attacksWarrior)
        {
            case 'h':
                Console.WriteLine("\nUsing Heroic Strike!");
                Dragon.TakeDamage(12);
                break;
            case 'b':
                Console.WriteLine("\nUsing Bladestorm!");
                Dragon.TakeDamage(20);
                break;
            case 'o':
                Console.WriteLine("\nUsing Odin's Fury!");
                Dragon.TakeDamage(16);
                break;
        }
    }
    static void HealToFullHealth()
    {
        if (Hero.Health < Hero.MaxHealth)
        {
            Console.WriteLine("You healed to full health!");
            Hero.Health = Hero.MaxHealth;
        }
        else
        {
            Console.WriteLine("Your health is already full!");
        }
    }

    public static bool TryingToRunAway()
    {
        Random random = new Random();
        int randomGenRun = random.Next(0, 5);

        if (randomGenRun <= 4)
        {
            Console.WriteLine("You ran away from the fight!");
            return true;
        }
        else
        {
            Console.WriteLine("You wasnt able to run from the fight!");
            return false;
        }
    }
}
