using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_AbstractInterfacesWorksheet6
{
    //The Priest has initial health of 125, initial mana of 200 and damage of 100.
    public class Priest: Character, IHeal
    {
        public Priest(): base(200, 125, 100)
        { }

        //. if he dealt 100 damage to the opponent, he restores 10% of that, or 10 health points
        public override void Attack(Character target)
        {
            target.Health -= Damage;
            Health += Convert.ToInt16( (Damage * 0.1));
        }

        //15.	When the healer Heals,
        //he reduces his mana by 100 and
        //heals the target character by increasing his health with 150 health points.
        public void Heal(Character target)
        {
            Mana -= 100;
            target.Health += 150;
        }
    }
}
