using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonslayerUppgiftLudvig;
internal class InCombatOptions
{
    static bool runFromCombat = false;



    static void CombatMenu()
    {
        do
        {
            Random random = new Random();
            var combatMenuOption = Console.ReadKey().KeyChar;
            Console.WriteLine("a = attack, r = run");

            switch (combatMenuOption)
            {
                case 'a': // attack (ifsats med som kollar om du är mage/warrior, olika attacker)
                          //if (Program.InputMage == true)
                          //Hero.ChooseCharacterMage();
                          //else if (Program.InputWarrior == true)
                          //Hero.ChooseCharacterWarrior();
                    break;
                case 'r': // run
                    Console.WriteLine(random.Next(0, 10));
                    if (random.Next(0, 10) < 9)
                    {
                        Console.WriteLine("You are running from the dragon!");
                        runFromCombat = true;
                    }

                    else
                        Console.WriteLine("You didnt run away, try again or fight!");
                    break;
                default:
                    break;




            }


        } while (runFromCombat == true || Dragon.Health == 0);
    }
    static void DragonCombatAttack()
    {
        //do
        //{
        //Dragon.FireDragon();








        //} while (Dragon._health > 0);


    }
}
