using System;
using System.Xml.Linq;

/// <summary>
/// Summary description for Class1
/// </summary>
public abstract class Animal
{
    private string _name;


    public string Name { get { return _name; } protected set { _name = value; } }

    public abstract void Move();
    public abstract void Sleep();
}
