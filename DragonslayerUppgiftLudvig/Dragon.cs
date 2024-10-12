using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonslayerUppgiftLudvig;
internal class Dragon
{
    static int _health { get; set; }
    static int _strength { get; set; }
    static int _spellPower { get; set; }
    static int _level { get; set; }
    static int _armor { get; set; }




    static void DragonCombatAttacks()
    {
        while (_health > 0)
        {

        }


    }



    static void FireDragon()
    {
        Dragon FireDragon = new Dragon();
        _health = 150;
        _strength = 10;
        _spellPower = 10;
        _level = 1;
        _armor = 10;
    }
    static void VoidDragon()
    {
        Dragon VoidDragon = new Dragon();
        _health = 150;
        _strength = 10;
        _spellPower = 10;
        _level = 1;
        _armor = 10;
    }
    static void Frostdragon()
    {
        Dragon FrostDragon = new Dragon();
        _health = 150;
        _strength = 10;
        _spellPower = 10;
        _level = 1;
        _armor = 10;
    }








}
