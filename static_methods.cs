using System;

class Program {
    public static void Main(string[] args) {
        Console.WriteLine("Name?");
        string name = Console.ReadLine();
        
        Console.WriteLine("violent action");
        string violence = Console.ReadLine();
        
        Hi(name, violence);
    }

    public static void Hi(string name, string violence) {
        Console.WriteLine($"HEY {name}!!!!! *{violence}* GET OUT OF BED!!!!!!!!!!");

        int adding = 0;
        int[] marks = {55, 65, 76, 77, 56};

        foreach (int mark in marks) {
            adding += mark; // Add the value of each mark to 'adding'
        }
        Console.WriteLine(adding); // Print the cumulative total
    }
}
