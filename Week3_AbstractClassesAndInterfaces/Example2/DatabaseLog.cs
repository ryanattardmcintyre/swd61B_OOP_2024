using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_AbstractClassesAndInterfaces.Example2
{
    public class DatabaseLog : Log
    {
        public string ConnectionString { get; set; }
        public override void Save()
        {
            //initiate a number of classes
            //write into a table
            //will be implemented when we do databases...
        }
    }
}
