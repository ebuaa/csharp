using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public abstract class Animal
{
    public string Name { get { return Name; } protected set { Name = value; } }

    public abstract void Move();
    public abstract void Sleep();
}
