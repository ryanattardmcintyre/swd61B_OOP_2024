using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_AbstractInterfacesWorksheet6
{
    //1. INterface is like an Abstract class however it doesn't allow implementations
    //2. In an interface we declare only the method without implementation
    //3. Like an Abstract class, an interface is created to be inherited
    //4. You cannot instantiate an interface
    //5. One can inherit as many interfaces as he/she wants
    //   You can only inherit ONE abstract class/ordinary class
    public interface IAttack
    {
        void Attack(Character target);
    }
}
