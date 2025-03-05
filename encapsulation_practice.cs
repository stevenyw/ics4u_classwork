using System;

class Person {
    private int _BirthYear;
    private int _Age;
    private string _Name;
    
    public Person(string name, int age, int birthyear) {
        this._Name = name;
        this._Age = age;
        this._BirthYear = birthyear;
    }
        
    public int AgeGetter() {
        return this._Age;
    }
    
    public void AgeSetter(int age) {
        if (age < 0) {
            throw new ArgumentException("You can't be a negative age");
        }
        this._Age = age;
    }
}

class Program {
    public static void Main(string[] args) {
        Person Jeffy = new Person("jeffy", 4, 2005);
        int age = Jeffy.AgeGetter();
        Console.WriteLine(age);
    }
}
