using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DragonslayerUppgiftLudvig.Hero;

namespace DragonslayerUppgiftLudvig;
internal class InCombatOptions
{
    private Hero _playerHero;
    private HeroType _heroType;
    private Dragon _dragon;

    public InCombatOptions(Hero playerHero, HeroType heroType, Dragon dragon)
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
                case 'a':
                    PlayerAttack();
                    break;
                case 'h':
                    HealPlayer();
                    break;
                case 'r':
                    if (TryRunningAway())
                    {
                        Console.WriteLine($"{Hero.PlayerName} successfully ran away!");
                        return; // Exit combat
                    }
                    else
                    {
                        Console.WriteLine("You failed to run away, the fight continues!");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid option! Please choose again.");
                    break;
            }

            if (Dragon.IsAlive())
            {
                DragonAttack();
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
        //do
        //{
        //    Random random = new Random();
        //    var combatMenuOption = Console.ReadKey().KeyChar;
        //    Console.WriteLine("a = attack, r = run");

        //    switch (combatMenuOption)
        //    {
        //        case 'a': // attack (ifsats med som kollar om du är mage/warrior, olika attacker)
        //            AttackTarget();
        //            break;
        //        case 'b':
        //            //Bossfight
        //            break;
        //        case 'h': // heal
        //            HealToFullHealth();
        //            break;
        //        default:
        //            break;
        //    }
        //} while (RunningAway() == true || Dragon.Health == 0);
    } 
    private static void PlayerAttack()
    {
        int playerDamage = Hero.Attack(HeroType.Mage);
        Dragon.TakeDamage(playerDamage);
    }

    private static void AttackTarget()
    {
        if (Program.InputMage)
        {
            Console.WriteLine("\nYou are a Mage. Choose your attack:");
            HandleAttacks("f=Fireball", "a=Arcane Blast", "h=Melee", CombatMageAttacks);
        }
        else if (Program.InputWarrior)
        {
            Console.WriteLine("\nYou are a Warrior. Choose your attack:");
            HandleAttacks("h=Heroic Strike", "b=Bladestorm", "o=Odin's Fury", CombatWarriorAttacks);
        }
    }

    private static void HandleAttacks(string attack1, string attack2, string attack3, Action<char> attackAction)
    {
        Console.WriteLine($"{attack1}, {attack2}, {attack3}, r=Run");
        var attackOption = Console.ReadKey().KeyChar;

        switch (attackOption)
        {
            case 'f':
            case 'a':
            case 'h':
            case 'b':
            case 'o':
                attackAction(attackOption);
                break;
            case 'r':
                TryRunningAway();
                break;
            default:
                Console.WriteLine("Invalid option!");
                break;
        }
    }

    public static void CombatMageAttacks(char attack) //Attack for mage
    {
        Console.WriteLine("What spell do you want to use?");
        Console.WriteLine("f=fireball, a=arcaneblast, h=melee, r=run");

        var attacksMage = Console.ReadKey().KeyChar;
        switch (attack)
        {
            case 'f':
                Console.WriteLine("\nCasting Fireball!");
                Dragon.TakeDamage(10);
                break;
            case 'a':
                Console.WriteLine("\nCasting Arcane Blast!");
                Dragon.TakeDamage(12);
                break;
            case 'h':
                Console.WriteLine("\nMelee attack!");
                Dragon.TakeDamage(5);
                break;
        }

    }
    public static void CombatWarriorAttacks(char attack) //Attack for warrior
    {
        Console.WriteLine("What attack do you want to use?");
        Console.WriteLine("h= Heroic strike, b=Bladestorm, o = Odin's Fury, r = Run");

        switch (attack)
        {
            case 'h':
                Console.WriteLine("\nUsing Heroic Strike!");
                Dragon.TakeDamage(12);
                break;
            case 'b':
                Console.WriteLine("\nUsing Bladestorm!");
                Dragon.TakeDamage(15);
                break;
            case 'o':
                Console.WriteLine("\nUsing Odin's Fury!");
                Dragon.TakeDamage(20);
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
    private static void HealPlayer()
    {
        HealToFullHealth();
    }
    static bool TryRunningAway()
    {
        Random random = new Random();
        int randomGenRun = random.Next(1, 6);

        if (randomGenRun <= 4)
        {
            Console.WriteLine("You ran away from the fight!");
            return true;
        }
        else
        {
            Console.WriteLine("You failed, try again or fight!");
            return false;
        }
    }
    private static void DragonAttack()
    {
        string dragonAttack = Dragon.PerformRandomAttack();
        int dragonDamage = Dragon.GetDamageFromAttack(dragonAttack);
        Hero.TakeDamage(dragonDamage);
    }
}
