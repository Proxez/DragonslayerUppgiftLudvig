using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonslayerUppgiftLudvig;
internal class Hero
{

    //static string _playerName { get; set; }    
    public static int Health { get; set; }
    public static int Strength { get; set; }
    public static int Armor { get; set; }
    public static int SpellPower { get; set; }
    public static int Level { get; set; }
    private static string _playerName;

    public static string PlayerName
    {
        get { return _playerName; }
        set 
        { 
            if (_playerName == null)
                Program.AskForPlayerName();
        }
    }


    public static void ChooseCharacterMage()
    {
        Hero mage = new Hero();
        Health = 100;
        Strength = 0;
        SpellPower = 10;
        Armor = 10;
        Level = 1;

    }
    public static void ChooseCharacterWarrior()
    {
        Hero warrior = new Hero();
        Health = 125;
        Strength = 10;
        SpellPower = 0;
        Armor = 12;
        Level = 1;
    }



    

}
