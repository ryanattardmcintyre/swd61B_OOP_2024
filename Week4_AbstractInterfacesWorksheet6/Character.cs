using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_AbstractInterfacesWorksheet6
{
    //abstract is like an interface however it allows some of the methods to be left
    //not implemented and some may be implemented
    //but again it cannot be instantiated

    //in abstract class when a method is marked abstract we are forcing any inheriting classes
    //to implement that method

    //an abstract cannot be instantiated
    public abstract class Character : IAttack
    {

        protected Character(int mana, int health, int damage) {
            Mana = mana;
            Health = health; 
            Damage = damage;
        }

        //when a property has the get and set defined it is considered to be implemented
        //hence they can exist in an abstract class
        public int Mana { get; set; }
        public int Health { get; set; }
        public int Damage { get; set; }


        public abstract void Attack(Character target);
      
    }
}
