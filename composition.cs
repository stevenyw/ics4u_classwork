using System;

class Player {
    private int _stats;
    public Player(int maxHealth) {
        this._stats = maxHealth;
    }
    public void TakeDamage(int amount) {
        if (amount < 0) {
            throw new ArgumentException("you can't take negative health");
        }
        this._stats -= amount;
    }
    public void Heal(int amount) {
        if (amount < 0) {
            throw new ArgumentException("you can't heal a negative amount");
        }
        this._stats += amount;
    }
    public int GetHealth() {
        return this._stats;
    }
    class Stats {
        private int _currentHealth;
        private int _maxHealth;
        private int _armour;
        
        public Stats(int maxHealth, int armour) {
            this._currentHealth = maxHealth;
            this._maxHealth = maxHealth;
            this._armour = armour;
        }
        public void ReduceHealth(int amount) {
            if (amount < 0) {
                throw new ArgumentException("you can't reduce health by a negative amount");
            }
            this._currentHealth -= amount;
        }
        public void IncreaseHealth(int amount) {
            if (amount < 0) {
                throw new ArgumentException("you can't increase health by a negative amount");
            }
            this._currentHealth += amount;
        }
        public int GetHealth() {
            return this._currentHealth;
        }
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Try programiz.pro");
    }
}
