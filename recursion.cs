using System;

class Testing {
    
public static int Factorial(int n) { // Base case
        if (n == 0) {
            return 1; // Multiplies it by 1
        }
        return n * Factorial(n - 1); // The recursive step
    }
}
class Program
{
    public static void Main(string[] args)
{
    int result = Testing.Factorial(4);
    Console.WriteLine(result);
    }
}

// It cycles from 4 to 0 until it reaches 0, and then it goes back up and does the recursive step
// be(n=0) = return 1;
// be(n=1) = return 1 x 1 = 1;
// be(n=2) = return 2 x 1 = 2;
// be(n=3) = return 3 x 2 = 6;
// be (n=4) = return 4 x 6 = 24;
// main();
