using System;

class Book {
    private string _title;
    private int _pages;

    public Book(string title, int pages) {
        if (title.Length > 20) {
            throw new ArgumentException("Title must be less than 20 characters");
        }
        this._title = title;

        if (pages < 0) {
            throw new ArgumentException("Pages cannot be negative");
        }
        this._pages = pages;
    }

    public override string ToString() {
        return $"Book - Title: {this._title}, Pages: {this._pages}";
    }

    // Accessor (Getter) for title
    public string GetTitle() {
        return this._title;
    }

    // Mutator (Setter) for title
    public void SetTitle(string title) {
        if (title.Length > 20) {
            throw new ArgumentException("Your title is too long");
        }
        this._title = title;
    }

    // Accessor (Getter) for pages
    public int GetPages() {
        return this._pages;
    }

    // Mutator (Setter) for pages
    public void SetPages(int pages) {
        if (pages < 0) {
            throw new ArgumentException("Pages cannot be negative");
        }
        this._pages = pages;
    }
}

class Program {
    public static void Main(string[] args) {
        Book myBook = new Book("Narnia", 234);
        Console.WriteLine(myBook.ToString());

        // Not allowed!
        // myBook._title = "Not Narnia. LoLZZZ";
        // myBook._pages = 0;

        // Console.WriteLine(myBook.ToString());
        string title = myBook.GetTitle();
        Console.WriteLine(title);

        myBook.SetTitle("Blah");


    }
}
