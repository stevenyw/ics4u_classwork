using System;

class Person {
    public string Name;
    public int Energy;

    public void Testing() {
        Console.WriteLine("kaboom");
    }

    public Person(string name) {  // Constructor initializes Name and Energy
        this.Name = name;
        this.Energy = 100;
    }

    public override string ToString() {  
        if (this.Energy <= 0) {
            return $"{this.Name} has died.";
        }
        return $"{this.Name}, Energy: {this.Energy}";
    }

    public void DoJumpingJacks(int n) {
        for (int i = 0; i < n; i++) {
            if (this.Energy <= 0) {
                Console.WriteLine("I'm too tired.");
                break;
            }
            Console.WriteLine("Jumping Jack!");
            this.Energy -= 25;
        }
    }
}

class Program {
    public static void Main(string[] args) {
        Person Jeffy = new Person("RonaldReagan");
        Console.WriteLine(Jeffy.ToString());
        Jeffy.DoJumpingJacks(5);
        Console.WriteLine(Jeffy.ToString());
    }
}
