/*
Exercises:
Create the UML, code the following classes, and create client
code (Main method) to work with them and print them out:
1. Chair
2. Table
3. Animal
*/

using System;

class Chair {
    public string Type;
    public float Size;
}

class Animal {
    public string Type;
    public int Legs;
    public string Name;
}

class Program {
    public static void Main(string[] args) {
        Chair JoeBiden =  new Chair();
        JoeBiden.Type = "Spikes";
        JoeBiden.Size = 0.01f;
        Console.WriteLine(JoeBiden.Type);
        Console.WriteLine(JoeBiden.Size);
        
        Animal Cat = new Animal();
        Cat.Type = "Feline";
        Cat.Legs = 999;
        Cat.Name = "Azula";
        Console.WriteLine(Cat.Type);
        Console.WriteLine(Cat.Legs);
        Console.WriteLine(Cat.Size);
        
    }
}
