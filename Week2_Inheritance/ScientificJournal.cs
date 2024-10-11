using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Inheritance
{
    public class ScientificJournal : Journal
    {

        public ScientificJournal() { } //default constructor

        public ScientificJournal(int issueNo, int month, string fieldOfStudy)
            :base(issueNo, month)
        {
            
            FieldOfStudy = fieldOfStudy;
        }

        public string FieldOfStudy { get; set; }

        public override void Print()
        {
            base.Print(); //in this case the base class is Journal, hence Journal's Print method will be executed first
            Console.Write($", Field of study: {FieldOfStudy}");
        }

    }
}
