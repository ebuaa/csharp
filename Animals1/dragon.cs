using Animals1;

public class Dragon : Animal , IPilotage
{
    public void Moove()
    {
        Console.WriteLine("Dragon keep mooving \n");    
    }

    public Dragon()
    {
        this.Name = "Random griffin";
    }
    public Dragon(string name)
    {
        this.Name = name;
    }
    public override void Move()
    {
        Console.WriteLine("*flap flap, bruits du gros " + this.Name + " le dragon qui bouge*");
    }
    public override void Sleep()
    {
        Console.WriteLine("*" + this.Name + " le dragon dort*");
    }
}
