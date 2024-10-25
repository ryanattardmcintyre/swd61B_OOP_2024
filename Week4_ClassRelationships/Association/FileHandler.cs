using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_ClassRelationships.Association
{
    public class FileHandler
    {
        public string ReadFromFile(TextFile t) {

            string contents = File.ReadAllText(t.Path);
            return contents;
        
        }

        public void WriteToFile(TextFile t, string text) {
            System.IO.File.WriteAllText(t.Path, text);
        }

        public int WordCount(TextFile t) { 
            string contents = ReadFromFile(t);
            //hello, today is a friday

            var myArray =contents.Split(new char[] { ' ' });
            //array [0] = hello,
            //array [1] = today
            //array [2] = is
            //array [3] = a
            //array [4] = friday

            return myArray.Length;
        }



    }
}
