using System;

class Character {
    public int Health;
    public int Mana;
    public int Strength;
    public int Intellect;

    public Character(int health, int mana, int strength, int intellect) {
        this.Health = health;
        this.Mana = mana;
        this.Strength = strength;
        this.Intellect = intellect;
    }

    public static Character CreateWarrior() { // ADD THE WORD CREATE!!!!!!!!!!!!! ITS CONVENTION :P
        return new Character(10, 0, 5, 5);
    }

    public static Character CreatePriest() {
        return new Character(5, 20, 5, 10);
    }

    public static Character CreateMage() {
        return new Character(5, 15, 3, 20);
    }
}

class Program {
    public static void Main(string[] args) {
        Character billybob = new Character(4, 4, 4, 4);
        Character priest = Character.CreatePriest();
        
        Console.WriteLine($"Billybob -> Health: {billybob.Health}, Mana: {billybob.Mana}");
        Console.WriteLine($"Priest -> Health: {priest.Health}, Mana: {priest.Mana}");
  
    }
}
