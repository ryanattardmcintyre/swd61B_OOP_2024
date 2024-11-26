// See https://aka.ms/new-console-template for more information
using Week2_EncapsulationAccessModifiers;



Student s;  //declaration of an object called s of type Student
s=new Student(); //this is the initialization of s; a place inside memory is created at this stage.
                 //making a call to the constructor



Student s2 = new Student("1234M");

DateTime d = new DateTime(2024,10, 8);



//Student s = new Student();

//Task: ask the user to input 100 Students to populate a group

List<Student> myGroupOfStudents = new List<Student>(); //in order for the list to be able to accept new students we need initialization

Student myStudent;

for (int i = 0; i < 5; i++)
{
    myStudent= new Student(); //is a new student. with a new initialization, we will have a new Student everytime
    
    Console.WriteLine("Input name: ");
    myStudent.FirstName = Console.ReadLine();

    myGroupOfStudents.Add(myStudent);

}


//later on

foreach (var student in myGroupOfStudents)
{
    Console.WriteLine($"\nFirstName: {student.FirstName}"); //in a new line for every student i will display the student's name
}
 


//typical question in the TCA


Student s1 = new Student(); 
s1.FirstName = "Joe";


Student s3 = new Student();
s2.FirstName = "Jane";

s2 = s1;

Console.WriteLine($"\nFirstName: {s2.FirstName}");






