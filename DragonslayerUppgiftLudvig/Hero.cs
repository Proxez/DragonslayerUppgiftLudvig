using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DragonslayerUppgiftLudvig;
internal class Hero
{
    public static int MaxHealth;
    public static int Strength { get; set; }
    public static int Armor { get; set; }
    public static int SpellPower { get; set; }
    public static int Level { get; set; }
    public static string? PlayerName;
    public static int Health { get; set; }
    


    public Hero(string playerName, int health, int strength, int armor, int spellPower, int level)
    {
        PlayerName = playerName;
        MaxHealth = health;
        Health = health;
        Strength = strength;
        Armor = armor;
        SpellPower = spellPower;
        Level = level;
    }
        
    public static void HealToFullHealth()
    {
        Health = MaxHealth;
        Console.WriteLine($"{PlayerName} heals to full health ({Health}/{MaxHealth})!");
    }

    public static void TakeDamage(int damage)
    {
        int reducedDamage = Math.Max(0, damage ); // Armor reduces damage (- Armor)
        Health = Math.Max(0, Health - reducedDamage);
        Console.WriteLine($"{PlayerName} takes {reducedDamage} damage! Health is now {Health}/{MaxHealth}.");
    }
    public static bool IsAlive()
    {
        return Health > 0;
    }
    public enum HeroType
    {
        Mage,
        Warrior
    }
}
