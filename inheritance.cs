using System;

class Person {
    public string Name;

    public Person(string name) {
        this.Name = name;
    }

    public void Introduce() {
        Console.WriteLine($"Hello, my name is {this.Name}.");
    }
}

class Student : Person { // Student inherits from Person
    public int StudentID;
    public Student(string name, int studentID) : base(name) // Calls the base constructor, the one that handles the name (line 7)
    {
        this.StudentID = studentID;
    }
}

class Building {
    public Person[] Occupants;

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
        sally.Introduce();
        
        
    }
}
