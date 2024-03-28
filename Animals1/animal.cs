using System;
using System.Xml.Linq;

/// <summary>
/// Summary description for Class1
/// </summary>
public abstract class Animal
{
    public string Name { get; protected set; }
    public string Rarity { get; set; }
    public virtual void move() { }

    public virtual void sleep() { }

    public void display()
    {
        Console.WriteLine("Name: " + Name + " Rarity: " + Rarity);
    }
}
