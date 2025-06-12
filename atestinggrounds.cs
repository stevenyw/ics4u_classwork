using System;

class Container {
    public string Brand;
    public string Color;
    private int _maxVolume;
    private int _volume;
    
    public Container(string brand, string color, int maxVolume) {
        this.Brand = brand;
        this.Color = color;
        this._maxVolume = maxVolume;
        this._volume = 0;
    }
    
    public virtual void Consume(int amount) {
        if (amount > this._volume) {
            throw new ArgumentException("You can't drink more than whats in the container");
        }
        this._volume -= amount;
    }
    public virtual void Fill(int amount) {
        if (amount > this._maxVolume - this._volume) {
            throw new ArgumentException("You can't fill more than what's in the container");
        }
        this._volume += amount;
    }
}

class SealableContainer : Container {
    
}


public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Try programiz.pro");
    }
}
