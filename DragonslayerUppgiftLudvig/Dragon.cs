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
    static int MaxHealth { get; set; }
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
        MaxHealth = health;
    }

    public static string RandomDragon()
    {
        Random random = new Random();
        random.Next(0, 3);
        List<string> DragonList = new List<string>();
        DragonList.Add("Firedragon");
        DragonList.Add("Frostdragon");
        DragonList.Add("Voiddragon");
        

        string dragonType = DragonList[random.Next(0, DragonList.Count)];
        return dragonType;
    }
    
    public static string FireDragonAttacks(string chosenAttack)
    {
        List<string> FireAttacklist = new List<string>();
        FireAttacklist.Add("Fireball");
        FireAttacklist.Add("FireBreath");
        FireAttacklist.Add("Swipe");
        //Dragon FireDragon = new Dragon("FireDragon", 200, 10, 10, 1, 0, FireAttacklist);

        Random random = new Random();
        random.Next(0, 3);
        chosenAttack = FireAttacklist[random.Next(AttackList.Count)];
        Console.WriteLine($"{Name} uses {chosenAttack}!");
        return chosenAttack;
    }

    public static string FrostDragonAttacks(string chosenAttack)
    {
        List<string> FrostAttacklist = new List<string>();
        FrostAttacklist.Add("Frostball");
        FrostAttacklist.Add("Ray of Frost");
        FrostAttacklist.Add("Swipe");
        //Dragon FrostDragon = new Dragon("FrostDragon", 200, 10, 10, 1, 0, FrostAttacklist);
        
        Random random = new Random();
        random.Next(0, 3);
        chosenAttack = FrostAttacklist[random.Next(AttackList.Count)];
        Console.WriteLine($"{Name} uses {chosenAttack}!");
        return chosenAttack;
    }
    public static string VoidDragonAttacks(string chosenAttack)
    {
        List<string> VoidAttacklist = new List<string>();
        VoidAttacklist.Add("Voidbolt");
        VoidAttacklist.Add("Void Torrent");
        VoidAttacklist.Add("Swipe");
        //Dragon VoidDragon = new Dragon("VoidDragon", 200, 10, 10, 1, 0, VoidAttacklist);

        Random random = new Random();
        random.Next(0, 3);
        chosenAttack = VoidAttacklist[random.Next(AttackList.Count)];
        Console.WriteLine($"{Name} uses {chosenAttack}!");
        return chosenAttack;
    }

    public static void TakeDamage(int damage)
    {
        //int reducedDamage = Math.Max(0, damage - Armor); // Armor reduces damage 
        Health = Math.Max(0,Health - damage);
        Console.WriteLine($"{Name} takes {damage} damage! Health is now {Health}/{MaxHealth}.");

        //return damage;
    }
    

    public static bool IsAlive()
    {
        return Health >= 0;
    }

}
