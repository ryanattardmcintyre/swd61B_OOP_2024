using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_EncapsulationAccessModifiers
{
    /*
     * public - gives most access; it is accessible from everywhere (even other projects once a reference is added)
     * private - least accessible; it is not accessible outside the logical grouping it is contained in
     *           i.e if a method is made private, it cannot be called outside the class where it is declared in
     *           i.e if a class is made private, it cannot be called outside the namespace where it is declared in
     * protected - the component declared as protected can only be accessed from inherited classes only
     * internal - is accessible only within the library / project
     * 
     */ 

    public class Student
    {
        //constructor: it constructs objects in memory, the constructor is the first thing that runs
        //             bears the same name as the class
        //             a constructor is like a special method, however it doesn't have a return type
        //             secondary usage of a constructor is to initialize certain properties/fields
        //

        /// <summary>
        /// Default constructor because it has no parameters
        /// </summary>
        public Student()
        {
            password = "mcast123";
            units = new List<string>(); //we initialize objects like List<>
        }

        public Student(string id): this()
        {
            IdCard = id;
        }




        List<string> units; //declaration of a built-in class called List which allows us to add as many objects as we want

        //fields: are private data containers; is to store only data
        //        good practice is to keep fields private

        private string idCard;
        private string password; //camel casing notation

        //properties: are a way how you can control data being accessed from a field
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string IdCard //an example of a property accessing the field
        {
            get { return idCard; }
            set
            {
                bool isItANumber = false;
                value = value.ToUpper();
                char lastLetter = value[value.Length - 1];
                if (lastLetter =='A' || lastLetter =='L' || lastLetter == 'M')
                {
                    idCard = value; //data is stored in the field
                }
                else
                { //i'm finding that the input is not acceptable, hence i'm throwing an exception 
                    throw new Exception("Invalid input");
                }

            }
        }

        public string Email { get; set; }

        public string Password {
            get {

                string output = "";
                for (int i = 0; i < password.Length; i++)
                {
                    output += "*";
                }

                return output;
            
            } //returning the field value not the property value
            //set is being removed because i am forcing the user/another developer to go through the ChangePassword method instead
        }

        //methods:
        public void ChangePassword(string oldPassword, string newPassword)
        {
            if (oldPassword == password || password==null) {
                password = newPassword; //setting the field NOT the property
            }
        }


    }
}
