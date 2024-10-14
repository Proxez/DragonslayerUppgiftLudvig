using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace DragonslayerUppgiftLudvig;
internal class Dragon
{
    public static string? Name { get; set; }
    public static int Health { get; set; }
    static int Strength { get; set; }
    static int SpellPower { get; set; }
    static int Level { get; set; }
    static int Armor { get; set; }
    public static List<string> AttackList { get; private set; }
    public Dragon(string name, int health, int strength, int spellPower, int lvl, int armor, List<string> attackList)
    {
        Name = name;
        Health = health;
        Strength = strength;
        SpellPower = spellPower;
        Level = lvl;
        Armor = armor;
        AttackList = attackList;
    }
    public static int GetDamageFromAttack(string attack)
    {
        return attack switch
        {
            "Fireball" or "Frostball" or "Voidbolt" => SpellPower * 2,
            "Swipe" => Strength * 1,
            "FireBreath" or "Ray of Frost" or "Void Torrent" => SpellPower * 3,
            _ => 0
        };
    }
    public static string PerformRandomAttack()
    {
        Random random = new Random();
        string chosenAttack = AttackList[random.Next(AttackList.Count)];
        Console.WriteLine($"{Name} uses {chosenAttack}!");
        return chosenAttack;
    }
    //Dragon FireDragon = new Dragon("FireDragon", 100, 10, 10, 1, 10);

    //Dragon VoidDragon = new Dragon("VoidDragon", 100, 10, 10, 1, 10);

    //Dragon FrostDragon = new Dragon("FrostDragon", 100, 10, 10, 1, 10);

    static string FireDragonAttacks()
    {
        List<string> FireAttacklist = new List<string>();
        FireAttacklist.Add("Fireball");
        FireAttacklist.Add("FireBreath");
        FireAttacklist.Add("Swipe");

        Random random = new Random();
        random.Next(0, 3);
        if (random.Next(0, 3) == 1)
        {
            Console.WriteLine("Using Fireball");
            return FireAttacklist[0];
        }
        else if (random.Next(0, 3) == 2)
        {
            Console.WriteLine("Using FireBreath");
            return FireAttacklist[1];
        }
        else
            return FireAttacklist[2];
        }
    
    static string FrostDragonAttacks()
    {
        List<string> FrostAttacklist = new List<string>();
        FrostAttacklist.Add("Frostball");
        FrostAttacklist.Add("Ray of Frost");
        FrostAttacklist.Add("Swipe");

        Random random = new Random();
        random.Next(0, 3);
        if (random.Next(0, 3) == 1)
        {
            Console.WriteLine("Using Frostball");
            return FrostAttacklist[0];
        }
        else if (random.Next(0, 3) == 2)
        {
            Console.WriteLine("Using Ray of Frost");
            return FrostAttacklist[1];
        }
        else
            return FrostAttacklist[2];



    }
    static string VoidDragonAttacks()
    {
        List<string> VoidAttacklist = new List<string>();
        VoidAttacklist.Add("Voidbolt");
        VoidAttacklist.Add("Void Torrent");
        VoidAttacklist.Add("Swipe");

        Random random = new Random();
        random.Next(0, 3);
        if (random.Next(0, 3) == 1)
        {
            Console.WriteLine("Using Frostball");
            return VoidAttacklist[0];
        }
        else if (random.Next(0, 3) == 2)
        {
            Console.WriteLine("Using Ray of Frost");
            return VoidAttacklist[1];
        }
        else
            return VoidAttacklist[2];


    }
    
    public static void TakeDamage(int damage)
    {
        Health = Math.Max(0, Health - Math.Max(0, damage - Armor));
        Console.WriteLine($"{Name} takes {damage} damage! It has {Health} health remaining.");
    }

    public static bool IsAlive()
    {
        return Health > 0;
    }

}
