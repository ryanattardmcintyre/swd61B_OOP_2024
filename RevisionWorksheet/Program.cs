namespace RevisionWorksheet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> myStudents = new List<Student>();
            List<Department> myDepartments = new List<Department>();

            Student myStud1 = new Student("Tom"); myStudents.Add(myStud1);
            Student myStud2 = new Student("Maria"); myStudents.Add(myStud2);
            Student myStud3 = new Student("Joe"); myStudents.Add(myStud3);

            Department myDept1 = new Department("Maths"); myDepartments.Add(myDept1);
            Department myDept2 = new Department("Physics"); myDepartments.Add(myDept2);
            Department myDept3 = new Department("Computing"); myDepartments.Add(myDept3);



            Company myCompany = new Company();
            Employee emp = new Employee(); emp.Name = "Joe BOrg";
            myCompany.Employees.Add(emp);

        }
    }


    class Student
    {
        public string Name { get; set; }

        public Student(string name) { Name= name; }
    }
    class Department
    {
        public string Name { get; set; }

        public Department(string name)
        {
            Name = name;
        }   
    }

    class Course
    {
        private string name;
        public Course (string name, List<Student> students, List<Department> departments)
        {
            this.name = name;
            Students = students;
            Departments = departments;

        }
        public List<Student> Students { get; set; }
        public List<Department> Departments { get; set; }


        public override string ToString()
        {
           string output = $"Name: {name}, Students: ";

            foreach (var s in Students)
            {
                output += s.Name + " " ;
            }
            output += ", Departments: ";
            foreach (var d in Departments)
            {
                output += d.Name + " ";
            }

            return output;
        }
    }



    class Employee
    {
        public string Name { get; set; }
    }

    class Company
    {
        public List<Employee> Employees { get; set; }
    }




    public abstract class Fish
    {
        public double Length { get; set; } //this way these properties are implemented and they can exist within an abstract class
        public double Weight { get; set; }

        public abstract void Eat(); //method like this has to be overriden in inheriting classes
     

    }

    public class Swordfish : Fish
    {
        public override void Eat()
        {
            Console.WriteLine( "smaller fish");
        }
    }


    public interface IFather
    {
        double Height();
        bool SnoreWhileASleep();
    }
    public interface IMother
    {
        string HairColor();
    }
    public class Child : IFather, IMother //it can inherit more than 1 interface
    {
        public string HairColor()
        {
            return "brown";
        }

        public double Height()
        {
            return 1;
        }

        public bool SnoreWhileASleep()
        {
            return false;
        }
    }
}