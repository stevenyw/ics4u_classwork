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

        int[] marks = {55, 65, 76, 77, 3};
        int adding = marks[0];

        foreach (int mark in marks) {
            if (mark < adding) {
            adding = mark;
            }
        }
        Console.WriteLine(adding); // Print the cumulative total
    }
}
