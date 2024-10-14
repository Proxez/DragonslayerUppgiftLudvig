using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonslayerUppgiftLudvig;
internal class InCombatOptions
{
    //static bool runFromCombat = false;

    static void CombatMenu()
    {
        do
        {
            Random random = new Random();
            var combatMenuOption = Console.ReadKey().KeyChar;
            Console.WriteLine("a = attack, r = run");

            switch (combatMenuOption)
            {
                case 'a': // attack (ifsats med som kollar om du är mage/warrior, olika attacker)
                    AttackTarget();
                    break;
                case 'b':
                    //Bossfight
                    break;
                case 'h': // heal
                    HealToFullHealth();
                    break;
                default:
                    break;
            }
        } while (RunningAway() == true || Dragon.Health == 0);
    }

    private static void AttackTarget()
    {
        if (Program.InputMage == true)
            UseAttacksMage();
        else if (Program.InputWarrior == true)
            UseAttacksWarrior();
    }

    public static void UseAttacksMage()
    {
        Console.WriteLine("What spell do you want to use?");
        Console.WriteLine("f=fireball, a=arcaneblast, h=melee, r=run");
        

        var attacksMage = Console.ReadKey().KeyChar;
        do
        {
            switch (attacksMage)
            {
                case 'f':                    
                    Console.WriteLine("Casting Fireball!");
                    CombatMageFireball();
                    break;
                case 'a':
                    Console.WriteLine("Casting Arcane blast!");
                    CombatMageArcaneBlast();
                    break;
                case 'h':
                    Console.WriteLine("Trying to K/O your target!");
                    CombatMageMelee();
                    break;
                case 'r':
                    RunningAway();
                    break;
                default:
                    Console.WriteLine("Invalid option!");
                    break;
            }
        } while (RunningAway() == true || Dragon.Health == 0 || Hero.Health == 0);
    }
    static void UseAttacksWarrior()
    {
        Console.WriteLine("What attack do you want to use?");
        Console.WriteLine("h= Heroic strike, b=Bladestorm, o = Odin's Fury, r = Run");
        
        do
        {
            var attacksWarrior = Console.ReadKey().KeyChar;
            switch (attacksWarrior)
            {
                case 'h':
                    Console.Write("Using Heroic Strike!");
                    CombatWarriorHeroicStrike();
                    break;
                case 'b':
                    Console.Write("Using Bladestrom!");
                    CombatWarriorBladestorm();
                    break;
                case 'o':
                    Console.Write("Using Odin's Fury");
                    CombatWarriorOdinsFury();
                    break;
                case 'r':
                    RunningAway();
                    break;
                default:
                    Console.Write("Invalid option!");
                    break;
            }
        } while (RunningAway() == true || Dragon.Health == 0 || Hero.Health == 0);
    }
    static void HealToFullHealth()
    {
        if (Hero.HeroHP < Hero.MaxHealth)
            Hero.HeroHP = Hero.MaxHealth;
    }
    static bool RunningAway()
    {
        Random random = new Random();
        int randomGenRun = random.Next(1, 5);
        bool runFromTarget = false;

        if (randomGenRun <= 4)
        {
            Console.WriteLine("You ran away from the fight!");
            runFromTarget = true;
        }
        else
            Console.WriteLine("You failed, try again or fight!");

        return runFromTarget;
    }

    static int CombatMageFireball()
    {
        int combatFireball = 10;
        
        return Dragon.Health - combatFireball;
    }
    static int CombatMageArcaneBlast()
    {
        int combatArcaneBlast = 10;

        return Dragon.Health - combatArcaneBlast;
    }
    static int CombatMageMelee()
    {
        int combatMelee = 5;

        return Dragon.Health - combatMelee;
    }
    static int CombatWarriorHeroicStrike()
    {
        int combatHeroicStrike = 12;

        return Dragon.Health - combatHeroicStrike;
    }
    static int CombatWarriorBladestorm()
    {
        int combatBladestorm = 12;

        return Dragon.Health - combatBladestorm;
    }
    static int CombatWarriorOdinsFury()
    {
        int combatOdinsFury = 15;

        return Dragon.Health - combatOdinsFury;
    }
}
