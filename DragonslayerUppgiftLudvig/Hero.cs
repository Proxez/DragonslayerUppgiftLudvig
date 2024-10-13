using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DragonslayerUppgiftLudvig;
internal class Hero
{
    public static int Health { get; set; }
    public static int Strength { get; set; }
    public static int Armor { get; set; }
    public static int SpellPower { get; set; }
    public static int Level { get; set; }
    private static string PlayerName;
    Hero mage = new Hero(PlayerName, 100, 10, 10, 10, 1);
    Hero warrior = new Hero(PlayerName, 125, 10, 10, 12, 1);

    public Hero(string playerName, int health, int strength, int armor, int spellPower, int level)
    {
        PlayerName = playerName;
        Health = health;
        Strength = strength;
        Armor = armor;
        SpellPower = spellPower;
        Level = level;
    }


    public static void UseAttacksMage()
    {
        Console.WriteLine("What spell do you want to use?");
        Console.WriteLine("f=fireball, a=arcaneblast, h=melee, r=run");
        int combatFireball = 10;
        int combatArcaneblast = 10;
        int combatMelee = 5;
        Random random = new Random();
        int randomGenRun = random.Next(1, 5);
        bool runFromTarget = false;

        var attacksMage = Console.ReadKey().KeyChar;
        do
        {
            switch (attacksMage)
            {
                case 'f':
                    Console.WriteLine("Casting Fireball!");
                    BackingText(3);
                    break;
                case 'a':
                    Console.WriteLine("Casting Arcane blast!");
                    BackingText(3);
                    break;
                case 'h':
                    Console.WriteLine("Trying to K/O your target!");
                    BackingText(3);
                    break;
                case 'r':
                    if (randomGenRun <= 4)
                    {
                        Console.WriteLine("You ran away from the fight!");
                    }
                    else
                        Console.WriteLine("You failed, try again or fight!");
                    break;
                default:
                    Console.WriteLine("Invalid option!");
                    break;
            }
        } while (runFromTarget == true);//combatFightDragonHealth == 0 
    }

    static void UseAttacksWarrior()
    {
        Console.WriteLine("What attack do you want to use?");

        var attacksWarrior = Console.ReadKey().KeyChar;
        switch (attacksWarrior)
        {
            case 'f':
                Console.Write("Using Heroic Strike!");
                break;
            case 'a':
                Console.Write("Using Recklessness!");
                break;
            case 'h':
                Console.Write("Using Odin's Fury");
                break;
            case 'r':
                Console.Write("You are trying to runaway from the fight!");
                break;
            default:
                Console.Write("Invalid option!");
                break;
        }

    }

    static void BackingText(int repeatCount)
    {
        string dots = new string('.', repeatCount);
        Console.Write(dots);
        Thread.Sleep(750);
        for (int i = 0; i < repeatCount; i++)
            Console.Write("\b \b");
    }
}
