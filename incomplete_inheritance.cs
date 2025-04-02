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
    
    public void Consume(int amount) {
        if (this._volume <= 0) {
            throw new ArgumentException("Container is empty");
        }
        this._volume -= amount;
    }
    
    public void Fill(int amount) {
        if (this._volume >= this._maxVolume) {
            throw new ArgumentException("Container is full");
        }
        this._volume += amount;
    }
    
    class SealableContainer : Container {
        private bool _isSealed = true;
        
        public SealableContainer(string brand, string color, int maxVolume) : base(brand, color, maxVolume) {
        }
    }
}

class Program {
    public static void Main(string[] args)
    {
        Console.WriteLine ("Try programiz.pro");
    }
}
