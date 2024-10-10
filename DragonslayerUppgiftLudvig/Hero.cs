using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonslayerUppgiftLudvig;
internal class Hero
{

    public static string PlayerName { get; set; }    
    public static int Health { get; set; }
    public static int Strength { get; set; }
    public static int Armor { get; set; }
    public static int SpellPower { get; set; }
    public static int Level { get; set; }


    public static void ChooseCharacterMage()
    {
        BasicStatsMage();


    }
    public static void ChooseCharacterWarrior()
    {
        BasicStatsWarrior();
    }



    static void BasicStatsMage()
    {
        Health = 100;
        SpellPower = 10;
        Armor = 10;
        Level = 1;
    }
    static void BasicStatsWarrior()
    {
        Health = 125;
        Strength = 10;
        Armor = 12;
        Level = 1;
    }

}
