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
    public static int HeroHP { get; set; }
    public static int Health { get; set; }


    public Hero(string playerName, int maxHealth, int strength, int armor, int spellPower, int level)
    {
        PlayerName = playerName;
        MaxHealth = maxHealth;
        Strength = strength;
        Armor = armor;
        SpellPower = spellPower;
        Level = level;
    }

    static void CombatHeroAttacks()
    {
        


    }



}
