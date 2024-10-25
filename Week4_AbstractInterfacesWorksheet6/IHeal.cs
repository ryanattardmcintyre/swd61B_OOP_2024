using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_AbstractInterfacesWorksheet6
{
    //We use an interface when you know what you need to create, but you don't have info
    //about the details of the implementation

    //The role of interfaces is there to dictate/force the inheriting classes to implement
    //the defined methods
    public interface IHeal
    {
        void Heal(Character target);
    }
}
