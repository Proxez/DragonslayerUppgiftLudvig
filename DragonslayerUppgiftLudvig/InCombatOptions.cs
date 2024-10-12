using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonslayerUppgiftLudvig;
internal class InCombatOptions
{



    static void CombatMenu()
    {
        while (true)
        {
            Random random = new Random();
            var combatMenuOption = Console.ReadKey().KeyChar;


            switch (combatMenuOption)
            {
                case 'a': // attack (ifsats med som kollar om du är mage/warrior, olika attacker)
                    if (Program.InputMage == true)
                        Hero.ChooseCharacterMage();
                    else if (Program.InputWarrior == true)
                        Hero.ChooseCharacterWarrior();
                    break;
                case 'r': // run
                    Console.WriteLine(random.Next(0, 10));
                    if (random.Next(0, 10) < 7)
                        Console.WriteLine("You are running from the dragon!");
                    else
                        Console.WriteLine("You didnt run away, try again or fight!");
                    break;
                default:
                    break;




            }


        }
    }
}
