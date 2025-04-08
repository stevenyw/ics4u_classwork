using System;

class Pizza {
private string[] _toppings;

public Pizza(string[] toppings) {
    this._toppings = toppings; // Makes the toppings array
}

public void PrintToppings() {
    foreach (string t in this._toppings) { // Loops through the strings in the array
        Console.WriteLine(t);
    }
}

public static Pizza CreateMeatLovers() {
    return new Pizza(new string[] {
    "cheese",
    "ground beef",
    "pepperoni",
    "bacon",
    "sausage" }); // Sets the new array for meat lovers pizza
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Pizza pizza = new Pizza(new string[] {"cheese"});
        Pizza meaty = Pizza.CreateMeatLovers(); // The new object, meaty, is now has the createmeatlovers() toppings
        meaty.PrintToppings();
    }
}
