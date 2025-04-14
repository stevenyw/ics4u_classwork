using System;

class Testing {
    public static int BunnyEars(int b) {
        if (b==0) {
            return 0; // Base Case
        }
        return 2 + BunnyEars(b-1); // Recursive step
    }
}


class Program
{
    public static void Main(string[] args)
    {
        int testing = Testing.BunnyEars(4);
        Console.WriteLine(testing);
    }
}

// be(b=0) = return 0;
// be(b=1) = return 2 + 0;
// be(b=2) = return 2 + 2;
// be(b=3) = return 2 + 4;
// be(b=4) = return 4 + 4;
