using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonslayerUppgiftLudvig;
internal class BasicDragonStats
{
    private int _health = 150;
    private int _strength = 10;
    private int _spellPower = 10;
    private int _level = 1;
    private int _armor = 10;

    public int Health
    {
        get { return _health; }
        set { _health = value; }
    }

    public int Strength
    {
        get { return _strength; }
        set { _strength = value; }
    }

    public int SpellPower
    {
        get { return _spellPower; }
        set { _spellPower = value; }
    }

    public int Level
    {
        get { return _level; }
        set { _level = value; }
    }

    public int Armor
    {
        get { return _armor; }
        set { _armor = value; }
    }





    
}
