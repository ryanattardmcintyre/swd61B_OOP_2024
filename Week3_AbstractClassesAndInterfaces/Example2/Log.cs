using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_AbstractClassesAndInterfaces.Example2
{
    //Log is normally some text you record to keep track of what was happening in a particular system
    public abstract class Log
    {
        public string User { get; set; }
        public string Message { get; set; }
        public DateTime Timestamp { get; set; }
        public string Origin { get; set; }

        //with virtual we are offering the possibility of the implementation to CHANGE
        public virtual void Print() {
            Console.WriteLine($"Log at {Timestamp.ToShortDateString()}: {Message}, {Origin}, {User}");
        }

        //with abstract the implementation doesn't even exist. forcing inherited classes to implement
        public abstract void Save();
        //where are we going to save our Log?
        //in a file? in a database? in memory? send it via email?
        //implementing this right now wouldn't make any sense
        


    }
}
