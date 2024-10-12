using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonslayerUppgiftLudvig;
internal class Dragon
{
    public string Name { get; set; }
    static int Health { get; set; }
    static int Strength { get; set; }
    static int SpellPower { get; set; }
    static int Level { get; set; }
    static int Armor { get; set; }
    public Dragon(string name, int health, int strength, int spellPower, int lvl, int armor)
    {
        Name = name;
        Health = health;
        Strength = strength;
        SpellPower = spellPower;
        Level = lvl;
        Armor = armor;
    }


    public static void RandomGen()
    {
        Random randomGen = new Random();
        int printGenNr = randomGen.Next(1, 3);

        Console.WriteLine(printGenNr);
    }

    Dragon FireDragon = new Dragon("FireDragon", 100, 10, 10, 1, 10);

    Dragon VoidDragon = new Dragon("VoidDragon", 100, 10, 10, 1, 10);

    Dragon FrostDragon = new Dragon("FrostDragon", 100, 10, 10, 1, 10);









}
