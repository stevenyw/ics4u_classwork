using System;

class Person {
    public string Name;
    public int Age;
    
    public Person(string name, int age) {
        this.Age = age;
        this.Name = name;
    }
}

class Book {
    public string Title;
    public Person Author;
    
    public Book(string title, Person author) {
        this.Title = title;
        this.Author = author;
    }
}

class Program {
    public static void Main(string[] args) {
        Person person = new Person("Galileo", 42);
        Book Teli = new Book("Calcium", person);

        Console.WriteLine(Teli.Author.Name);
    }
}
