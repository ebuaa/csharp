public class Dragon : Animal
{
    Dragon()
    {
        this.Name = "Random griffin";
    }
    public Dragon(string name)
    {
        this.Name = name;
    }
    public override void Move()
    {
        Console.WriteLine("*flap flap, bruits du gros "+this.Name +" le dragon qui bouge*");
    }
    public override void Sleep()
    {
        Console.WriteLine("*"+ this.Name + " le dragon fait dodo pepouze*");
    }
}
