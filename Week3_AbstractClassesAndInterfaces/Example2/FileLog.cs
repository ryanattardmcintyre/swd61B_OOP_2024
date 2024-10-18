using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_AbstractClassesAndInterfaces.Example2
{
    public class FileLog : Log
    {
        public string FilePath { get; set; }

        public override void Save()
        {
            System.IO.File.WriteAllText(
                FilePath,
              $"Log at {Timestamp.ToShortDateString()}: {Message}, {Origin}, {User}"
                );
           
        }
    }
}
