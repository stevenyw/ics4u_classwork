using System;

class Door {
    public string Color;
    public bool IsOpen;

    // Constructor 1
    public Door(string color, bool isOpen) {
        this.Color = color;
        this.IsOpen = isOpen;
    }
    
    // Constructor 2
    public Door(string color) {
        this.Color = color;
        this.IsOpen = false;
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Las Vegas");

        Door Obama = new Door("Blue", true); // Uses first constructor
        Door Trump = new Door("Red"); // Uses second constructor
        
        Console.WriteLine(Trump.Color);
        Console.WriteLine(Trump.IsOpen);
}
}
