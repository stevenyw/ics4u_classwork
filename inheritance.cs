using System;

class Person {
    public string Name;

    public Person(string name) {
        this.Name = name;
    }

    public virtual void Introduce() { // Virtual allows it to be overriden
        Console.WriteLine($"Hello, my name is {this.Name}.");
    }
}

class Student : Person { // Student inherits from Person
    public int StudentID;
    public Student(string name, int studentID) : base(name) // Calls the base constructor, the one that handles the name (line 7)
    {
        this.StudentID = studentID;
    }
    
    public override void Introduce() {
        Console.WriteLine($"Hello, my name is {this.Name}, and I'm a student.");

    }
}

class Building {
    public Person[] Occupants; // Creates an array called Occupants that holds Person objects

    public Building(int maxOccupancy) {
        this.Occupants = new Person[maxOccupancy];
    }

    
}

class Program {
    public static void Main(string[] args) {
        Person jeff = new Person("Jeff");
        jeff.Introduce();
        
        Building school = new Building(7); // Creates an array called Person[] going from 0-6, then it points to Occupants, and then the Occupants attribute points to the array, which all happen to be null atm
        
        school.Occupants[0] = jeff; // 0's no longer null, 0 points to name Jeff in the person constructor
        
        school.Occupants[0].Introduce();
        
        Student sally = new Student("Sally", 1234);
        sally.Introduce(); // Called the introduce method in the student class.
        
        // 1. Add sally to the building
        // 2. Then, get her to introduce herself by going through the building object "school"
        // 3. What happens if you write sally = null; ?
        // It gets rid of the pointer to the Student object, but we created another pointer by making location 1 point to Sally. If we get rid of Sally, school.Occupants[1] still points to Sally
        
        school.Occupants[1] = sally;
        
        school.Occupants[1].Introduce(); // Introduced the thing from the person class, not the student class. To fix this...
        
        

        }
    }
