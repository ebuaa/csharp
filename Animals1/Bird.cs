using System;
using Animals1;

public class Bird : Animal, IFly
{
    public Bird() { }

    public Bird(string Name, string Rarity)
    {
        this.Name = Name;
        this.Rarity = Rarity;
    }

    public Bird(string Name)
    {
        this.Name = Name;
    }

    public virtual void Fly()
    {
        Console.WriteLine(this.Name + " is flying" );
    }

    public override void move()
    {
        Console.WriteLine(this.Name + " is moving");
    }

    public override void sleep()
    {
        Console.WriteLine(this.Name + " is sleeping");
    }
}