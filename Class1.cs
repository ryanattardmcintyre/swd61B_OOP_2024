using System;
using System.Collections.Generic;

public class University
{
    List<Department> departments;

    public void AddDepartment(Department d)
    {
        departments.Add(d);
    }
}

public class Department
{
    Person dean;
    List<Person> persons;

    public Department() //this replaces the constructor with the parameter
    {
        
    }

    public Person Dean { get; set; } 
    //we are not only using the instance of person to represent who is the Dean, we are also keeping a copy of that/ storing it

    public void AddToDepartment(Person p)
    {
        persons.Add(p);
    }
}

public class Person
{
    string name;
    string lastName;
    string idCard;
    Position position;

    public Person(Position p)
    {
        position = p;
    }
}

public class Position
{
    int id;
    string name;
}
