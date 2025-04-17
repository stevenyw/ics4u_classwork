using System;

class Testing {
    public static int Fibonacci(int n) {
        Console.WriteLine($"Fibonacci(n={n})");
        if (n == 0) {
            return 0;
        }
        if (n == 1) {
            return 1;
        }
        return Fibonacci(n-1) + Fibonacci(n-2);
    }
    
}

class Program
{
    public static void Main(string[] args)
    {
        int fiber = Testing.Fibonacci(4);
        Console.WriteLine(fiber);
    }
}

// if it reaches 0, return 0
// return Fibonacci(n-1) + Fibonacci(n-2);
// n = 2
// Fibonacci(1) + Fibonacci(0);
// return 1;
