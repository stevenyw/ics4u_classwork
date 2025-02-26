using System;

class Person {
    public string Name;
    public int Age;
    public float NetWorth;
}

class Program {
    public static void Main(string[] args) {
        Console.WriteLine("New Hampshire");
        
        int[] nums = new int[5]; // Creates an array of 5 integers

        Person jeff = new Person(); // Creates a new person object for Jeff
        int num = 15; // Created int in main class. It doesn't point to the person class
        
        jeff.Name = "Dave";
        Console.WriteLine(jeff.Name);
        jeff.Age = 69;
        Console.WriteLine(jeff.Age);
        jeff.NetWorth = 69.420f; // REMEMBER TO ADD THE F.
        Console.WriteLine(jeff.NetWorth);
    }
}
