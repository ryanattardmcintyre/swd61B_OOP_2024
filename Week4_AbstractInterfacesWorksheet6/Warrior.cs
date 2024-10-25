using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_AbstractInterfacesWorksheet6
{
    //The Warrior has initial health of 300, initial mana of 0 and damage of 120. 
    public class Warrior: Character
    {

        //base(...) it will be calling the base constructor
        //          the base constructor is the constructor of the Character abstract class
        //          since the base constructor is protected, it is accessible from here
        public Warrior():base(0,300,120)
        { 
        }

        //13.	When the Warrior attacks, he deals damage to the opponent
        public override void Attack(Character target)
        {
            target.Health -= Damage;
        }
    }
}
